using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Acore.SeasonalStats.Application.Commands;

public class UpsertSeasonCommandHandler : IRequestHandler<UpsertSeasonCommand, SeasonViewModel>
{
    public UpsertSeasonCommandHandler()
    {
        //_seasonRepository = seasonRepository;
    }

    public async Task<SeasonViewModel> Handle(UpsertSeasonCommand command, CancellationToken cancellationToken)
    {
        //bool alreadyExist = _seasonRepository.AlreadyExists(command.SeasonId);
        //if (alreadyExist)
        //    update;
        //else
        //    create;
        //var season = new Domain.Season(Id: command.SeasonId, Name: command.SeasonName);

        //var createdSeason = await _seasonRepository.CreateAsync(season);

        //return new SeasonViewModel(createdSeason);

        return await Task.FromResult(new SeasonViewModel(command.SeasonId, command.SeasonName, new WorldViewModel(command.ServerId, "Server test")));
    }
}
