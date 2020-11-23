using Domain.ViewModels;
using System.Collections.Generic;

namespace Domain.Queries
{
    public class GetAllRXJobsQueryResult
    {
        public IEnumerable<JobVM> Payload { get; set;}
    }
}
