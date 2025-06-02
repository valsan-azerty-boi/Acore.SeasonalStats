using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Acore.SeasonalStats.Application.Commands;

public class UpsertCharacterCommandHandler : IRequestHandler<UpsertCharacterCommand, CharacterViewModel>
{
    public UpsertCharacterCommandHandler()
    {
        //_characterRepository = characterRepository;
    }

    public async Task<CharacterViewModel> Handle(UpsertCharacterCommand command, CancellationToken cancellationToken)
    {
        //bool alreadyExist = _characterRepository.AlreadyExists(command.CharacterId, command.ServerId);
        //if (alreadyExist)
        //    update;
        //else
        //    create;
        //var character = new Domain.Character(Id: command.CharacterId, Name: command.CharacterName);

        //var createdCharacter = await _characterRepository.CreateAsync(character);

        //return new CharacterViewModel(createdCharacter);

        return await Task.FromResult(new CharacterViewModel(command.CharacterId, command.CharacterName, command.CharacterLevel, command.CharacterFaction, command.CharacterRace, command.CharacterClass, command.CharacterGuild, new WorldViewModel(command.ServerId, "Server test")));
    }
}
