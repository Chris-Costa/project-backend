using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_backend.Migrations
{
    public partial class AddandSeedContactUS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Firstname = table.Column<string>(type: "TEXT", nullable: true),
                    Lastname = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ContactUs",
                columns: new[] { "Id", "Email", "Firstname", "Lastname", "Notes" },
                values: new object[] { 1, "mGreen234@gmail.com", "Mike", "Green", "Some generic message about what they want to get out of a membership" });

            migrationBuilder.InsertData(
                table: "ContactUs",
                columns: new[] { "Id", "Email", "Firstname", "Lastname", "Notes" },
                values: new object[] { 2, "sCassel893@gmail.com", "Shannon", "Cassel", "Some generic message about what they want to get out of a membership" });

            migrationBuilder.InsertData(
                table: "ContactUs",
                columns: new[] { "Id", "Email", "Firstname", "Lastname", "Notes" },
                values: new object[] { 3, "lRice034@gmail.com", "Lexi", "Rice", "Some generic message about what they want to get out of a membership" });

            migrationBuilder.InsertData(
                table: "ContactUs",
                columns: new[] { "Id", "Email", "Firstname", "Lastname", "Notes" },
                values: new object[] { 4, "tMaderia432@gmail.com", "Tyler", "Maderia", "Some generic message about what they want to get out of a membership" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUs");
        }
    }
}
