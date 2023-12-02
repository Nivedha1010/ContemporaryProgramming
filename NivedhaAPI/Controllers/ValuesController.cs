using Microsoft.AspNetCore.Mvc;

namespace NivedhaAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet()]
    public IActionResult Get()
    {
        return Ok(new { Name = "Nivedha Balasubramanian" });
    }
}
