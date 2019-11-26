﻿// <auto-generated />
using MOD.Authenticateservice.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MOD.Authenticateservice.Migrations
{
    [DbContext(typeof(LoginContext))]
    [Migration("20191119103023_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MOD.Authenticateservice.Models.MentorDetails", b =>
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

                    b.ToTable("MentorDetails");
                });

            modelBuilder.Entity("MOD.Authenticateservice.Models.UserDetails", b =>
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

                    b.ToTable("UserDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
