using Microsoft.EntityFrameworkCore.Migrations;

namespace DataSide.Migrations
{
    public partial class lal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "school",
                table: "people",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "school",
                table: "people");
        }
    }
}
