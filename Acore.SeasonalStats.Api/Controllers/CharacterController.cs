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
[Route("api/character")]
public class CharacterController(IMediator mediator) : Controller
{
    private readonly IMediator _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

    [HttpGet]
    [Produces(typeof(IEnumerable<CharacterViewModel>))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(new GetAllCharactersQuery(), cancellationToken));
    }

    [HttpGet]
    [Route("server/{serverId:int}")]
    [Produces(typeof(IEnumerable<CharacterViewModel>))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByWorld(int serverId, CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(new GetCharactersByWorldQuery(serverId), cancellationToken));
    }

    [HttpGet]
    [Route("{characterId:int}/server/{serverId:int}")]
    [Produces(typeof(CharacterViewModel))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(int characterId, int serverId, CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(new GetCharacterQuery(characterId, serverId), cancellationToken));
    }

    [HttpPost]
    [Produces(typeof(CharacterViewModel))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Upsert(UpsertCharacterCommand command, CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(command, cancellationToken));
    }
}
