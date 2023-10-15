﻿// <auto-generated />
using System;
using HutechPM.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HutechNote.Data.Migrations
{
    [DbContext(typeof(HutechNoteDbContext))]
    [Migration("20231015131158_update-table-v1")]
    partial class updatetablev1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HutechPM.Data.Entities.Project", b =>
                {
                    b.Property<Guid>("projectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("project_id");

                    b.Property<DateTime>("dateStart")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_start");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<string>("projectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("project_name");

                    b.HasKey("projectId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("HutechPM.Data.Entities.ProjectAttachment", b =>
                {
                    b.Property<Guid>("acttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("acttachment_id");

                    b.Property<DateTime>("dateCreate")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_create");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("acttachment_name");

                    b.Property<Guid>("taskuserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("acttachmentId");

                    b.HasIndex("taskuserId");

                    b.ToTable("ProjectAttachment");
                });

            modelBuilder.Entity("HutechPM.Data.Entities.ProjectDetail", b =>
                {
                    b.Property<Guid>("projectDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("project_detail_id");

                    b.Property<Guid>("project")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("projectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("projectRole")
                        .HasColumnType("int")
                        .HasColumnName("project_role");

                    b.Property<DateTime>("timeJoin")
                        .HasColumnType("datetime2")
                        .HasColumnName("time_join");

                    b.Property<DateTime>("timeLeft")
                        .HasColumnType("datetime2")
                        .HasColumnName("time_left");

                    b.Property<Guid>("user")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("userId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("projectDetailId");

                    b.HasIndex("projectId");

                    b.HasIndex("userId");

                    b.ToTable("ProjectDetail");
                });

            modelBuilder.Entity("HutechPM.Data.Entities.ProjectTask", b =>
                {
                    b.Property<Guid>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("project_task_id");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<int>("estimate")
                        .HasColumnType("int")
                        .HasColumnName("estimate");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<Guid>("projectDetailId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("remaining")
                        .HasColumnType("int")
                        .HasColumnName("remaining");

                    b.HasKey("userId");

                    b.HasIndex("projectDetailId");

                    b.ToTable("ProjectTask");
                });

            modelBuilder.Entity("HutechPM.Data.Entities.User", b =>
                {
                    b.Property<Guid>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.Property<int?>("UserRoleId")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("address");

                    b.Property<string>("avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("avatar");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("full_name");

                    b.Property<bool>("gender")
                        .HasColumnType("bit")
                        .HasColumnName("gender");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("phone");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("user_name");

                    b.HasKey("userId");

                    b.HasIndex("UserRoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("HutechPM.Data.Entities.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_role_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserRoleId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("user_role_name");

                    b.HasKey("UserRoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("HutechPM.Data.Entities.ProjectAttachment", b =>
                {
                    b.HasOne("HutechPM.Data.Entities.ProjectTask", "task")
                        .WithMany("projectAttachments")
                        .HasForeignKey("taskuserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("task");
                });

            modelBuilder.Entity("HutechPM.Data.Entities.ProjectDetail", b =>
                {
                    b.HasOne("HutechPM.Data.Entities.Project", null)
                        .WithMany("ApplicationProjectDetails")
                        .HasForeignKey("projectId");

                    b.HasOne("HutechPM.Data.Entities.User", null)
                        .WithMany("ApplicationProjectDetails")
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("HutechPM.Data.Entities.ProjectTask", b =>
                {
                    b.HasOne("HutechPM.Data.Entities.ProjectDetail", "projectDetail")
                        .WithMany("projectTasks")
                        .HasForeignKey("projectDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("projectDetail");
                });

            modelBuilder.Entity("HutechPM.Data.Entities.User", b =>
                {
                    b.HasOne("HutechPM.Data.Entities.UserRole", null)
                        .WithMany("users")
                        .HasForeignKey("UserRoleId");
                });

            modelBuilder.Entity("HutechPM.Data.Entities.Project", b =>
                {
                    b.Navigation("ApplicationProjectDetails");
                });

            modelBuilder.Entity("HutechPM.Data.Entities.ProjectDetail", b =>
                {
                    b.Navigation("projectTasks");
                });

            modelBuilder.Entity("HutechPM.Data.Entities.ProjectTask", b =>
                {
                    b.Navigation("projectAttachments");
                });

            modelBuilder.Entity("HutechPM.Data.Entities.User", b =>
                {
                    b.Navigation("ApplicationProjectDetails");
                });

            modelBuilder.Entity("HutechPM.Data.Entities.UserRole", b =>
                {
                    b.Navigation("users");
                });
#pragma warning restore 612, 618
        }
    }
}
