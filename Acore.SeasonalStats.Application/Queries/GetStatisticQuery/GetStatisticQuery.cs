using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public record GetStatisticQuery(int CharacterId, int ServerId, int SeasonId, int CategoryId) : IRequest<StatisticViewModel>;
