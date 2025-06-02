namespace Acore.SeasonalStats.Domain;

public class Season
{
    public int WorldId { get; set; }
    public int Id { get; set; }
    
    public string? Name { get; set; }

    public World World { get; set; } = null!;
}
