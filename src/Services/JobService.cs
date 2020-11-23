using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Abstractions.Repositories;
using Core.Abstractions.Services;
using Domain.DataModels;
using Domain.Queries;
using Domain.ViewModels;

namespace Services
{
    public class JobService : IJobService
    {
        private readonly IRX_JobRepository _jobRepository;

        public JobService(IRX_JobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<GetProgressByRoomTypesQueryResult> GetAllRXJobsQueryHandler()
        {
            IEnumerable<ProgressByRoomTypeVM> roomsByStatusAndType = new List<ProgressByRoomTypeVM>();

            var jobs =  await _jobRepository.Reset().GetAllJobsWithRoomTypeAsync();
            

            if (jobs.Any())
            {
                 roomsByStatusAndType = jobs.GroupBy(_ => new { _.Status, _.Rx_RoomType.Name })
                    .Select(_ => new ProgressByRoomTypeVM { Status = _.Key.Status, RoomType = _.Key.Name, Count = _.Count() })
                    .ToList<ProgressByRoomTypeVM>();
            }
            return new GetProgressByRoomTypesQueryResult()
            {
                Payload = roomsByStatusAndType
            };
        }

        
    }

}
