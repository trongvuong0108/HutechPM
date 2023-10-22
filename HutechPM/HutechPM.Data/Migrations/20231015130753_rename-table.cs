using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HutechNote.Data.Migrations
{
    public partial class renametable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_acttachments_projectTasks_taskuserId",
                table: "acttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_project_detail_Project_projectId",
                table: "project_detail");

            migrationBuilder.DropForeignKey(
                name: "FK_project_detail_User_userId",
                table: "project_detail");

            migrationBuilder.DropForeignKey(
                name: "FK_projectTasks_Project_projectId",
                table: "projectTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userRoles",
                table: "userRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_projectTasks",
                table: "projectTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_project_detail",
                table: "project_detail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_acttachments",
                table: "acttachments");

            migrationBuilder.RenameTable(
                name: "userRoles",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "projectTasks",
                newName: "ProjectTask");

            migrationBuilder.RenameTable(
                name: "project_detail",
                newName: "ProjectDetail");

            migrationBuilder.RenameTable(
                name: "acttachments",
                newName: "ProjectAttachment");

            migrationBuilder.RenameIndex(
                name: "IX_projectTasks_projectId",
                table: "ProjectTask",
                newName: "IX_ProjectTask_projectId");

            migrationBuilder.RenameIndex(
                name: "IX_project_detail_userId",
                table: "ProjectDetail",
                newName: "IX_ProjectDetail_userId");

            migrationBuilder.RenameIndex(
                name: "IX_project_detail_projectId",
                table: "ProjectDetail",
                newName: "IX_ProjectDetail_projectId");

            migrationBuilder.RenameIndex(
                name: "IX_acttachments_taskuserId",
                table: "ProjectAttachment",
                newName: "IX_ProjectAttachment_taskuserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                column: "user_role_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectTask",
                table: "ProjectTask",
                column: "project_task_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectDetail",
                table: "ProjectDetail",
                column: "project_detail_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectAttachment",
                table: "ProjectAttachment",
                column: "acttachment_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAttachment_ProjectTask_taskuserId",
                table: "ProjectAttachment",
                column: "taskuserId",
                principalTable: "ProjectTask",
                principalColumn: "project_task_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectDetail_Project_projectId",
                table: "ProjectDetail",
                column: "projectId",
                principalTable: "Project",
                principalColumn: "project_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectDetail_User_userId",
                table: "ProjectDetail",
                column: "userId",
                principalTable: "User",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTask_Project_projectId",
                table: "ProjectTask",
                column: "projectId",
                principalTable: "Project",
                principalColumn: "project_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAttachment_ProjectTask_taskuserId",
                table: "ProjectAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDetail_Project_projectId",
                table: "ProjectDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDetail_User_userId",
                table: "ProjectDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTask_Project_projectId",
                table: "ProjectTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectTask",
                table: "ProjectTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectDetail",
                table: "ProjectDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectAttachment",
                table: "ProjectAttachment");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "userRoles");

            migrationBuilder.RenameTable(
                name: "ProjectTask",
                newName: "projectTasks");

            migrationBuilder.RenameTable(
                name: "ProjectDetail",
                newName: "project_detail");

            migrationBuilder.RenameTable(
                name: "ProjectAttachment",
                newName: "acttachments");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTask_projectId",
                table: "projectTasks",
                newName: "IX_projectTasks_projectId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectDetail_userId",
                table: "project_detail",
                newName: "IX_project_detail_userId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectDetail_projectId",
                table: "project_detail",
                newName: "IX_project_detail_projectId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectAttachment_taskuserId",
                table: "acttachments",
                newName: "IX_acttachments_taskuserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userRoles",
                table: "userRoles",
                column: "user_role_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_projectTasks",
                table: "projectTasks",
                column: "project_task_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_project_detail",
                table: "project_detail",
                column: "project_detail_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_acttachments",
                table: "acttachments",
                column: "acttachment_id");

            migrationBuilder.AddForeignKey(
                name: "FK_acttachments_projectTasks_taskuserId",
                table: "acttachments",
                column: "taskuserId",
                principalTable: "projectTasks",
                principalColumn: "project_task_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_project_detail_Project_projectId",
                table: "project_detail",
                column: "projectId",
                principalTable: "Project",
                principalColumn: "project_id");

            migrationBuilder.AddForeignKey(
                name: "FK_project_detail_User_userId",
                table: "project_detail",
                column: "userId",
                principalTable: "User",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_projectTasks_Project_projectId",
                table: "projectTasks",
                column: "projectId",
                principalTable: "Project",
                principalColumn: "project_id");
        }
    }
}
