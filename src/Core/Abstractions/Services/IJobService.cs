using Domain.Queries;
using System.Threading.Tasks;

namespace Core.Abstractions.Services
{
    public interface IJobService
    {
        Task<GetProgressByRoomTypesQueryResult> GetAllRXJobsQueryHandler();
    }
}
