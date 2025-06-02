using Acore.SeasonalStats.Application;
using Acore.SeasonalStats.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Acore.SeasonalStats.Api.Controllers;

[ApiController]
[Route("api/world")]
public class WorldController(IMediator mediator) : Controller
{
    private readonly IMediator _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

    [HttpGet]
    [Produces(typeof(IEnumerable<WorldViewModel>))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(new GetAllWorldsQuery(), cancellationToken));
    }

    [HttpGet]
    [Route("{worldId:int}")]
    [Produces(typeof(WorldViewModel))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(int worldId, CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(new GetWorldQuery(worldId), cancellationToken));
    }
}
