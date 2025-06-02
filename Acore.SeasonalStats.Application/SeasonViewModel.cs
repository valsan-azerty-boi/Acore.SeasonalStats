using Acore.SeasonalStats.Domain;

namespace Acore.SeasonalStats.Application;

public record SeasonViewModel(int SeasonId, string? SeasonName, WorldViewModel? World)
{
    public SeasonViewModel(Season season) : this(season.Id, season.Name, new WorldViewModel(season.WorldId, season.World.Name)) { }
}
