using Microsoft.AspNetCore.Mvc;

namespace Greeter.Controllers;

[ApiController]
[Route("[controller]")]
public class GreetController : ControllerBase
{
    private readonly ILogger<GreetController> _logger;

    public GreetController(ILogger<GreetController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Greet")]
    public IActionResult Get()
    {
        _logger.LogInformation("GreetController / GET");
        return Ok("Ok!");
    }
}
