using Acore.SeasonalStats.Domain;

namespace Acore.SeasonalStats.Application;

public record SimpleStatisticViewModel(string Content, int CategoryId, int CharacterId, int SeasonId, int ServerId)
{
    public SimpleStatisticViewModel(Statistic stat) : this(stat.Content, stat.Category.Id, stat.Character.Id, stat.Season.Id, stat.Character.World.Id) { }
}
