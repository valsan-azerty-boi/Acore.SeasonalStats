using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, CategoryViewModel>
{
    public GetCategoryQueryHandler()
    {
        //_categoryRepository = categoryRepository;
    }

    public async Task<CategoryViewModel> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
    {
        //var category = await _categoryRepository.GetCategory(cancellationToken);
        //return new CategoryViewModel(category));

        return await Task.FromResult(new CategoryViewModel(request.CategoryId, "Test categ"));
    }
}
