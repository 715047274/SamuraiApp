using System;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SamuraiApp.Domain;

namespace SamuraiApp.Data
{
    public class SamuraiContext : DbContext
    {
        // public SamuraiContext(DbContextOptions opt) : base(opt)
        // {
        // }

        public SamuraiContext()
        {
            Database.EnsureCreated();
         }

        public DbSet<Samurai> Samurais { get; set; }
        //public DbSet<Battle> Battles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter((category, level) =>
                        category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information)
                    .AddConsole();
            });
            
             
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "samurai.db");
            var fullPath = Path.GetFullPath(filePath);
            Console.WriteLine(filePath);
            optionsBuilder
                .UseSqlite("Data Source = " + fullPath)
                .UseLoggerFactory(loggerFactory)
                .EnableSensitiveDataLogging();
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SamuraiContext).Assembly);
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                    e.State == EntityState.Added
                    || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity) entityEntry.Entity).UpdatedOn = DateTime.UtcNow;

                if (entityEntry.State == EntityState.Added)
                    ((BaseEntity) entityEntry.Entity).CreatedOn = DateTime.UtcNow;
            }

            return base.SaveChanges();
        }
    }
}