using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private readonly IMapper _mapper;

        public JobService(IRX_JobRepository jobRepository, IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public async Task<GetAllRXJobsQueryResult> GetAllRXJobsQueryHandler()
        {
            IEnumerable<JobVM> jobsVmList = new List<JobVM>();

            var jobs =  await _jobRepository.Reset().ToListAsync();

            if (jobs.Any())
            {
                jobsVmList = _mapper.Map<IEnumerable<JobVM>>(jobs);
            }
            return new GetAllRXJobsQueryResult()
            {
                Payload = jobsVmList
            };
        }
    }
}
