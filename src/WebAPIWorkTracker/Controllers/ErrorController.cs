using Microsoft.AspNetCore.Mvc;

namespace WebAPIWorkTracker.Controllers
{
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Error()
        {
            return Problem();
        }
    }
}
