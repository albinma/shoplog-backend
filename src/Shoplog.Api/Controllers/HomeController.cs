using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Shoplog.Api.Controllers;

[ApiController]
[Route("/")]
public sealed class HomeController : ControllerBase
{
    private readonly VpicDbContext _vpicDbContext;
    private readonly ILogger<HomeController> _logger;

    public HomeController(VpicDbContext vpicDbContext, ILogger<HomeController> logger)
    {
        _vpicDbContext = vpicDbContext ?? throw new ArgumentNullException(nameof(vpicDbContext));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        _logger.LogInformation("Home controller called");
        var makes = await _vpicDbContext.Makes.ToListAsync();
        return Ok(makes);
    }
}
