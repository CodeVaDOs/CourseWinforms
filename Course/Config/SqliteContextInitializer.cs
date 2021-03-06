using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Annotations;
using System.IO;
using System.Linq;

namespace Course.Config
{
    internal class SqliteContextInitializer<T> : IDatabaseInitializer<T>
        where T : DbContext
    {
        private readonly bool _dbExists;
        private readonly DbModelBuilder _modelBuilder;

        public SqliteContextInitializer(string dbPath, DbModelBuilder modelBuilder)
        {
            _dbExists = File.Exists(dbPath);
            _modelBuilder = modelBuilder;
        }

        public void InitializeDatabase(T context)
        {
            if (_dbExists)
            {
                return;
            }

            DbModel model = _modelBuilder.Build(context.Database.Connection);

            using (DbContextTransaction xact = context.Database.BeginTransaction())
            {
                try
                {
                    CreateDatabase(context.Database, model);
                    xact.Commit();
                }
                catch (Exception)
                {
                    xact.Rollback();
                    throw;
                }
            }
        }

        private class Index
        {
            public string Name { get; set; }
            public string Table { get; set; }
            public List<string> Columns { get; set; }
        }

        private void CreateDatabase(Database db, DbModel model)
        {
            const string tableTmpl = "CREATE TABLE [{0}] (\n{1}\n);";
            const string columnTmpl = "    [{0}] {1} {2}"; // name, type, decl
            const string primaryKeyTmpl = "    PRIMARY KEY ({0})";
            const string foreignKeyTmpl = "    FOREIGN KEY ({0}) REFERENCES {1} ({2})";
            const string indexTmpl = "CREATE INDEX {0} ON {1} ({2});";

            Dictionary<string, Index> indicies = new Dictionary<string, Index>();

            foreach (System.Data.Entity.Core.Metadata.Edm.EntityType type in model.StoreModel.EntityTypes)
            {
                List<string> defs = new List<string>();

                // columns
                foreach (System.Data.Entity.Core.Metadata.Edm.EdmProperty p in type.Properties)
                {
                    HashSet<string> decls = new HashSet<string>();

                    if (!p.Nullable)
                    {
                        decls.Add("NOT NULL");
                    }

                    IEnumerable<IndexAnnotation> annotations = p.MetadataProperties
                        .Select(x => x.Value)
                        .OfType<IndexAnnotation>();

                    foreach (IndexAnnotation annotation in annotations)
                    {
                        foreach (System.ComponentModel.DataAnnotations.Schema.IndexAttribute attr in annotation.Indexes)
                        {
                            if (attr.IsUnique)
                            {
                                decls.Add("UNIQUE");
                            }

                            if (string.IsNullOrEmpty(attr.Name))
                            {
                                continue;
                            }

                            Index index;
                            if (!indicies.TryGetValue(attr.Name, out index))
                            {
                                index = new Index
                                {
                                    Name = attr.Name,
                                    Table = type.Name,
                                    Columns = new List<string>(),
                                };
                                indicies.Add(index.Name, index);
                            }
                            index.Columns.Add(p.Name);
                        }
                    }

                    defs.Add(string.Format(columnTmpl, p.Name, p.TypeName, string.Join(" ", decls)));
                }

                // primary keys
                if (type.KeyProperties.Any())
                {
                    IEnumerable<string> keys = type.KeyProperties.Select(x => x.Name);
                    defs.Add(string.Format(primaryKeyTmpl, string.Join(", ", keys)));
                }

                // foreign keys
                foreach (System.Data.Entity.Core.Metadata.Edm.AssociationType assoc in model.StoreModel.AssociationTypes)
                {
                    if (assoc.Constraint.ToRole.Name == type.Name)
                    {
                        IEnumerable<string> thisKeys = assoc.Constraint.ToProperties.Select(x => x.Name);
                        IEnumerable<string> thatKeys = assoc.Constraint.FromProperties.Select(x => x.Name);
                        defs.Add(string.Format(foreignKeyTmpl,
                            string.Join(", ", thisKeys),
                            assoc.Constraint.FromRole.Name,
                            string.Join(", ", thatKeys)));
                    }
                }

                // create table
                string sql = string.Format(tableTmpl, type.Name, string.Join(",\n", defs));
                db.ExecuteSqlCommand(sql);
            }

            // create index
            foreach (Index index in indicies.Values)
            {
                string columns = string.Join(", ", index.Columns);
                string sql = string.Format(indexTmpl, index.Name, index.Table, columns);
                db.ExecuteSqlCommand(sql);
            }
        }
    }
}