using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(k => new { k.CategoryId, k.ProductId });

            builder.ToTable("ProductInCategory");

            builder.HasOne(p => p.Product).WithMany(pc => pc.ProductInCategory).HasForeignKey(pc => pc.ProductId);
            builder.HasOne(p => p.Category).WithMany(pc => pc.ProductInCategory).HasForeignKey(pc => pc.CategoryId);
        }
    }
}
