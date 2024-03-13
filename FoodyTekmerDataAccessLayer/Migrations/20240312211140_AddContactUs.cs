using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodyTekmerDataAccessLayer.Migrations
{
    public partial class AddContactUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    ContactUsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactUsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactUsEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactUsSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactUsMessage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.ContactUsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUs");
        }
    }
}
