using System.ComponentModel.DataAnnotations;

namespace Acore.SeasonalStats.Domain;

public class World
{
    public int Id { get; set; }

    [MaxLength(128)]
    public string? Name { get; set; }

    public ICollection<Season> Seasons { get; set; } = new List<Season>();
    public ICollection<Character> Characters { get; set; } = new List<Character>();
}
