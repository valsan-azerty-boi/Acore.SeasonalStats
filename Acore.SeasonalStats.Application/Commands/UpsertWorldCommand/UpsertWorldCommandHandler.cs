using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Acore.SeasonalStats.Application.Commands;

public class UpsertWorldCommandHandler : IRequestHandler<UpsertWorldCommand, WorldViewModel>
{
    public UpsertWorldCommandHandler()
    {
        //_worldRepository = worldRepository;
    }

    public async Task<WorldViewModel> Handle(UpsertWorldCommand command, CancellationToken cancellationToken)
    {
        //bool alreadyExist = _worldRepository.AlreadyExists(command.ServerId);
        //if (alreadyExist)
        //    update;
        //else
        //    create;
        //var world = new Domain.World(Id: command.WorldId, Name: command.WorldName);

        //var createdWorld = await _worldRepository.CreateAsync(world);

        //return new WorldViewModel(createdWorld);

        return await Task.FromResult(new WorldViewModel(command.ServerId, command.ServerName));
    }
}
