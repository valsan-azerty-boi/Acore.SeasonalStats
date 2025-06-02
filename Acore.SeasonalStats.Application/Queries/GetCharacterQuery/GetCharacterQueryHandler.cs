using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public class GetCharacterQueryHandler : IRequestHandler<GetCharacterQuery, CharacterViewModel>
{
    public GetCharacterQueryHandler()
    {
        //_characterRepository = characterRepository;
    }

    public async Task<CharacterViewModel> Handle(GetCharacterQuery request, CancellationToken cancellationToken)
    {
        //var character = await _characterRepository.GetCharacter(cancellationToken);
        //return new CharacterViewModel(character));

        return await Task.FromResult(
            new CharacterViewModel(
                request.CharacterId, "Testitatotu", 80, "Horde", "Orc", "Warrior", "Peons", 
                new WorldViewModel(request.ServerId, "Acore Test PvP server")
                )
            );
    }
}
