using Microsoft.EntityFrameworkCore;
using Overview.Core.Entities;
using System.Reflection;

namespace Overview.Repository.Configuration
{
    public class OverviewContext : DbContext
    {
        public OverviewContext(DbContextOptions<OverviewContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
