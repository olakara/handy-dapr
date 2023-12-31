using Microsoft.AspNetCore.Mvc;

namespace PersonApp.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    
    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet("/")]
    public IActionResult Get()
    {
        _logger.LogInformation("PersonController / GET");
        return Ok("Ok!");
    }

    [HttpPost("/")]
    public IActionResult Post()
    {
        _logger.LogInformation("PersonController / POST");
        return Ok("Ok!");
    }
}
