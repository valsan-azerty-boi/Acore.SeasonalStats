using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public record GetAllWorldsQuery : IRequest<IEnumerable<WorldViewModel>>;
