﻿// <auto-generated />
using System;
using MOD.Userservice.Contextin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MOD.Userservice.Migrations
{
    [DbContext(typeof(UserServiceContext))]
    [Migration("20191122074853_newmig")]
    partial class newmig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MOD.Userservice.Models.Mentor", b =>
                {
                    b.Property<string>("Mentor_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Mentor_Active")
                        .HasColumnType("bit");

                    b.Property<string>("Mentor_ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentor_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentor_LinkedInUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentor_Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Mentor_Primary_Skill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentor_exp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentor_facility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentor_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentor_timeslot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Mentor_id");

                    b.ToTable("Mentors");
                });

            modelBuilder.Entity("MOD.Userservice.Models.Payment", b =>
                {
                    b.Property<string>("Payment_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("Mentor_Amount")
                        .HasColumnType("float");

                    b.Property<string>("Mentor_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Mentor_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Payment_amount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Training_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("User_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Payment_Id");

                    b.HasIndex("Mentor_Id");

                    b.HasIndex("Training_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("MOD.Userservice.Models.Skill", b =>
                {
                    b.Property<string>("SkillId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("SkillId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TOC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("fee")
                        .HasColumnType("float");

                    b.Property<string>("prerequisite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.HasIndex("SkillId1");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("MOD.Userservice.Models.Training", b =>
                {
                    b.Property<string>("Training_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Mentor_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Mentor_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Payment_Status")
                        .HasColumnType("bit");

                    b.Property<bool?>("RejectNotify")
                        .HasColumnType("bit");

                    b.Property<bool?>("Requested")
                        .HasColumnType("bit");

                    b.Property<string>("Skill_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Skill_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Training_EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Training_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Training_Progress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Training_StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Training_duration")
                        .HasColumnType("int");

                    b.Property<string>("Training_rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Training_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Training_timeslot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("User_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Training_ID");

                    b.HasIndex("Mentor_ID");

                    b.HasIndex("Skill_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("MOD.Userservice.Models.user", b =>
                {
                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("User_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("User_Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("User_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MOD.Userservice.Models.Payment", b =>
                {
                    b.HasOne("MOD.Userservice.Models.Mentor", "Mentor")
                        .WithMany("Payments")
                        .HasForeignKey("Mentor_Id");

                    b.HasOne("MOD.Userservice.Models.Training", "Training")
                        .WithMany("Payments")
                        .HasForeignKey("Training_Id");

                    b.HasOne("MOD.Userservice.Models.user", "user")
                        .WithMany("Payments")
                        .HasForeignKey("User_Id");
                });

            modelBuilder.Entity("MOD.Userservice.Models.Skill", b =>
                {
                    b.HasOne("MOD.Userservice.Models.Skill", null)
                        .WithMany("Skills")
                        .HasForeignKey("SkillId1");
                });

            modelBuilder.Entity("MOD.Userservice.Models.Training", b =>
                {
                    b.HasOne("MOD.Userservice.Models.Mentor", "Mentor")
                        .WithMany("Trainings")
                        .HasForeignKey("Mentor_ID");

                    b.HasOne("MOD.Userservice.Models.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("Skill_ID");

                    b.HasOne("MOD.Userservice.Models.user", "user")
                        .WithMany("Trainings")
                        .HasForeignKey("User_ID");
                });
#pragma warning restore 612, 618
        }
    }
}