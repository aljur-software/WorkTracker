using Domain.DataModelConfigurations;
using Domain.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Infrastructure;
using DataLayer.Scripts;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DataLayer
{
    public class RXContext : DbContext
    {
        public RXContext(DbContextOptions<RXContext> options) : base(options)
        {
            if (!(this.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
            {
                Database.EnsureCreated();
                Database.ExecuteSqlRaw(InitialScript.CreateRX_JobInitScript());
                Database.ExecuteSqlRaw(InitialScript.CreateRX_RoomTypeInitScript());                
                Database.ExecuteSqlRaw(InitialScript.InsertRoomTypeInitScript());
                Database.ExecuteSqlRaw(InitialScript.InsertJobInitScript());
            }
        }

        public DbSet<RX_Job> RXJobs;
        public DbSet<RX_RoomType> RXRoomTypes;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RX_RoomType>(Rx_RoomTypeConfiguration.RoomTypeConfiguration);
            modelBuilder.Entity<RX_Job>(RX_JobConfiguration.JobConfiguration);
        }
    }
}
