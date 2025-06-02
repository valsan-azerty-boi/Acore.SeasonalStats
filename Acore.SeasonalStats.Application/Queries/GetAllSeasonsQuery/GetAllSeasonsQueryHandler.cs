using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public class GetAllSeasonsQueryHandler : IRequestHandler<GetAllSeasonsQuery, IEnumerable<SeasonViewModel>>
{
    public GetAllSeasonsQueryHandler()
    {
        //_seasonRepository = seasonRepository;
    }

    public async Task<IEnumerable<SeasonViewModel>> Handle(GetAllSeasonsQuery request, CancellationToken cancellationToken)
    {
        //var seasons = await _seasonRepository.GetAllCategories(cancellationToken);
        //return seasons.Select(
        //    categ => new SeasonViewModel(1, "Season test"));

        return await Task.FromResult(new List<SeasonViewModel>
        {
            new(1, "test Season 1", new WorldViewModel(1, "test server 1")),
            new(2, "test Season 2", new WorldViewModel(1, "test server 1")),
            new(6, "test Season 1", new WorldViewModel(2, "test server 2"))
        });
    }
}
