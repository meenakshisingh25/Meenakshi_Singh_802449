using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.Authenticateservice.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.CreateTable(
                name: "user",
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
                    table.PrimaryKey("PK_user", x => x.User_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    User_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    User_Password = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.User_Id);
                });
        }
    }
}
