using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CostosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace CostosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
