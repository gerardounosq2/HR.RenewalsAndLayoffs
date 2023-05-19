using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.RenewalsAndLayoffs.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: true),
                    Category = table.Column<int>(type: "INTEGER", nullable: false),
                    JobPosition = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    HiringType = table.Column<int>(type: "INTEGER", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    FingerPrint = table.Column<bool>(type: "INTEGER", nullable: false),
                    ProofOfTaxSituation = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
