using Microsoft.AspNetCore.Mvc;

namespace Shoplog.Api.Controllers;

[ApiController]
[Route("/")]
public sealed class HomeController : ControllerBase
{
  [HttpGet]
  public IActionResult Get() => Ok("Shoplog API");
}
