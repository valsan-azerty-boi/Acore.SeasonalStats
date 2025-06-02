using Acore.SeasonalStats.Domain;

namespace Acore.SeasonalStats.Application;

public record CategoryViewModel(int CategoryId, string? CategoryName)
{
    public CategoryViewModel(Category category) : this(category.Id, category.Name) { }
}
