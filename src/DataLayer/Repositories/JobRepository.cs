using Domain.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class JobRepository: BaseRepository<Guid, Job, JobRepository>, IJobRepository
    {
        public JobRepository(RXContext context) : base(context)
        { }

        public async Task<IEnumerable<Job>> GetAllJobsWithRoomTypeAsync()
        {
            var result = await Reset().Query.Include(t => t.Rx_RoomType).ToListAsync();
            return result;
        }

        IJobRepository IBaseRepository<Guid, Job, IJobRepository>.Reset()
        {
            return base.Reset();
        }
    }
}
