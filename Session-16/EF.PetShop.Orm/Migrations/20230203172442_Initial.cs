using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF.Petshop.Orm.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TIN = table.Column<int>(type: "int", maxLength: 9, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 30, nullable: false),
                    EmpType = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    SalaryPerMonth = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 30, nullable: false),
                    Animaltype = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Petstatus = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(5,5)", precision: 5, scale: 5, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(5,5)", precision: 5, scale: 5, nullable: false),
                    Bought = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    TransactionID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PetFood",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 30, nullable: false),
                    Animaltype = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(5,5)", precision: 5, scale: 5, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(5,5)", precision: 5, scale: 5, nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(5,5)", precision: 5, scale: 5, nullable: true),
                    CurrentStock = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetFood", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PetFoodTransaction",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetFoodTransaction", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 30, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", maxLength: 15, nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: true),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: true),
                    PetID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: true),
                    PetPrice = table.Column<decimal>(type: "decimal(5,2)", precision: 5, nullable: true),
                    PetFoodID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: true),
                    PetFoodQty = table.Column<decimal>(type: "decimal(5,2)", precision: 5, nullable: false),
                    PetFoodPrice = table.Column<decimal>(type: "decimal(5,2)", precision: 5, nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(5,2)", precision: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "PetFood");

            migrationBuilder.DropTable(
                name: "PetFoodTransaction");

            migrationBuilder.DropTable(
                name: "Transaction");
        }
    }
}
