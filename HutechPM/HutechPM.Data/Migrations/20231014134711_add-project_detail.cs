using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HutechNote.Data.Migrations
{
    public partial class addproject_detail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "project_detail",
                columns: table => new
                {
                    project_detail_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    user_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    time_join = table.Column<DateTime>(type: "datetime2", nullable: false),
                    time_left = table.Column<DateTime>(type: "datetime2", nullable: false),
                    project_role = table.Column<int>(type: "int", nullable: false),
                    ApplicationProjectprojectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApplicationUseruserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project_detail", x => x.project_detail_id);
                    table.ForeignKey(
                        name: "FK_project_detail_Project_ApplicationProjectprojectId",
                        column: x => x.ApplicationProjectprojectId,
                        principalTable: "Project",
                        principalColumn: "project_id");
                    table.ForeignKey(
                        name: "FK_project_detail_User_ApplicationUseruserId",
                        column: x => x.ApplicationUseruserId,
                        principalTable: "User",
                        principalColumn: "use_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_project_detail_ApplicationProjectprojectId",
                table: "project_detail",
                column: "ApplicationProjectprojectId");

            migrationBuilder.CreateIndex(
                name: "IX_project_detail_ApplicationUseruserId",
                table: "project_detail",
                column: "ApplicationUseruserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "project_detail");
        }
    }
}
