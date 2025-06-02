using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public class GetStatisticQueryHandler : IRequestHandler<GetStatisticQuery, StatisticViewModel>
{
    public GetStatisticQueryHandler()
    {
        //_statisticRepository = statisticRepository;
    }

    public async Task<StatisticViewModel> Handle(GetStatisticQuery request, CancellationToken cancellationToken)
    {
        //var statistic = await _statisticRepository.GetStatistic(cancellationToken);
        //return new StatisticViewModel(statistic));

        return await Task.FromResult(
            new StatisticViewModel("Onyxia down", 1, new CategoryViewModel(request.CategoryId, "Raid progression"),
                new SimpleCharacterViewModel(request.CharacterId, "Testitatotu", 80, "Horde", "Orc", "Warrior", "Peons"), 
                new SimpleSeasonViewModel(request.SeasonId, "test season"),
                new WorldViewModel(request.ServerId, "Acore Test PvP server")
                )
            );
    }
}
