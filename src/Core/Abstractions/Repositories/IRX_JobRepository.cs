using Domain.DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Abstractions.Repositories
{
    public interface IRX_JobRepository: IBaseRepository<Guid, RX_Job, IRX_JobRepository>
    {
    }
}
