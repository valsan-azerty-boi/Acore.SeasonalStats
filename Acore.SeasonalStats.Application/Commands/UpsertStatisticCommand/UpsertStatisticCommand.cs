using MediatR;

namespace Acore.SeasonalStats.Application.Commands;

public record UpsertStatisticCommand(int CharacterId, int ServerId, int SeasonId, int CategoryId, string Content, int Weight) : IRequest<StatisticViewModel>;
