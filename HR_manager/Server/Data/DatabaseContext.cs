using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Server.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 1,
                   Name = "David",
                   MiddleName = "Alejandro",
                   DepartmentId = 1
               },
               new Employee
               {
                   Id = 2,
                   Name = "Peter",
                   MiddleName = "Carlos",
                   DepartmentId = 2,
               },
               new Employee
               {
                   Id = 3,
                   Name = "Julia",
                   MiddleName = "Maria",
                   DepartmentId = 3
               }
           );



            builder.Entity<Department>().HasData(
              new Department
              {
                  Id = 1,
                  Name = "Sales",
              },
              new Department
              {
                  Id = 2,
                  Name = "IT",
              
              },
              new Department
              {
                  Id = 3,
                  Name = "HR",
              }
          );
        }


    }
}
