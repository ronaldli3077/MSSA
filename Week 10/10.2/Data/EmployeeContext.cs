using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Mod7CodeFirstdemo.Models;

namespace Mod7CodeFirstdemo.Data
{
    public class EmployeeContext:DbContext // database

    {
        public DbSet<Department> Departments { get; set; } // this is table 
        public DbSet<Employee> Employees { get; set; } // this is table 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-509CHPE;initial catalog=PCAD16Employees;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
            //要在这里create PCAD16Employees数据库

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //dummy records 虚拟记录
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "HR" },
                new Department { DepartmentId = 2, DepartmentName = "Marketing" },
                new Department { DepartmentId = 3, DepartmentName = "Finance" });


            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmpId = 1, Name = "John", Salary = 60000, DepartmentID = 1 },
                new Employee { EmpId = 2, Name = "Smith", Salary = 70000, DepartmentID = 2 },
                new Employee { EmpId = 3, Name = "Peter", Salary = 80000, DepartmentID = 3 });


        }


    }
}
