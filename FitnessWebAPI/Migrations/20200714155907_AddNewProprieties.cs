using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessWebAPI.Migrations
{
    public partial class AddNewProprieties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MobilePhone",
                table: "Users",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MobilePhone",
                table: "Users");
        }
    }
}
