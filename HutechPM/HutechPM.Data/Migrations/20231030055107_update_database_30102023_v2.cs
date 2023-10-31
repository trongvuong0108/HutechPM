using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HutechNote.Data.Migrations
{
    public partial class update_database_30102023_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "ProjectAttachment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "ProjectAttachment");
        }
    }
}
