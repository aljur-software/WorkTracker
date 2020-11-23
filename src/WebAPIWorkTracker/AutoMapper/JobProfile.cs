using AutoMapper;
using Domain.DataModels;
using Domain.ViewModels;

namespace WebAPIWorkTracker.AutoMapper
{
    public class JobProfile: Profile
    {
        public JobProfile()
        {
            CreateMap<RX_Job, JobVM>().ForMember(
                destination => destination.RoomType,
                options => options.MapFrom(src => src.Rx_RoomType)
            );
        }
    }
}
