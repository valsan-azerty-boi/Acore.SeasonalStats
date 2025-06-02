using Acore.SeasonalStats.Domain;

namespace Acore.SeasonalStats.Application;

public record WorldViewModel(int ServerId, string? ServerName)
{
    public WorldViewModel(World server): this(server.Id, server.Name) { }
}
