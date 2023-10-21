using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HutechNote.Data.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_project_detail_Project_ApplicationProjectprojectId",
                table: "project_detail");

            migrationBuilder.DropForeignKey(
                name: "FK_project_detail_User_ApplicationUseruserId",
                table: "project_detail");

            migrationBuilder.DropIndex(
                name: "IX_project_detail_ApplicationProjectprojectId",
                table: "project_detail");

            migrationBuilder.DropColumn(
                name: "ApplicationProjectprojectId",
                table: "project_detail");

            migrationBuilder.RenameColumn(
                name: "use_id",
                table: "User",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "project_detail",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "ApplicationUseruserId",
                table: "project_detail",
                newName: "projectId");

            migrationBuilder.RenameIndex(
                name: "IX_project_detail_ApplicationUseruserId",
                table: "project_detail",
                newName: "IX_project_detail_projectId");

            migrationBuilder.AddColumn<string>(
                name: "avatar",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "userId",
                table: "project_detail",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "project",
                table: "project_detail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "user",
                table: "project_detail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "date_start",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "is_active",
                table: "Project",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "project_name",
                table: "Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "projectTasks",
                columns: table => new
                {
                    project_task_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estimate = table.Column<int>(type: "int", nullable: false),
                    remaining = table.Column<int>(type: "int", nullable: false),
                    projectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectTasks", x => x.project_task_id);
                    table.ForeignKey(
                        name: "FK_projectTasks_Project_projectId",
                        column: x => x.projectId,
                        principalTable: "Project",
                        principalColumn: "project_id");
                });

            migrationBuilder.CreateTable(
                name: "userRoles",
                columns: table => new
                {
                    user_role_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_role_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRoles", x => x.user_role_id);
                });

            migrationBuilder.CreateTable(
                name: "acttachments",
                columns: table => new
                {
                    acttachment_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    acttachment_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date_create = table.Column<DateTime>(type: "datetime2", nullable: false),
                    taskuserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acttachments", x => x.acttachment_id);
                    table.ForeignKey(
                        name: "FK_acttachments_projectTasks_taskuserId",
                        column: x => x.taskuserId,
                        principalTable: "projectTasks",
                        principalColumn: "project_task_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_project_detail_userId",
                table: "project_detail",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_acttachments_taskuserId",
                table: "acttachments",
                column: "taskuserId");

            migrationBuilder.CreateIndex(
                name: "IX_projectTasks_projectId",
                table: "projectTasks",
                column: "projectId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_project_detail_Project_projectId",
                table: "project_detail");

            migrationBuilder.DropForeignKey(
                name: "FK_project_detail_User_userId",
                table: "project_detail");

            migrationBuilder.DropTable(
                name: "acttachments");

            migrationBuilder.DropTable(
                name: "userRoles");

            migrationBuilder.DropTable(
                name: "projectTasks");

            migrationBuilder.DropIndex(
                name: "IX_project_detail_userId",
                table: "project_detail");

            migrationBuilder.DropColumn(
                name: "avatar",
                table: "User");

            migrationBuilder.DropColumn(
                name: "project",
                table: "project_detail");

            migrationBuilder.DropColumn(
                name: "user",
                table: "project_detail");

            migrationBuilder.DropColumn(
                name: "date_start",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "is_active",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "project_name",
                table: "Project");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "User",
                newName: "use_id");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "project_detail",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "projectId",
                table: "project_detail",
                newName: "ApplicationUseruserId");

            migrationBuilder.RenameIndex(
                name: "IX_project_detail_projectId",
                table: "project_detail",
                newName: "IX_project_detail_ApplicationUseruserId");

            migrationBuilder.AlterColumn<Guid>(
                name: "user_id",
                table: "project_detail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationProjectprojectId",
                table: "project_detail",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_project_detail_ApplicationProjectprojectId",
                table: "project_detail",
                column: "ApplicationProjectprojectId");

            migrationBuilder.AddForeignKey(
                name: "FK_project_detail_Project_ApplicationProjectprojectId",
                table: "project_detail",
                column: "ApplicationProjectprojectId",
                principalTable: "Project",
                principalColumn: "project_id");

            migrationBuilder.AddForeignKey(
                name: "FK_project_detail_User_ApplicationUseruserId",
                table: "project_detail",
                column: "ApplicationUseruserId",
                principalTable: "User",
                principalColumn: "use_id");
        }
    }
}
