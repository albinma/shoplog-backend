using System.Data;
using Microsoft.AspNetCore.Mvc;

namespace Shoplog.Api.Controllers;

[ApiController]
[Route("/")]
public sealed class HomeController(ILogger<HomeController> logger) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        logger.LogInformation("Home controller called");
        return Ok("Shoplog API");
    }
}
