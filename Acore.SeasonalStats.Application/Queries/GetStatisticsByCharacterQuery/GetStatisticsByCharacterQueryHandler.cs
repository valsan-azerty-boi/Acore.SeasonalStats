using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public class GetStatisticsByCharacterQueryHandler : IRequestHandler<GetStatisticsByCharacterQuery, IEnumerable<SimpleStatisticViewModel>>
{
    public GetStatisticsByCharacterQueryHandler()
    {
        //_statisticRepository = statisticRepository;
    }

    public async Task<IEnumerable<SimpleStatisticViewModel>> Handle(GetStatisticsByCharacterQuery request, CancellationToken cancellationToken)
    {
        //var statistic = await _statisticRepository.GetStatistic(cancellationToken);
        //return new StatisticViewModel(statistic));

        return await Task.FromResult(new List<SimpleStatisticViewModel>
        {
            new("Onyxia down", 1, request.CharacterId, 1, request.ServerId),
            new("AQ40 down", 1, request.CharacterId, 2, request.ServerId)
        });
    }
}
