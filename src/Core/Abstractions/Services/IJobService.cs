using Domain.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstractions.Services
{
    public interface IJobService
    {
        Task<GetAllRXJobsQueryResult> GetAllRXJobsQueryHandler();
    }
}
