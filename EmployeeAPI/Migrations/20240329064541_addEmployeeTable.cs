using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAPI.Migrations
{
    public partial class addEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BasicSalary = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeCode);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeCode", "BasicSalary", "DateOfBirth", "Department", "Designation", "EmployeeName", "Gender" },
                values: new object[] { 1, 50000.0, new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Software Engineer", "John Doe", true });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeCode", "BasicSalary", "DateOfBirth", "Department", "Designation", "EmployeeName", "Gender" },
                values: new object[] { 2, 60000.0, new DateTime(1985, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "HR Manager", "Jane Smith", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
