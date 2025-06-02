using Acore.SeasonalStats.Application;
using Acore.SeasonalStats.Application.Commands;
using Acore.SeasonalStats.Application.Queries;
using Acore.SeasonalStats.Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Acore.SeasonalStats.Api.Controllers;

[ApiController]
[Route("api/statistic")]
public class StatisticController(IMediator mediator) : Controller
{
    private readonly IMediator _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

    [HttpGet]
    [Route("server/{serverId:int}")]
    [Produces(typeof(IEnumerable<SimpleStatisticViewModel>))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByWorld(int serverId, CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(new GetStatisticsByWorldQuery(serverId), cancellationToken));
    }

    [HttpGet]
    [Route("character/{characterId:int}/server/{serverId:int}")]
    [Produces(typeof(IEnumerable<SimpleStatisticViewModel>))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByCharacter(int characterId, int serverId, CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(new GetStatisticsByCharacterQuery(characterId, serverId), cancellationToken));
    }

    [HttpGet]
    [Route("character/{characterId:int}/server/{serverId:int}/season/{seasonId:int}/category/{categoryId:int}")]
    [Produces(typeof(StatisticViewModel))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(int characterId, int serverId, int seasonId, int categoryId, CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(new GetStatisticQuery(characterId, serverId, seasonId, categoryId), cancellationToken));
    }

    [HttpPost]
    [Produces(typeof(StatisticViewModel))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Upsert(UpsertStatisticCommand command, CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(command, cancellationToken));
    }
}
