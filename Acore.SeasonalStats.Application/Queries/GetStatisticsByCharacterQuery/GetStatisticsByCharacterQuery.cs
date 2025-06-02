using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public record GetStatisticsByCharacterQuery(int CharacterId, int ServerId) : IRequest<IEnumerable<SimpleStatisticViewModel>>;
