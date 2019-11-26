using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.Authenticateservice.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MentorDetails",
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
                    table.PrimaryKey("PK_MentorDetails", x => x.Mentor_id);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
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
                    table.PrimaryKey("PK_UserDetails", x => x.User_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MentorDetails");

            migrationBuilder.DropTable(
                name: "UserDetails");
        }
    }
}
