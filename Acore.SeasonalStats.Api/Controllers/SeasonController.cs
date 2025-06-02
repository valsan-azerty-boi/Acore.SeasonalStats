using Acore.SeasonalStats.Application;
using Acore.SeasonalStats.Application.Commands;
using Acore.SeasonalStats.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Acore.SeasonalStats.Api.Controllers;

[ApiController]
[Route("api/season")]
public class SeasonController(IMediator mediator) : Controller
{
    private readonly IMediator _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

    [HttpGet]
    [Produces(typeof(IEnumerable<SeasonViewModel>))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(new GetAllSeasonsQuery(), cancellationToken));
    }

    [HttpGet]
    [Route("{seasonId:int}")]
    [Produces(typeof(SeasonViewModel))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(int seasonId, CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(new GetSeasonQuery(seasonId), cancellationToken));
    }

    [HttpPost]
    [Produces(typeof(SeasonViewModel))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Upsert(UpsertSeasonCommand command, CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(command, cancellationToken));
    }
}
