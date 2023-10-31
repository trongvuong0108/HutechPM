using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HutechNote.Data.Migrations
{
    public partial class update_database_30102023_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "ProjectAttachment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "ProjectAttachment");
        }
    }
}
