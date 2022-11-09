using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_backend.Migrations
{
    public partial class updateTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_BlogPosts_BlogId",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Lift");

            migrationBuilder.RenameTable(
                name: "BlogPosts",
                newName: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "ExerciseId",
                table: "Lift",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lift_ExerciseId",
                table: "Lift",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Blogs_BlogId",
                table: "Comment",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lift_Exercises_ExerciseId",
                table: "Lift",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Blogs_BlogId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Lift_Exercises_ExerciseId",
                table: "Lift");

            migrationBuilder.DropIndex(
                name: "IX_Lift_ExerciseId",
                table: "Lift");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "Lift");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "BlogPosts");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Lift",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPosts",
                table: "BlogPosts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_BlogPosts_BlogId",
                table: "Comment",
                column: "BlogId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
