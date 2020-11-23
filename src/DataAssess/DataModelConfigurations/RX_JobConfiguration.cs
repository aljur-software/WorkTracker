using Domain.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DataModelConfigurations
{
    public class RX_JobConfiguration
    {
        public static void JobConfiguration(EntityTypeBuilder<RX_Job> builder)
        {
            builder.ToTable("RX_Job").HasKey(j => j.Id);
            builder.Property(j => j.Name).HasMaxLength(50);
            builder.Property(j => j.Status).HasMaxLength(50);
            builder.Property(j => j.DelayReason).HasMaxLength(50);
            builder.HasOne(j => j.Rx_RoomType).WithMany();
        }
    }
}
