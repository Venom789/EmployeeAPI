using EmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Database
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed initial data
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeCode = 1,
                    EmployeeName = "John Doe",
                    DateOfBirth = new DateTime(1990, 5, 15),
                    Gender = true,
                    Department = "IT",
                    Designation = "Software Engineer",
                    BasicSalary = 50000
                },
                new Employee
                {
                    EmployeeCode = 2,
                    EmployeeName = "Jane Smith",
                    DateOfBirth = new DateTime(1985, 8, 22),
                    Gender = false,
                    Department = "HR",
                    Designation = "HR Manager",
                    BasicSalary = 60000
                }
               
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
