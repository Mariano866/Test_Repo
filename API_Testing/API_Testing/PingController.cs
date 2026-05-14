using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Testing;
[ApiController]
[Route("api/[controller]")]
public class PingController : ControllerBase
{   
   [HttpGet("ping")]
   public IActionResult Ping()
   {
    return Ok("pong");
   }
    
}
