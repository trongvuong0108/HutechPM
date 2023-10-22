using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HutechNote.Data.Migrations
{
    public partial class updatetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTask_Project_projectId",
                table: "ProjectTask");

            migrationBuilder.RenameColumn(
                name: "projectId",
                table: "ProjectTask",
                newName: "projectDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTask_projectId",
                table: "ProjectTask",
                newName: "IX_ProjectTask_projectDetailId");

            migrationBuilder.AddColumn<int>(
                name: "UserRoleId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserRoleId",
                table: "User",
                column: "UserRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTask_ProjectDetail_projectDetailId",
                table: "ProjectTask",
                column: "projectDetailId",
                principalTable: "ProjectDetail",
                principalColumn: "project_detail_id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserRole_UserRoleId",
                table: "User",
                column: "UserRoleId",
                principalTable: "UserRole",
                principalColumn: "user_role_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTask_ProjectDetail_projectDetailId",
                table: "ProjectTask");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserRole_UserRoleId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UserRoleId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserRoleId",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "projectDetailId",
                table: "ProjectTask",
                newName: "projectId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTask_projectDetailId",
                table: "ProjectTask",
                newName: "IX_ProjectTask_projectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTask_Project_projectId",
                table: "ProjectTask",
                column: "projectId",
                principalTable: "Project",
                principalColumn: "project_id");
        }
    }
}
