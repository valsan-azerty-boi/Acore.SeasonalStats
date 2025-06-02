using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public record GetAllSeasonsQuery : IRequest<IEnumerable<SeasonViewModel>>;
