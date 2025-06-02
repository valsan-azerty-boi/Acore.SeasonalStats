using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public record GetStatisticsByWorldQuery(int ServerId) : IRequest<IEnumerable<SimpleStatisticViewModel>>;
