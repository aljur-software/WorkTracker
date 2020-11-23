using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Abstractions.Repositories;
using Domain.DataModels;
using Domain.ViewModels;
using FluentAssertions;
using Moq;
using Xunit;

namespace Services.UnitTests
{
    public class JobServiceTests
    {
        [Fact]
        public async Task GetProgressByRoomTypesQueryHandlerShouldBeEquivalentToRightData()
        {
            var mock = new Mock<IJobRepository>();
            mock.Setup(repo => repo.GetAllJobsWithRoomTypeAsync()).Returns(Task.FromResult(GetTestQueryResult()));

            var jobService = new JobService(mock.Object);

            var result = await jobService.GetStatusesByRoomType();
            var model = Assert.IsAssignableFrom<IEnumerable<StatusByRoomTypeViewModel>>(result);
            model.Should().BeEquivalentTo(GetRightData());
        }

        private IEnumerable<Job> GetTestQueryResult()
        {
            var jobs = new List<Job>{
                new Job{ Id= new Guid(), Name="Name1",  Status = "Deleted",
                    Rx_RoomType = new RoomType { Id = new Guid(), Name = "1b"} },
                new Job{ Id= new Guid(), Name="Name2",  Status = "Deleted",
                    Rx_RoomType = new RoomType { Id = new Guid(), Name = "1c"} },
                new Job{ Id= new Guid(), Name="Name3",  Status = "Deleted",
                    Rx_RoomType = new RoomType { Id = new Guid(), Name = "1b"} },
                new Job{ Id= new Guid(), Name="Name1",  Status = "Completed",
                    Rx_RoomType = new RoomType { Id = new Guid(), Name = "1b"} },
                new Job{ Id= new Guid(), Name="Name4",  Status = "Completed",
                    Rx_RoomType = new RoomType { Id = new Guid(), Name = "1b"} },
            };

            return jobs;
        }

        private IEnumerable<StatusByRoomTypeViewModel> GetRightData()
        {
            return new List<StatusByRoomTypeViewModel> {
                new StatusByRoomTypeViewModel{ Status ="Deleted", RoomType="1b",  Count=2},
                new StatusByRoomTypeViewModel{ Status ="Deleted", RoomType="1c",  Count=1},
                new StatusByRoomTypeViewModel{ Status ="Completed", RoomType="1b",  Count=2}
            };
        }
    }
}
