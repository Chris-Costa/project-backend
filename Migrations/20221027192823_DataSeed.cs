using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_backend.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "BlogPosts",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "Author", "Avatar", "Content", "Likes", "Title" },
                values: new object[] { 1, "Alexander", "x", "Content for test1", 5, "Test1" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "Author", "Avatar", "Content", "Likes", "Title" },
                values: new object[] { 2, "Alonso", "x", "Content for test2", 24, "Test2" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "Author", "Avatar", "Content", "Likes", "Title" },
                values: new object[] { 3, "Anand", "x", "Content for test3", 12, "Test3" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 1, "Some Descr", "Easy", "x", "Chest", "Pushups", "10-20", "x" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 2, "Some Descr", "Medium", "x", "Chest", "Bench", "5-10", "x" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 3, "Some Descr", "Easy", "x", "Chest", "Fly's", "10-15", "x" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "Firstname", "Lastname", "Username", "WeightGoal" },
                values: new object[] { 1, "x", "Linda", "Martin", "LMartin567", 145 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "Firstname", "Lastname", "Username", "WeightGoal" },
                values: new object[] { 2, "x", "Jack", "Smith", "JSmith215", 175 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "Firstname", "Lastname", "Username", "WeightGoal" },
                values: new object[] { 3, "x", "Cindy", "Long", "CLong498", 115 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "BlogPosts",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
