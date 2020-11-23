using Domain.DataModels;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Queries
{
    public class GetAllRXJobsQueryResult
    {
        public IEnumerable<JobVM> Payload { get; set;}
    }
}
