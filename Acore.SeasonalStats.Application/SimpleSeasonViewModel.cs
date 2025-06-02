using Acore.SeasonalStats.Domain;

namespace Acore.SeasonalStats.Application;

public record SimpleSeasonViewModel(int SeasonId, string? SeasonName)
{
    public SimpleSeasonViewModel(Season season) : this(season.Id, season.Name) { }
}
