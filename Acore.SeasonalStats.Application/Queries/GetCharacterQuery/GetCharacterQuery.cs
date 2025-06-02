using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public record GetCharacterQuery(int CharacterId, int ServerId) : IRequest<CharacterViewModel>;
