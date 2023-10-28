using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HutechNote.Data.Migrations
{
    public partial class update_Db_23102023_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAttachment_ProjectTask_taskuserId",
                table: "ProjectAttachment");

            migrationBuilder.RenameColumn(
                name: "taskuserId",
                table: "ProjectAttachment",
                newName: "taskprojectTaskid");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectAttachment_taskuserId",
                table: "ProjectAttachment",
                newName: "IX_ProjectAttachment_taskprojectTaskid");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAttachment_ProjectTask_taskprojectTaskid",
                table: "ProjectAttachment",
                column: "taskprojectTaskid",
                principalTable: "ProjectTask",
                principalColumn: "project_task_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAttachment_ProjectTask_taskprojectTaskid",
                table: "ProjectAttachment");

            migrationBuilder.RenameColumn(
                name: "taskprojectTaskid",
                table: "ProjectAttachment",
                newName: "taskuserId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectAttachment_taskprojectTaskid",
                table: "ProjectAttachment",
                newName: "IX_ProjectAttachment_taskuserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAttachment_ProjectTask_taskuserId",
                table: "ProjectAttachment",
                column: "taskuserId",
                principalTable: "ProjectTask",
                principalColumn: "project_task_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
