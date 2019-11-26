using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.Paymentservice.Migrations
{
    public partial class newmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mentor_Id",
                table: "Payments",
                newName: "Mentor_id");

            migrationBuilder.AlterColumn<string>(
                name: "Mentor_id",
                table: "Payments",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mentor_Id",
                table: "Payments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_Id1",
                table: "Payments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Mentors",
                columns: table => new
                {
                    Mentor_id = table.Column<string>(nullable: false),
                    Mentor_name = table.Column<string>(nullable: false),
                    Mentor_Email = table.Column<string>(nullable: false),
                    Mentor_Password = table.Column<string>(maxLength: 10, nullable: false),
                    Mentor_ContactNo = table.Column<string>(nullable: true),
                    Mentor_exp = table.Column<string>(nullable: false),
                    Mentor_Primary_Skill = table.Column<string>(nullable: true),
                    Mentor_timeslot = table.Column<string>(nullable: true),
                    Mentor_Active = table.Column<bool>(nullable: false),
                    Role = table.Column<string>(nullable: true),
                    Mentor_LinkedInUrl = table.Column<string>(nullable: true),
                    Mentor_facility = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentors", x => x.Mentor_id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<string>(nullable: false),
                    SkillName = table.Column<string>(nullable: false),
                    TOC = table.Column<string>(nullable: true),
                    prerequisite = table.Column<string>(nullable: true),
                    fee = table.Column<double>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    SkillId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_Skills_Skills_SkillId1",
                        column: x => x.SkillId1,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_Id = table.Column<string>(nullable: false),
                    User_Name = table.Column<string>(maxLength: 30, nullable: false),
                    User_Email = table.Column<string>(nullable: true),
                    User_Mobile = table.Column<string>(nullable: true),
                    User_Password = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Training_ID = table.Column<string>(nullable: false),
                    Training_Name = table.Column<string>(nullable: false),
                    User_ID = table.Column<string>(nullable: true),
                    User_Name = table.Column<string>(nullable: true),
                    Mentor_ID = table.Column<string>(nullable: true),
                    Mentor_Name = table.Column<string>(nullable: true),
                    Skill_ID = table.Column<string>(nullable: true),
                    Skill_Name = table.Column<string>(nullable: true),
                    Training_StartDate = table.Column<DateTime>(nullable: true),
                    Training_EndDate = table.Column<DateTime>(nullable: true),
                    Training_timeslot = table.Column<string>(nullable: true),
                    Training_status = table.Column<string>(nullable: true),
                    Training_Progress = table.Column<string>(nullable: true),
                    Training_rating = table.Column<string>(nullable: true),
                    Training_duration = table.Column<int>(nullable: false),
                    Requested = table.Column<bool>(nullable: true),
                    RejectNotify = table.Column<bool>(nullable: true),
                    Payment_Status = table.Column<bool>(nullable: true),
                    Mentor_id = table.Column<string>(nullable: true),
                    User_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Training_ID);
                    table.ForeignKey(
                        name: "FK_Trainings_Mentors_Mentor_id",
                        column: x => x.Mentor_id,
                        principalTable: "Mentors",
                        principalColumn: "Mentor_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trainings_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Mentor_id",
                table: "Payments",
                column: "Mentor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_User_Id1",
                table: "Payments",
                column: "User_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_SkillId1",
                table: "Skills",
                column: "SkillId1");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_Mentor_id",
                table: "Trainings",
                column: "Mentor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_User_Id",
                table: "Trainings",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Mentors_Mentor_id",
                table: "Payments",
                column: "Mentor_id",
                principalTable: "Mentors",
                principalColumn: "Mentor_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Users_User_Id1",
                table: "Payments",
                column: "User_Id1",
                principalTable: "Users",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Mentors_Mentor_id",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Users_User_Id1",
                table: "Payments");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "Mentors");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Payments_Mentor_id",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_User_Id1",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Mentor_Id",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "User_Id1",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "Mentor_id",
                table: "Payments",
                newName: "Mentor_Id");

            migrationBuilder.AlterColumn<string>(
                name: "Mentor_Id",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
