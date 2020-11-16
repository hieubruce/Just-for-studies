﻿using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(t => new { t.CategoryId, t.ProductId });

            builder.ToTable("ProductInCategories");
            builder.HasOne(x => x.Product).WithMany(x => x.ProductInCategories)
                .HasForeignKey(x => x.ProductId);
            builder.HasOne(t => t.Category).WithMany(pc => pc.ProductInCategories)
              .HasForeignKey(pc => pc.CategoryId);
        }
    }
}
