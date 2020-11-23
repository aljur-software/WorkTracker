using Domain.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Abstractions.Repositories
{
    public interface IJobRepository: IBaseRepository<Guid, Job, IJobRepository>
    {
        Task<IEnumerable<Job>> GetAllJobsWithRoomTypeAsync();
    }
}
