using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.Technologyservice.Migrations
{
    public partial class newmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Payment_Id = table.Column<string>(nullable: false),
                    Payment_amount = table.Column<string>(nullable: true),
                    User_Id = table.Column<string>(nullable: true),
                    User_Name = table.Column<string>(nullable: true),
                    Mentor_Id = table.Column<string>(nullable: true),
                    Mentor_Name = table.Column<string>(nullable: true),
                    Training_Id = table.Column<string>(nullable: true),
                    Mentor_Amount = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Payment_Id);
                    table.ForeignKey(
                        name: "FK_Payments_Mentors_Mentor_Id",
                        column: x => x.Mentor_Id,
                        principalTable: "Mentors",
                        principalColumn: "Mentor_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Trainings_Training_Id",
                        column: x => x.Training_Id,
                        principalTable: "Trainings",
                        principalColumn: "Training_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Mentor_Id",
                table: "Payments",
                column: "Mentor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Training_Id",
                table: "Payments",
                column: "Training_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_User_Id",
                table: "Payments",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_Mentor_id",
                table: "Trainings",
                column: "Mentor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_User_Id",
                table: "Trainings",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "Mentors");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
