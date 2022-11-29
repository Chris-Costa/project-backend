using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_backend.Migrations
{
    public partial class seedLift : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lift",
                columns: new[] { "Id", "ExerciseId", "Reps", "Sets", "Weight", "WorkoutId" },
                values: new object[] { 1, 1, 12, 4, 45, 1 });

            migrationBuilder.InsertData(
                table: "Lift",
                columns: new[] { "Id", "ExerciseId", "Reps", "Sets", "Weight", "WorkoutId" },
                values: new object[] { 2, 3, 12, 4, 145, 1 });

            migrationBuilder.InsertData(
                table: "Lift",
                columns: new[] { "Id", "ExerciseId", "Reps", "Sets", "Weight", "WorkoutId" },
                values: new object[] { 3, 2, 20, 4, 0, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lift",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lift",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lift",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
