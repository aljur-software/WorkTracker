using Microsoft.AspNetCore.Mvc;

namespace WebAPIWorkTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiController : ControllerBase
    {
    }
}