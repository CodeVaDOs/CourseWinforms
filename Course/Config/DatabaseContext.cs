using Course.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;

namespace Course.Config
{
    public class DatabaseContext : DbContext
    {
        string _path;
        public DatabaseContext(string path="db.db") :
            base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = path, ForeignKeys = true }.ConnectionString
            }, true)
        {
            _path = path;
            Console.WriteLine("CREATE DB CONTEXT");
            Configuration.ProxyCreationEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<User>()
                .HasMany<Log>(u => u.Logs)
                .WithRequired(l => l.User)
                .HasForeignKey<long>(u => u.UserID)
                .WillCascadeOnDelete();


            Database.SetInitializer(new SqliteContextInitializer<DatabaseContext>(_path, modelBuilder));
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
