using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Acore.SeasonalStats.Infrastructure
{
    public class SeasonalStatsDbContextFactory : IDesignTimeDbContextFactory<SeasonalStatsDbContext>
    {
        public SeasonalStatsDbContext CreateDbContext(string[] args)
        {
            var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..", "Acore.SeasonalStats.Api"))
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile($"appsettings.{envName}.json", optional: true)
                .Build();

            var connectionString = configuration.GetConnectionString("MySqlConnection");

            var optionsBuilder = new DbContextOptionsBuilder<SeasonalStatsDbContext>();
            if (connectionString != null)
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new SeasonalStatsDbContext(optionsBuilder.Options);
        }
    }
}
