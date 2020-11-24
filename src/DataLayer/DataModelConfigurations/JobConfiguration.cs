namespace DataLayer.DataModelConfigurations
{
    public class JobConfiguration
    {
        public static void Configuration(EntityTypeBuilder<Job> builder)
        {
            builder.ToTable("RX_Job").HasKey(j => j.Id);
            builder.Property(j => j.Name).HasMaxLength(50);
            builder.Property(j => j.Status).HasMaxLength(50);
            builder.Property(j => j.DelayReason).HasMaxLength(50);
            builder.HasOne(j => j.Rx_RoomType).WithMany();
        }
    }
}
