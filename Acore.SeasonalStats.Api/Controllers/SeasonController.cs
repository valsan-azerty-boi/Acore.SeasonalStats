using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Acore.SeasonalStats.Api.Controllers
{
    [ApiController]
    [Route("api/season")]
    public class SeasonController : Controller
    {
        [HttpGet]
        [ProducesResponseType(typeof(IActionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get()
        {
            return Ok(new { Name = "world - season 1 - the world test season" });
        }
    }
}
