using Acore.SeasonalStats.Domain;

namespace Acore.SeasonalStats.Application;

public record CharacterViewModel(int CharacterId, string? CharacterName, int? Level, string? Faction, string? Race, string? Class, string? Guild, WorldViewModel Server)
{
    public CharacterViewModel(Character character) : this(character.Id, character.Name, character.Level, character.Faction, character.Race, character.Class, character.Guild, new WorldViewModel(character.World.Id, character.World.Name)) { }
}
