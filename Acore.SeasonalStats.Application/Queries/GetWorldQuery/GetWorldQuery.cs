using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public record GetWorldQuery(int WorldId) : IRequest<WorldViewModel>;
