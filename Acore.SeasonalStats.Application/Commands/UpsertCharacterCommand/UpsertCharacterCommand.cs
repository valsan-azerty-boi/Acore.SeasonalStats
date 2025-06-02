using MediatR;

namespace Acore.SeasonalStats.Application.Commands;

public record UpsertCharacterCommand(int CharacterId, int ServerId, string? CharacterName, int? CharacterLevel, string? CharacterFaction, string? CharacterRace, string? CharacterClass, string? CharacterGuild) : IRequest<CharacterViewModel>;
