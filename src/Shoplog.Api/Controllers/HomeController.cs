using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Shoplog.Api.Controllers;

[ApiController]
[Route("/")]
public sealed class HomeController : ControllerBase
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation("Home controller called");
        return Ok("Shoplog API");
    }
}
