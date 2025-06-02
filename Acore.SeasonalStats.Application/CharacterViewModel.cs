using Acore.SeasonalStats.Domain;

namespace Acore.SeasonalStats.Application;

public record CharacterViewModel(int CharacterId, string? CharacterName, int? Level, string? Faction, string? Race, string? Class, string? Guild, WorldViewModel World)
{
    public CharacterViewModel(Character character) : this(character.Id, character.Name, character.Level, character.Faction, character.Race, character.Class, character.Guild, new WorldViewModel(character.WorldId, character.World.Name)) { }
}
