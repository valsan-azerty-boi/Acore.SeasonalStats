using System.ComponentModel.DataAnnotations;

namespace Acore.SeasonalStats.Domain;

public class Character
{
    public int Id { get; set; }
    public int WorldId { get; set; }

    [MaxLength(32)]
    public string? Name { get; set; }
    public int? Level { get; set; }
    [MaxLength(16)]
    public string? Faction { get; set; }
    [MaxLength(32)]
    public string? Race { get; set; }
    [MaxLength(32)]
    public string? Class { get; set; }
    [MaxLength(64)]
    public string? Guild { get; set; }

    public World World { get; set; } = null!;
}
