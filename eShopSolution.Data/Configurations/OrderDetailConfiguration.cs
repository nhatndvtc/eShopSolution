using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(k => new { k.OrderId, k.ProductId });
            builder.HasOne(o => o.Order).WithMany(od => od.OrderDetails).HasForeignKey(o => o.OrderId);
            builder.HasOne(o => o.Product).WithMany(po => po.OrderDetails).HasForeignKey(o => o.ProductId);

        }
    }
}