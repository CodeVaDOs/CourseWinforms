﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Annotations;
using System.IO;
using System.Linq;

namespace Course.Config
{
    class SqliteContextInitializer<T> : IDatabaseInitializer<T>
        where T : DbContext
    {
        bool _dbExists;
        DbModelBuilder _modelBuilder;

        public SqliteContextInitializer(string dbPath, DbModelBuilder modelBuilder)
        {
            _dbExists = File.Exists(dbPath);
            _modelBuilder = modelBuilder;
        }

        public void InitializeDatabase(T context)
        {
            if (_dbExists)
                return;

            var model = _modelBuilder.Build(context.Database.Connection);

            using (var xact = context.Database.BeginTransaction())
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

        class Index
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

            var indicies = new Dictionary<string, Index>();

            foreach (var type in model.StoreModel.EntityTypes)
            {
                var defs = new List<string>();

                // columns
                foreach (var p in type.Properties)
                {
                    var decls = new HashSet<string>();

                    if (!p.Nullable)
                        decls.Add("NOT NULL");

                    var annotations = p.MetadataProperties
                        .Select(x => x.Value)
                        .OfType<IndexAnnotation>();

                    foreach (var annotation in annotations)
                    {
                        foreach (var attr in annotation.Indexes)
                        {
                            if (attr.IsUnique)
                                decls.Add("UNIQUE");

                            if (string.IsNullOrEmpty(attr.Name))
                                continue;

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
                    var keys = type.KeyProperties.Select(x => x.Name);
                    defs.Add(string.Format(primaryKeyTmpl, string.Join(", ", keys)));
                }

                // foreign keys
                foreach (var assoc in model.StoreModel.AssociationTypes)
                {
                    if (assoc.Constraint.ToRole.Name == type.Name)
                    {
                        var thisKeys = assoc.Constraint.ToProperties.Select(x => x.Name);
                        var thatKeys = assoc.Constraint.FromProperties.Select(x => x.Name);
                        defs.Add(string.Format(foreignKeyTmpl,
                            string.Join(", ", thisKeys),
                            assoc.Constraint.FromRole.Name,
                            string.Join(", ", thatKeys)));
                    }
                }

                // create table
                var sql = string.Format(tableTmpl, type.Name, string.Join(",\n", defs));
                db.ExecuteSqlCommand(sql);
            }

            // create index
            foreach (var index in indicies.Values)
            {
                var columns = string.Join(", ", index.Columns);
                var sql = string.Format(indexTmpl, index.Name, index.Table, columns);
                db.ExecuteSqlCommand(sql);
            }
        }
    }
}