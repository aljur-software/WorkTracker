using AutoMapper;
using Domain.DataModels;
using Domain.ViewModels;

namespace WebAPIWorkTracker.AutoMapper
{
    public class RoomTypeProfile : Profile
    {
        public RoomTypeProfile()
        {
            CreateMap<RX_RoomType, RoomTypeVM>();
        }
    }
}
