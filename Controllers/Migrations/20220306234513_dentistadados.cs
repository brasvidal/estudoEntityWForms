using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controllers.Migrations
{
    public partial class dentistadados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CRO",
                table: "Dentistas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Dentistas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Dentistas",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CRO",
                table: "Dentistas");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Dentistas");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Dentistas");
        }
    }
}
