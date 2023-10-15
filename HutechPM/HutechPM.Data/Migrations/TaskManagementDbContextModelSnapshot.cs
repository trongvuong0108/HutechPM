﻿// <auto-generated />
using System;
using HutechPM.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HutechNote.Data.Migrations
{
    [DbContext(typeof(HutechNoteDbContext))]
    partial class TaskManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HutechNote.Data.Data.User.ApplicationUser", b =>
                {
                    b.Property<Guid>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("use_id");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("address");

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

                    b.ToTable("User");
                });

            modelBuilder.Entity("HutechPM.Data.Data.Project.ApplicationProject", b =>
                {
                    b.Property<Guid>("projectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("project_id");

                    b.HasKey("projectId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("HutechPM.Data.Data.ProjectDetail.ApplicationProjectDetail", b =>
                {
                    b.Property<Guid>("projectDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("project_detail_id");

                    b.Property<Guid?>("ApplicationProjectprojectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ApplicationUseruserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProjectId")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.Property<int>("projectRole")
                        .HasColumnType("int")
                        .HasColumnName("project_role");

                    b.Property<DateTime>("timeJoin")
                        .HasColumnType("datetime2")
                        .HasColumnName("time_join");

                    b.Property<DateTime>("timeLeft")
                        .HasColumnType("datetime2")
                        .HasColumnName("time_left");

                    b.Property<Guid>("userId")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("projectDetailId");

                    b.HasIndex("ApplicationProjectprojectId");

                    b.HasIndex("ApplicationUseruserId");

                    b.ToTable("project_detail");
                });

            modelBuilder.Entity("HutechPM.Data.Data.ProjectDetail.ApplicationProjectDetail", b =>
                {
                    b.HasOne("HutechPM.Data.Data.Project.ApplicationProject", null)
                        .WithMany("ApplicationProjectDetails")
                        .HasForeignKey("ApplicationProjectprojectId");

                    b.HasOne("HutechNote.Data.Data.User.ApplicationUser", null)
                        .WithMany("ApplicationProjectDetails")
                        .HasForeignKey("ApplicationUseruserId");
                });

            modelBuilder.Entity("HutechNote.Data.Data.User.ApplicationUser", b =>
                {
                    b.Navigation("ApplicationProjectDetails");
                });

            modelBuilder.Entity("HutechPM.Data.Data.Project.ApplicationProject", b =>
                {
                    b.Navigation("ApplicationProjectDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
