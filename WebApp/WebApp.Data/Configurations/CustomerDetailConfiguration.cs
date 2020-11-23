using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Data.Entities;

namespace WebApp.Data.Configurations
{
    public class CustomerDetailConfiguration : IEntityTypeConfiguration<CustomerDetail>
    {
        public void Configure(EntityTypeBuilder<CustomerDetail> builder)
        {
            builder.ToTable("CustomerDetails");
            builder.HasKey(x => new { x.CustomerId, x.UserId });
            builder.HasOne(x => x.Customer).WithMany(x => x.CustomerDetails).HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.CustomerDetails).HasForeignKey(x => x.UserId);
        }
    }
}
