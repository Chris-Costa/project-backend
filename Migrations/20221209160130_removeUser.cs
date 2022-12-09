using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_backend.Migrations
{
    public partial class removeUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workout_Users_UserId",
                table: "Workout");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Workout_UserId",
                table: "Workout");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Workout");

            migrationBuilder.AddColumn<string>(
                name: "AzureId",
                table: "Workout",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 1,
                column: "AzureId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 2,
                column: "AzureId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 3,
                column: "AzureId",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 4,
                column: "AzureId",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 5,
                column: "AzureId",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 6,
                column: "AzureId",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 7,
                column: "AzureId",
                value: "3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AzureId",
                table: "Workout");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Workout",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Avatar = table.Column<string>(type: "TEXT", nullable: true),
                    AzureId = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Firstname = table.Column<string>(type: "TEXT", nullable: true),
                    Lastname = table.Column<string>(type: "TEXT", nullable: true),
                    WeightGoal = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "AzureId", "Email", "Firstname", "Lastname", "WeightGoal" },
                values: new object[] { 1, null, "x", "LMartin567", "Linda", "Martin", 145 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "AzureId", "Email", "Firstname", "Lastname", "WeightGoal" },
                values: new object[] { 2, null, "x", "JSmith215", "Jack", "Smith", 175 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "AzureId", "Email", "Firstname", "Lastname", "WeightGoal" },
                values: new object[] { 3, null, "x", "CLong498", "Cindy", "Long", 115 });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Workout_UserId",
                table: "Workout",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workout_Users_UserId",
                table: "Workout",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
