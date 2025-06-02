using Microsoft.EntityFrameworkCore;
using Acore.SeasonalStats.Domain;

namespace Acore.SeasonalStats.Infrastructure;

public sealed class SeasonalStatsDbContext : DbContext
{
    public SeasonalStatsDbContext(DbContextOptions<SeasonalStatsDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<World> Worlds { get; set; }
    public DbSet<Season> Seasons { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Statistic> Statistics { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Statistic>()
            .HasKey(s => new { s.CharacterId, s.WorldId, s.SeasonId, s.CategoryId });
    }
}
