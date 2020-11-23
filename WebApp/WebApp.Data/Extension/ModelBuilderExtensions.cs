using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Data.Entities;

namespace WebApp.Data.Extension
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
              new AppConfig() { Key = "HomeTitle", Value = "This is home page of WebApp" },
              new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of WebApp" },
              new AppConfig() { Key = "HomeDescription", Value = "This is description of WebApp" }
              );

            modelBuilder.Entity<Customer>().HasData(
                new Customer()
                {
                    Id = 1,
                    FirstName = "Hieu",
                    LastName = "Nguyen",
                    PhoneNumber = "0377170723",
                    Email = "hieu@gmail.com",
                    Address = "Ho Chi Minh",
                    Dob = new DateTime(1998, 9, 4)
                },
                new Customer()
                {
                    Id = 2,
                    FirstName = "Thong",
                    LastName = "Nguyen",
                    PhoneNumber = "0123456789",
                    Email = "Thong@gmail.com",
                    Address = "Ho Chi Minh",
                    Dob = new DateTime(1998, 9, 5)
                });

            var roleId = new Guid("1AA336F3-0F2E-4E3C-8DCB-F54348667785");
            var adminId = new Guid("8A167506-7583-450F-8568-2CE4F02C95AC");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Adminstrator role"
            });

            

            var hasher = new PasswordHasher<AppUser>();

            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "hieubruce123@gmail.com",
                NormalizedEmail = "hieubruce123@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Hello@123"),
                SecurityStamp = string.Empty,
                FirstName = "Admin",
                LastName = "Nguyen",
                Dob = new DateTime(2020, 11, 23)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<CustomerDetail>().HasData(
                new CustomerDetail() { CustomerId = 1, UserId = adminId , BookingDate = new DateTime(2020,11,23)}
                );
        }
    }
}
