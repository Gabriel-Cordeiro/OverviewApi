using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Overview.Repository.Configuration
{
    public class OverviewContextFactory : IDesignTimeDbContextFactory<OverviewContext>
    {
        public OverviewContext CreateDbContext(string[] args)
        {
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                .Build();

            var builder = new DbContextOptionsBuilder<OverviewContext>();

            var connectionString = configuration.GetConnectionString("dbConnection");

            builder.UseSqlServer(connectionString);

            return new OverviewContext(builder.Options);
        }
    }
}
