using HR_manager.Server.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Server.Data
{
    public class DatabaseContext: IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        
        public DbSet<EmployeeData> EmployeeData { get; set; }
        public DbSet<EmployeeTime> EmployeeTime { get; set; }
        public DbSet<EmployeeType> EmployeeType { get; set; }
        public DbSet<LoggedTime> LoggedTime { get; set; }

        public DbSet<LoggedTimeType> LoggedTimeType { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Department>().HasData(
             new Department
             {
                 Id = 1,
                 Name = "IT"

             },
             new Department
             {
                 Id = 2,
                 Name = "Management"

             },
              new Department
              {
                  Id = 3,
                  Name = "Sales"

              }
         );


            builder.Entity<EmployeeType>().HasData(
               new EmployeeType
               {
                   Id = 1,
                   Description = "Contractor"
                   
               },
               new EmployeeType
               {
                   Id = 2,
                   Description = "Permanent"
                   
               }
           );

            builder.Entity<LoggedTimeType>().HasData(
               new LoggedTimeType
               {
                   Id = 1,
                   Description = "Regular"
               },
               new LoggedTimeType
               {
                   Id = 2,
                   Description = "Sick"
                   
               },
                new LoggedTimeType
                {
                    Id = 3,
                    Description = "Vacation"

                }
           );


            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
            );


            
        }


    }
}
