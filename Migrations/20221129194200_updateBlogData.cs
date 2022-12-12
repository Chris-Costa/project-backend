using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_backend.Migrations
{
    public partial class updateBlogData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Avatar", "Content", "Title" },
                values: new object[] { "Tommy Hamilton", "./assets/images/ava1-modified.png", "Does anyone have suggestions for apps to track my macro intakes.  Why do you recommend?", "Good apps for tracking macros??" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Avatar", "Content", "Likes", "Title" },
                values: new object[] { "Gina Smith", "./assets/images/ava2-modified.png", "When chest pressing I can only feel tension in my biceps and sholders.  Any tips to engage chest and triceps?", 2, "Mind Muscle Connection Help" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Avatar", "Content", "Title" },
                values: new object[] { "Mike Glennon", "./assets/images/ava3-modified.png", "What type of cardio do people prefer.  Looking to lose weight fast and have a good sweat.", "Best form of cadio?" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Author", "Avatar", "Content", "Likes", "Title" },
                values: new object[] { 4, "Jim Fisher", "./assets/images/ava4-modified.png", "I've been waking up extremely sore recently and think its time to start prioritizing recovery.  Any tips and tricks??", 9, "Recovery Tips" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { "Sit on the bench with your knees bent and grasp the cable attachment. It often has a triangle handle, but it may be a bar. Position yourself with your knees slightly bent, so you have to reach to grab the handle with outstretched arms without curling the lower back over. Brace the abdominals, and you're ready to row", "Intermediate", "assets/images/Row.png", "Back", "Seated Cable Rows", "8-12", "https://www.youtube.com/embed/sP_4vybjVJs" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { "Grasp the bar with a overhand wide grip with an overhand. Pull the bar down until it's approximately level with the chin. Exhale on the downward motion. Squeeze the shoulder blades together while maintaining square shoulders.", "Beginner", "assets/images/LatPulldown.webp", "Back", "Lat Pulldowns", "8-12", "https://www.youtube.com/embed/j9jtjL8FhPI" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Avatar", "Content", "Title" },
                values: new object[] { "Alexander", "x", "Content for test1", "Test1" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Avatar", "Content", "Likes", "Title" },
                values: new object[] { "Alonso", "x", "Content for test2", 24, "Test2" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Avatar", "Content", "Title" },
                values: new object[] { "Anand", "x", "Content for test3", "Test3" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { "Some Descr", "Easy", "x", "Chest", "Pushups", "10-20", "x" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { "Some Descr", "Medium", "x", "Chest", "Bench", "5-10", "x" });
        }
    }
}
