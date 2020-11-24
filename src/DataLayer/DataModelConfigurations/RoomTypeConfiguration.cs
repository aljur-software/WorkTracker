namespace DataLayer.DataModelConfigurations
{
    public class RoomTypeConfiguration
    {
        public static void Configuration(EntityTypeBuilder<RoomType> builder)
        {
            builder.ToTable("RX_RoomType").HasKey(j => j.Id);
            builder.Property(j => j.Name).IsRequired().HasMaxLength(28);
            builder.Property(j => j.Description).HasMaxLength(255);
        }
    }
}
