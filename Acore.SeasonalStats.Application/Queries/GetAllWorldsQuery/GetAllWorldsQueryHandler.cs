using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public class GetAllWorldsQueryHandler : IRequestHandler<GetAllWorldsQuery, IEnumerable<WorldViewModel>>
{
    public GetAllWorldsQueryHandler()
    {
        //_worldRepository = worldRepository;
    }

    public async Task<IEnumerable<WorldViewModel>> Handle(GetAllWorldsQuery request, CancellationToken cancellationToken)
    {
        //var worlds = await _worldRepository.GetAllWorlds(cancellationToken);
        //return worlds.Select(
        //    categ => new WorldViewModel(1, "test"));

        return await Task.FromResult(new List<WorldViewModel>
        {
            new(1, "Acore PvE test realm"),
            new(2, "Acore PvP test realm")
        });
    }
}
