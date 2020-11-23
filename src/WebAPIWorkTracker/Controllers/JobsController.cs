using System.Threading.Tasks;
using Core.Abstractions.Services;
using Domain.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIWorkTracker.Controllers
{
    public class JobsController : ApiController
    {
        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(GetProgressByRoomTypesQueryResult), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProgressByRoomTypes()
        {
            var result = await _jobService.GetAllRXJobsQueryHandler();

            return Ok(result);
        }
    }
}