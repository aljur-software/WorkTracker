using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Abstractions.Repositories;
using Core.Abstractions.Services;
using Domain.ViewModels;

namespace Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<IEnumerable<StatusByRoomTypeViewModel>> GetStatusesByRoomType()
        {
            var jobs = await _jobRepository.GetAllJobsWithRoomTypeAsync();

            return jobs.GroupBy(_ => new { _.Status, _.Rx_RoomType.Name })
                .Select(_ => new StatusByRoomTypeViewModel { Status = _.Key.Status, RoomType = _.Key.Name, Count = _.Count() });
        }
    }

}
