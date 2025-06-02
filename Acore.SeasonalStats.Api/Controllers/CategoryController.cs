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
[Route("api/category")]
public class CategoryController(IMediator mediator) : Controller
{
    private readonly IMediator _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

    [HttpGet]
    [Produces(typeof(IEnumerable<CategoryViewModel>))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(new GetAllCategoriesQuery(), cancellationToken));
    }

    [HttpGet]
    [Route("{categoryId:int}")]
    [Produces(typeof(CategoryViewModel))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(int categoryId, CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(new GetCategoryQuery(categoryId), cancellationToken));
    }
}
