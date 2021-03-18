using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCContact.Data.Migrations
{
    public partial class smo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Meeting",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Contact");
        }
    }
}
