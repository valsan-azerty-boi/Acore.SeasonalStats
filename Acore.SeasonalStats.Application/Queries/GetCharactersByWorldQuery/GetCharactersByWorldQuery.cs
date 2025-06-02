using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public record GetCharactersByWorldQuery(int ServerId) : IRequest<IEnumerable<SimpleCharacterViewModel>>;
