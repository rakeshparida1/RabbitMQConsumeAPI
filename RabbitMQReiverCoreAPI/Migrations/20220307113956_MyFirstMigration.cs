using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RabbitMQReiverCoreAPI.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ABC Pharma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicine_Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Brand = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Quantiy = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    expiryDate = table.Column<DateTime>(type: "date", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABC Pharma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "newtable",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    phone = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    company = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    address = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    postalZip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Location = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Gender = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblEmployeeManager",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manager_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEmployeeManager", x => x.EmpId);
                });

            migrationBuilder.CreateIndex(
                name: "<Name of Missing Index, sysname,>",
                table: "newtable",
                column: "postalZip");

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20210923-072501",
                table: "newtable",
                columns: new[] { "name", "phone", "company", "address" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ABC Pharma");

            migrationBuilder.DropTable(
                name: "newtable");

            migrationBuilder.DropTable(
                name: "tbl_Employees");

            migrationBuilder.DropTable(
                name: "TblEmployeeManager");
        }
    }
}
