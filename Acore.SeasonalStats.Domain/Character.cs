namespace Acore.SeasonalStats.Domain;

public class Character
{
    public int Id { get; set; }
    public int WorldId { get; set; }

    public string? Name { get; set; }
    public int? Level { get; set; }
    public string? Faction { get; set; }
    public string? Race { get; set; }
    public string? Class { get; set; }
    public string? Guild { get; set; }

    public World World { get; set; } = null!;
}
