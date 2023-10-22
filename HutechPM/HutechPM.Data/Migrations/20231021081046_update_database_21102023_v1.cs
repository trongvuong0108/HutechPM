using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HutechNote.Data.Migrations
{
    public partial class update_database_21102023_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDetail_Project_projectId",
                table: "ProjectDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDetail_User_userId",
                table: "ProjectDetail");

            migrationBuilder.DropColumn(
                name: "project",
                table: "ProjectDetail");

            migrationBuilder.DropColumn(
                name: "user",
                table: "ProjectDetail");

            migrationBuilder.AlterColumn<Guid>(
                name: "userId",
                table: "ProjectDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "projectId",
                table: "ProjectDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDetail_Project_projectId",
                table: "ProjectDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDetail_User_userId",
                table: "ProjectDetail");

            migrationBuilder.AlterColumn<Guid>(
                name: "userId",
                table: "ProjectDetail",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "projectId",
                table: "ProjectDetail",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "project",
                table: "ProjectDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "user",
                table: "ProjectDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
        }
    }
}
