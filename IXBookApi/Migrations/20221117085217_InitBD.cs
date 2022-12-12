using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IXBookApi.Migrations
{
    public partial class InitBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ModelGuid",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModelGuid",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModelGuid",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "ModelGuid",
                table: "Books");
        }
    }
}
