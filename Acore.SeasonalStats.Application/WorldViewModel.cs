using Acore.SeasonalStats.Domain;

namespace Acore.SeasonalStats.Application;

public record WorldViewModel(int ServerId, string? ServerName)
{
    public WorldViewModel(World world): this(world.Id, world.Name) { }
}
