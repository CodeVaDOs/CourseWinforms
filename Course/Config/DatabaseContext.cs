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

            modelBuilder.Entity<Test>()
                .HasMany<Question>(t => t.Questions)
                .WithRequired(q => q.Test)
                .HasForeignKey<long>(t => t.TestID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Question>()
                .HasMany<Answer>(q => q.Answers)
                .WithRequired(a => a.Question)
                .HasForeignKey<long>(q => q.QuestionID)
                .WillCascadeOnDelete();


            // TEST RESULTS
            modelBuilder.Entity<Test>()
                .HasMany<TestResult>(t => t.TestResults)
                .WithRequired(t => t.Test)
                .HasForeignKey<long>(t => t.TestID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<User>()
                .HasMany<TestResult>(u => u.TestResults)
                .WithRequired(t => t.User)
                .HasForeignKey<long>(t => t.UserID)
                .WillCascadeOnDelete();

            Database.SetInitializer(new SqliteContextInitializer<DatabaseContext>(_path, modelBuilder));
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
    }
}
