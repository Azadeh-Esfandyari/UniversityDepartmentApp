using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityDepartmentApp.Models;

namespace UniversityDepartmentApp.Data
{
    public class UniContext: DbContext
    {
      public DbSet<University> Universities { get; set; } = null!;
     public DbSet<Department> Departments { get; set; } = null!;

        public UniContext(DbContextOptions options):base(options)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Connection string");
        //}

    }
}
