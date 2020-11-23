using Domain.DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Core.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class RX_JobRepository: BaseRepository<Guid, RX_Job, RX_JobRepository>, IRX_JobRepository
    {
        public RX_JobRepository(RXContext context) : base(context)
        { }

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
