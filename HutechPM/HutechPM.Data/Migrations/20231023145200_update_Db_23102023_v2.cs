using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HutechNote.Data.Migrations
{
    public partial class update_Db_23102023_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTask_ProjectDetail_projectDetailId",
                table: "ProjectTask");

            migrationBuilder.RenameColumn(
                name: "projectDetailId",
                table: "ProjectTask",
                newName: "project_detail_id");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTask_projectDetailId",
                table: "ProjectTask",
                newName: "IX_ProjectTask_project_detail_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTask_ProjectDetail_project_detail_id",
                table: "ProjectTask",
                column: "project_detail_id",
                principalTable: "ProjectDetail",
                principalColumn: "project_detail_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTask_ProjectDetail_project_detail_id",
                table: "ProjectTask");

            migrationBuilder.RenameColumn(
                name: "project_detail_id",
                table: "ProjectTask",
                newName: "projectDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectTask_project_detail_id",
                table: "ProjectTask",
                newName: "IX_ProjectTask_projectDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTask_ProjectDetail_projectDetailId",
                table: "ProjectTask",
                column: "projectDetailId",
                principalTable: "ProjectDetail",
                principalColumn: "project_detail_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
