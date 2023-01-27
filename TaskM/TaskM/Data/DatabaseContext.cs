using Microsoft.EntityFrameworkCore;
using TaskM.Data.Configurations;
using TaskM.Models.WorkItems;

namespace TaskM.Data
{
    public class DatabaseContext : DbContext
    {
        DbSet<WorkItem> WorkItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbConfig = new DatabaseConfiguration();
            optionsBuilder.UseSqlite($"Data Source = {dbConfig.Path}");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new WorkItemConfiguration());
        }
    }
}
