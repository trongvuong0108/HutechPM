using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HutechNote.Data.Migrations
{
    public partial class update_Db_23102023_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDetail_Project_projectId",
                table: "ProjectDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDetail_User_userId",
                table: "ProjectDetail");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "ProjectDetail",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "projectId",
                table: "ProjectDetail",
                newName: "project_id");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectDetail_userId",
                table: "ProjectDetail",
                newName: "IX_ProjectDetail_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectDetail_projectId",
                table: "ProjectDetail",
                newName: "IX_ProjectDetail_project_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectDetail_Project_project_id",
                table: "ProjectDetail",
                column: "project_id",
                principalTable: "Project",
                principalColumn: "project_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectDetail_User_user_id",
                table: "ProjectDetail",
                column: "user_id",
                principalTable: "User",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDetail_Project_project_id",
                table: "ProjectDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDetail_User_user_id",
                table: "ProjectDetail");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "ProjectDetail",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "project_id",
                table: "ProjectDetail",
                newName: "projectId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectDetail_user_id",
                table: "ProjectDetail",
                newName: "IX_ProjectDetail_userId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectDetail_project_id",
                table: "ProjectDetail",
                newName: "IX_ProjectDetail_projectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectDetail_Project_projectId",
                table: "ProjectDetail",
                column: "projectId",
                principalTable: "Project",
                principalColumn: "project_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectDetail_User_userId",
                table: "ProjectDetail",
                column: "userId",
                principalTable: "User",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
