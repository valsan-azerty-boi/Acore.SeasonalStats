using Acore.SeasonalStats.Infrastructure;
using Acore.SeasonalStats.Infrastructure.Interfaces;
using Acore.SeasonalStats.Infrastructure.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Acore.SeasonalStats.Application.Queries;

public class GetCategoryQueryHandler(ICategoryRepository categoryRepository)
    : IRequestHandler<GetCategoryQuery, CategoryViewModel?>
{
    public async Task<CategoryViewModel?> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
    {
        var category = await categoryRepository.GetByIdAsync(request.CategoryId, cancellationToken);
        return category != null ? new CategoryViewModel(category.Id, category.Name) : null;
    }
}
