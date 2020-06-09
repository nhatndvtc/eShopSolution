using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(k => k.Id);
            builder.Property(v => v.Price).IsRequired(true);
            builder.Property(v => v.Stock).IsRequired(true).HasDefaultValue(0);
            builder.Property(v => v.ViewCount).IsRequired(true).HasDefaultValue(0);
            builder.Property(v => v.OrginalPrice).IsRequired(true);
        }
    }
}
