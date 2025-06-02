using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public class GetSeasonQueryHandler : IRequestHandler<GetSeasonQuery, SeasonViewModel>
{
    public GetSeasonQueryHandler()
    {
        //_seasonRepository = seasonRepository;
    }

    public async Task<SeasonViewModel> Handle(GetSeasonQuery request, CancellationToken cancellationToken)
    {
        //var season = await _seasonRepository.GetSeason(cancellationToken);
        //return new SeasonViewModel(season));

        return await Task.FromResult(new SeasonViewModel(request.SeasonId, "Test season 1", new WorldViewModel(1, "test server")));
    }
}
