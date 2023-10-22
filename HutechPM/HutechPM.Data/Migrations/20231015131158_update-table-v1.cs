using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HutechNote.Data.Migrations
{
    public partial class updatetablev1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTask_ProjectDetail_projectDetailId",
                table: "ProjectTask");

            migrationBuilder.AlterColumn<Guid>(
                name: "projectDetailId",
                table: "ProjectTask",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTask_ProjectDetail_projectDetailId",
                table: "ProjectTask",
                column: "projectDetailId",
                principalTable: "ProjectDetail",
                principalColumn: "project_detail_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTask_ProjectDetail_projectDetailId",
                table: "ProjectTask");

            migrationBuilder.AlterColumn<Guid>(
                name: "projectDetailId",
                table: "ProjectTask",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTask_ProjectDetail_projectDetailId",
                table: "ProjectTask",
                column: "projectDetailId",
                principalTable: "ProjectDetail",
                principalColumn: "project_detail_id");
        }
    }
}
