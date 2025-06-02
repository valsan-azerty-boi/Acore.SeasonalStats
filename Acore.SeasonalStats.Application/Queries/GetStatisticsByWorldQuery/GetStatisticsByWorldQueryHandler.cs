using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public class GetStatisticsByWorldQueryHandler : IRequestHandler<GetStatisticsByWorldQuery, IEnumerable<SimpleStatisticViewModel>>
{
    public GetStatisticsByWorldQueryHandler()
    {
        //_statisticRepository = statisticRepository;
    }

    public async Task<IEnumerable<SimpleStatisticViewModel>> Handle(GetStatisticsByWorldQuery request, CancellationToken cancellationToken)
    {
        //var statistic = await _statisticRepository.GetStatistic(cancellationToken);
        //return new StatisticViewModel(statistic));

        return await Task.FromResult(new List<SimpleStatisticViewModel>
        {
            new("Onyxia down", 1, 1, 1, request.ServerId),
            new("AQ40 down", 1, 1, 2, request.ServerId),
            new("Ragnaros down", 1, 2, 1, request.ServerId),
            new("Nefarian down", 1, 3, 1, request.ServerId)
        });
    }
}
