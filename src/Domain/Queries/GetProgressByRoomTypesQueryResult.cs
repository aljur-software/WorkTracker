using Domain.ViewModels;
using System.Collections.Generic;

namespace Domain.Queries
{
    public class GetProgressByRoomTypesQueryResult
    {
        public IEnumerable<ProgressByRoomTypeVM> Payload { get; set;}
    }
}
