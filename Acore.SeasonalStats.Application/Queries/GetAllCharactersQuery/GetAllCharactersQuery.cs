using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public record GetAllCharactersQuery : IRequest<IEnumerable<SimpleCharacterViewModel>>;
