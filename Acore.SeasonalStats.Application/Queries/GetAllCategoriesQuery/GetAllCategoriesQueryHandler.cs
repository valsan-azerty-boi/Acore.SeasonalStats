using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, IEnumerable<CategoryViewModel>>
{
    public GetAllCategoriesQueryHandler()
    {
        //_categoryRepository = categoryRepository;
    }

    public async Task<IEnumerable<CategoryViewModel>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
    {
        //var categories = await _categoryRepository.GetAllCategories(cancellationToken);
        //return categories.Select(
        //    categ => new CategoryViewModel(1, "test"));

        return await Task.FromResult(new List<CategoryViewModel>
        {
            new(1, "test PvE categ"),
            new(2, "test PvP categ"),
        });
    }
}
