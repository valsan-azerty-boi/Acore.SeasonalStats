using MediatR;

namespace Acore.SeasonalStats.Application.Commands;

public record UpsertSeasonCommand(int SeasonId, int ServerId, string? SeasonName) : IRequest<SeasonViewModel>;
