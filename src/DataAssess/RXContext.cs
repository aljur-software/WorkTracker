using Domain.DataModelConfigurations;
using Domain.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class RXContext : DbContext
    {
        public RXContext(DbContextOptions<RXContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
            /*(context.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists()


            if (!await RXContext.RXRoomTypes.AnyAsync<RX_RoomType>())
            {
                await RXContext.RXRoomTypes.ExecuteSqlRawAsync(InitialScript.InsertRoomTypeInitScript());
            }

            if (!await RXContext.RXJobs.AnyAsync<RX_Job>())
            {
                await RXContext.RXJobs.ExecuteSqlRawAsync(InitialScript.InsertJobInitScript());
            }*/

        }

        public DbSet<RX_Job> RXJobs;
        public DbSet<RX_RoomType> RXRoomTypes;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RX_RoomType>(Rx_RoomTypeConfiguration.RoomTypeConfiguration);
            modelBuilder.Entity<RX_Job>(RX_JobConfiguration.JobConfiguration);
        }

        public bool Exists()
        {
            if (!Database.CanConnect())
            {
                
            }
        }
    }
}
