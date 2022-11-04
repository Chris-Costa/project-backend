using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_backend.Migrations
{
    public partial class DataSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    User = table.Column<string>(type: "TEXT", nullable: false),
                    Reply = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_BlogPosts_BlogId",
                        column: x => x.BlogId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workout",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workout_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lift",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Weight = table.Column<int>(type: "INTEGER", nullable: true),
                    Sets = table.Column<int>(type: "INTEGER", nullable: true),
                    Reps = table.Column<int>(type: "INTEGER", nullable: true),
                    WorkoutId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lift_Workout_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workout",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "BlogId", "Reply", "User" },
                values: new object[] { 1, 1, "Generic Reply", "Alexander" });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "BlogId", "Reply", "User" },
                values: new object[] { 2, 1, "Generic Reply", "Sam" });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "BlogId", "Reply", "User" },
                values: new object[] { 3, 2, "Generic Reply", "Peter" });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "BlogId", "Reply", "User" },
                values: new object[] { 4, 3, "Generic Reply", "Jeremy" });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "Title", "UserId" },
                values: new object[] { 1, "Full Body Day", 1 });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "Title", "UserId" },
                values: new object[] { 2, "Leg Day", 1 });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "Title", "UserId" },
                values: new object[] { 3, "Chest", 2 });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "Title", "UserId" },
                values: new object[] { 4, "Armd", 2 });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "Title", "UserId" },
                values: new object[] { 5, "Back & Bi's", 2 });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "Title", "UserId" },
                values: new object[] { 6, "FullBody", 3 });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "Title", "UserId" },
                values: new object[] { 7, "Cardio and Abs", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_BlogId",
                table: "Comment",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Lift_WorkoutId",
                table: "Lift",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_UserId",
                table: "Workout",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Lift");

            migrationBuilder.DropTable(
                name: "Workout");
        }
    }
}
