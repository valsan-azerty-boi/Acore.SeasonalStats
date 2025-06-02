using Acore.SeasonalStats.Domain;

namespace Acore.SeasonalStats.Application;

public record SeasonViewModel(int SeasonId, string? SeasonName, WorldViewModel? Server)
{
    public SeasonViewModel(Season season) : this(season.Id, season.Name, new WorldViewModel(season.World.Id, season.World.Name)) { }
}
