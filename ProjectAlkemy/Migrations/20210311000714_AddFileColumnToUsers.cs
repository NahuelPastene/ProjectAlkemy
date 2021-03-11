using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAlkemy.Migrations
{
    public partial class AddFileColumnToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "File",
                table: "Users");
        }
    }
}
