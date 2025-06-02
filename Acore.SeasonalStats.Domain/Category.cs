namespace Acore.SeasonalStats.Domain;

public class Category
{
    public int Id { get; set; }
    
    public string? Name { get; set; } = string.Empty;

    public ICollection<Statistic> Statistics { get; set; } = new List<Statistic>();
}
