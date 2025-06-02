using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public record GetSeasonQuery(int SeasonId) : IRequest<SeasonViewModel>;
