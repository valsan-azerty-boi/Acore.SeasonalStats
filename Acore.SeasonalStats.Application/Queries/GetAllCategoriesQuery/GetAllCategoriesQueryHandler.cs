using Acore.SeasonalStats.Infrastructure;
using Acore.SeasonalStats.Infrastructure.Interfaces;
using Acore.SeasonalStats.Infrastructure.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Acore.SeasonalStats.Application.Queries;

public class GetAllCategoriesQueryHandler(ICategoryRepository categoryRepository)
    : IRequestHandler<GetAllCategoriesQuery, IEnumerable<CategoryViewModel>>
{
    public async Task<IEnumerable<CategoryViewModel>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
    {
        var categories = await categoryRepository.GetAllAsync(cancellationToken);
        return categories.Select(c => new CategoryViewModel(c.Id, c.Name ?? string.Empty));
    }
}
