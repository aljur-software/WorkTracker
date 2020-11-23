using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Abstractions.Services;
using Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebAPIWorkTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobsController
    {
        private readonly IJobService _jobService;
        private readonly ILogger<JobsController> _logger;


        public JobsController(IJobService jobService, ILogger<JobsController> logger)
        {
            _jobService = jobService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<StatusByRoomTypeViewModel>> GetProgressByRoomTypes()
        {
            _logger.LogDebug("GetProgressByRoomTypes");

            return await _jobService.GetStatusesByRoomType();
        }
    }
}