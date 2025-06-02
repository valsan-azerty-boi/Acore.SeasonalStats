using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public class GetCharactersByWorldQueryHandler : IRequestHandler<GetCharactersByWorldQuery, IEnumerable<SimpleCharacterViewModel>>
{
    public GetCharactersByWorldQueryHandler()
    {
        //_statisticRepository = statisticRepository;
    }

    public async Task<IEnumerable<SimpleCharacterViewModel>> Handle(GetCharactersByWorldQuery request, CancellationToken cancellationToken)
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
