using MediatR;

namespace Acore.SeasonalStats.Application.Queries;

public class GetWorldQueryHandler : IRequestHandler<GetWorldQuery, WorldViewModel>
{
    public GetWorldQueryHandler()
    {
        //_worldRepository = worldRepository;
    }

    public async Task<WorldViewModel> Handle(GetWorldQuery request, CancellationToken cancellationToken)
    {
        //var world = await _worldRepository.GetWorld(cancellationToken);
        //return new WorldViewModel(world));

        return await Task.FromResult(new WorldViewModel(request.WorldId, "Test realm"));
    }
}
