using System.ComponentModel.DataAnnotations;

namespace Acore.SeasonalStats.Domain;

public class Category
{
    public int Id { get; set; }

    [MaxLength(32)]
    public string? Name { get; set; }

    public ICollection<Statistic> Statistics { get; set; } = new List<Statistic>();
}
