using System.ComponentModel.DataAnnotations;

namespace Acore.SeasonalStats.Domain;

public class Statistic
{
    public int CharacterId { get; set; }
    public int WorldId { get; set; }
    public int SeasonId { get; set; }
    public int CategoryId { get; set; }

    [MaxLength(1024)]
    public string Content { get; set; } = string.Empty;
    public int Weight { get; set; } = 0;

    public Character Character { get; set; } = null!;
    public Season Season { get; set; } = null!;
    public Category Category { get; set; } = null!;
}
