using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEF.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);

            builder
                .Property(o => o.OrderDate)
                .IsRequired();

            builder
                .Property(o => o.OrderCode)
                .IsRequired()
                .HasMaxLength(8);

            builder
                .Property(o => o.ProductCode)
                .IsRequired()
                .HasMaxLength(8);

            builder
                .Property(o => o.Import)
                .IsRequired();

            builder
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId);
        }
    }
}
