using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Acore.SeasonalStats.Application.Commands;

public class UpsertStatisticCommandHandler : IRequestHandler<UpsertStatisticCommand, StatisticViewModel>
{
    public UpsertStatisticCommandHandler()
    {
        //_statisticRepository = statisticRepository;
    }

    public async Task<StatisticViewModel> Handle(UpsertStatisticCommand command, CancellationToken cancellationToken)
    {
        //bool alreadyExist = _statisticRepository.AlreadyExists(command.To-Do);
        //if (alreadyExist)
        //    update;
        //else
        //    create;
        //var statistic = new Domain.Statistic(CharacterId: command.To-Do);

        //var createdStatistic = await _statisticRepository.CreateAsync(statistic);

        //return new StatisticViewModel(createdStatistic);

        return await Task.FromResult(
            new StatisticViewModel(
                command.Content, command.Weight, 
                new CategoryViewModel(command.CategoryId, "Categ test"),
                new SimpleCharacterViewModel(command.CharacterId, "Char test", 80, "Alliance", "Human", "Warlock", "Peons"),
                new SimpleSeasonViewModel(command.SeasonId, "Season test"),
                new WorldViewModel(command.ServerId, "Server test")
                ));
    }
}
