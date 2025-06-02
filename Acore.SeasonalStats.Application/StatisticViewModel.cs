using Acore.SeasonalStats.Domain;

namespace Acore.SeasonalStats.Application;

public record StatisticViewModel(string Content, int Weight, CategoryViewModel Category, SimpleCharacterViewModel Character, SimpleSeasonViewModel Season, WorldViewModel Server)
{
    public StatisticViewModel(Statistic stat) : this(stat.Content, stat.Weight, new CategoryViewModel(stat.Category), new SimpleCharacterViewModel(stat.Character), new SimpleSeasonViewModel(stat.Season), new WorldViewModel(stat.Character.World)) { }
}
