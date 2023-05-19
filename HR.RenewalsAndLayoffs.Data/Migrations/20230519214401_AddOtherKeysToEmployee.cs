using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.RenewalsAndLayoffs.Data.Migrations
{
    public partial class AddOtherKeysToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FortiaId",
                table: "Employees",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelNumber",
                table: "Employees",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FortiaId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PersonnelNumber",
                table: "Employees");
        }
    }
}
