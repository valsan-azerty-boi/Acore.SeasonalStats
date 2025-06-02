using Acore.SeasonalStats.Domain;

namespace Acore.SeasonalStats.Application;

public record SimpleCharacterViewModel(int CharacterId, string? CharacterName, int? Level, string? Faction, string? Race, string? Class, string? Guild)
{
    public SimpleCharacterViewModel(Character character) : this(character.Id, character.Name, character.Level, character.Faction, character.Race, character.Class, character.Guild) { }
}
