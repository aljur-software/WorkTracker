using DataLayer.Scripts;
using DataLayer.DataModelConfigurations;

namespace DataLayer
{
    public class RXContext : DbContext
    {
        public RXContext(DbContextOptions<RXContext> options) : base(options)
        {
            if (!((RelationalDatabaseCreator) this.GetService<IDatabaseCreator>()).Exists())
            {
                Database.EnsureCreated();
                Database.ExecuteSqlRaw(InitialScript.CreateRX_JobInitScript());
                Database.ExecuteSqlRaw(InitialScript.CreateRX_RoomTypeInitScript());                
                Database.ExecuteSqlRaw(InitialScript.InsertRoomTypeInitScript());
                Database.ExecuteSqlRaw(InitialScript.InsertJobInitScript());
            }
        }

        public DbSet<Job> RXJobs;
        public DbSet<RoomType> RXRoomTypes;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomType>(RoomTypeConfiguration.Configuration);
            modelBuilder.Entity<Job>(JobConfiguration.Configuration);
        }
    }
}
