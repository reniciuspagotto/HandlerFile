using Microsoft.AspNetCore.Mvc;

namespace HandlerFile.Controllers
{
    [Route("api/status")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        public IActionResult IsOnline()
        {
            return Ok(true);
        }
    }
}
