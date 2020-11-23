using Domain.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DataModelConfigurations
{
    public class Rx_RoomTypeConfiguration
    {
        public static void RoomTypeConfiguration(EntityTypeBuilder<RX_RoomType> builder)
        {
            builder.ToTable("RX_RoomType").HasKey(j => j.Id);
            builder.Property(j => j.Name).IsRequired().HasMaxLength(28);
            builder.Property(j => j.Description).HasMaxLength(255);
        }
    }
}
