using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public class GetAllCharactersQueryHandler : IRequestHandler<GetAllCharactersQuery, IEnumerable<SimpleCharacterViewModel>>
{
    public GetAllCharactersQueryHandler()
    {
        //_characterRepository = characterRepository;
    }

    public async Task<IEnumerable<SimpleCharacterViewModel>> Handle(GetAllCharactersQuery request, CancellationToken cancellationToken)
    {
        //var characters = await _characterRepository.GetAllCharacters(cancellationToken);
        //return characters.Select(
        //    char => new CharacterViewModel(1, "Season test"));

        return await Task.FromResult(new List<SimpleCharacterViewModel>
        {
            new(1, "Jack", 77, "Horde", "Blood Elf", "Warrior", "Peons"),
            new(2, "Daxter", 78, "Horde", "Blood Elf", "Rogue", "Peons")
        });
    }
}
