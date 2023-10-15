using Dapr;
using Microsoft.AspNetCore.Mvc;

namespace listener.Controllers;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{
    private readonly ILogger<ValuesController> _logger;

    public ValuesController(ILogger<ValuesController> logger)
    {
        _logger = logger;
    }
    
    [Topic("pubsub", "stars")]
    [HttpPost("/messages")]
    public async Task<ActionResult>  GetMessages([FromBody]Message message)
    {
        
        if (message is not null)
        {
            _logger.LogInformation($"{nameof(Message)} received: " + message);
            Console.WriteLine($"{nameof(Message)} received: " + message);
            return Ok();
        }
        _logger.LogError($"{nameof(Message)} received: NULL");
        return BadRequest();
    }
}