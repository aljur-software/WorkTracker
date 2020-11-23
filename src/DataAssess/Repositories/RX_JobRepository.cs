using Domain.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class RX_JobRepository: BaseRepository<Guid, RX_Job, RX_JobRepository>, IRX_JobRepository
    {
        public RX_JobRepository(RXContext context) : base(context)
        { }

        public async Task<IEnumerable<RX_Job>> GetAllJobsWithRoomTypeAsync()
        {
            var result = await Query.Include(t => t.Rx_RoomType).ToListAsync();
            return result;
        }

        IRX_JobRepository IBaseRepository<Guid, RX_Job, IRX_JobRepository>.NoTrack()
        {
            return base.NoTrack();
        }

        IRX_JobRepository IBaseRepository<Guid, RX_Job, IRX_JobRepository>.Reset()
        {
            return base.Reset();
        }
    }
}
