using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.ViewModels;

namespace Core.Abstractions.Services
{
    public interface IJobService
    {
        Task<IEnumerable<StatusByRoomTypeViewModel>> GetStatusesByRoomType();
    }
}
