using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_backend.Migrations
{
    public partial class updateLiftTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lift_Exercises_ExerciseId",
                table: "Lift");

            migrationBuilder.DropIndex(
                name: "IX_Lift_ExerciseId",
                table: "Lift");

            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "Lift");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Lift",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Lift",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bench");

            migrationBuilder.UpdateData(
                table: "Lift",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Fly's");

            migrationBuilder.UpdateData(
                table: "Lift",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Pushups");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Lift");

            migrationBuilder.AddColumn<int>(
                name: "ExerciseId",
                table: "Lift",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Lift",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExerciseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Lift",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExerciseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Lift",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExerciseId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Lift_ExerciseId",
                table: "Lift",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lift_Exercises_ExerciseId",
                table: "Lift",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
