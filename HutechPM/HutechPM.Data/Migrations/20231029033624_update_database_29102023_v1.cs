using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HutechNote.Data.Migrations
{
    public partial class update_database_29102023_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDetail_Project_project_id",
                table: "ProjectDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDetail_User_user_id",
                table: "ProjectDetail");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "ProjectTask",
                newName: "taskName");

            migrationBuilder.AlterColumn<Guid>(
                name: "user_id",
                table: "ProjectDetail",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "project_id",
                table: "ProjectDetail",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<DateTime>(
                name: "date_end",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectDetail_Project_project_id",
                table: "ProjectDetail",
                column: "project_id",
                principalTable: "Project",
                principalColumn: "project_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectDetail_User_user_id",
                table: "ProjectDetail",
                column: "user_id",
                principalTable: "User",
                principalColumn: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDetail_Project_project_id",
                table: "ProjectDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDetail_User_user_id",
                table: "ProjectDetail");

            migrationBuilder.DropColumn(
                name: "date_end",
                table: "Project");

            migrationBuilder.RenameColumn(
                name: "taskName",
                table: "ProjectTask",
                newName: "name");

            migrationBuilder.AlterColumn<Guid>(
                name: "user_id",
                table: "ProjectDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "project_id",
                table: "ProjectDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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
    }
}
