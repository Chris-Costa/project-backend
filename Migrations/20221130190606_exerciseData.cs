using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_backend.Migrations
{
    public partial class exerciseData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { "The deadlift is a movement in which your hips hinge backward to lower down and pick up a weighted barbell or kettlebell from the floor. Your back is flat throughout the movement. Some benefits of performing deadlifts include strengthening and gaining more definition in your upper and lower back, glutes, and hamstrings.", "Advanced", "assets/images/deadLift.jpg", "Compound", "Deadlift", "1-4", "https://www.youtube.com/embed/r4MzxtBKyNE" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 4, "A squat is a strength exercise in which the trainee lowers their hips from a standing position and then stands back up. During the descent of a squat, the hip and knee joints flex while the ankle joint dorsiflexes; conversely the hip and knee joints extend and the ankle joint plantarflexes when standing up.", "Intermediate", "assets/images/backSquat.jpg", "Legs", "Squat (Back)", "4-8", "https://www.youtube.com/embed/Uv_DKDl7EjA" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 5, "A front squat is a squat that is performed while holding a barbell except, unlike with a back squat, the bar is held in front of the chest. This places more force on the upper body while still working the glutes, hamstrings, and hips.", "Intermediate", "assets/images/frontSquat.jpg", "Legs", "Squat (Front)", "4-8", "https://www.youtube.com/embed/7pyxT5hqmQY" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 6, "From a standing position, bend your knees and push your hips back as you would for a regular squat. Stop when your thighs are parallel to the ground. Pause briefly with your knees over, but not beyond, your toes. Push through your heels to return to the starting position, giving your glutes a squeeze at the top", "Beginner", "assets/images/bulgarian.jpg", "Legs", "Bulgarian Split Squats", "8-12", "https://www.youtube.com/embed/hPlKPjohFS0" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 7, "Leg extensions are exercises usually done with a lever machine. You sit on a padded seat and raise a padded bar with your legs. The exercise works mainly the quadriceps muscles of the front of the thigh—the rectus femoris and the vastus muscles.", "Beginner", "assets/images/legExtensions.jpg", "Legs", "Leg Extensions", "8-12", "https://www.youtube.com/embed/9nmAtebIwy8" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 8, "The hamstring curl, also called a leg curl, is an exercise that strengthens the hamstrings. It involves bending your knees and moving your heels toward your butt while the rest of your body stays still. Typically, the exercise is done on a leg curl machine", "Beginner", "assets/images/hamstringCurls.jpg", "Legs", "Hamstring Curls", "8-12", "https://www.youtube.com/embed/F488k67BTNo" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 9, "Exercises don't come much simpler than the calf raise. Stand up straight, then push through the balls of your feet and raise your heel until you are standing on your toes. Then lower slowly back to the start.", "Beginner", "assets/images/calfRaises.jpg", "Calfs", "Calf Raises", "12-15", "https://www.youtube.com/embed/gwLzBJYoWlI" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 10, "The Romanian deadlift (RDL) is a traditional barbell lift used to develop the strength of the posterior chain muscles, including the erector spinae, gluteus maximus, hamstrings and adductors. When done correctly, the RDL is an effective exercise that helps strengthen both the core and the lower body with one move.", "Advanced", "assets/images/rdls.webp", "Hamstrings", "Romanian Deadlifts", "8-12", "https://www.youtube.com/embed/7AaaYhMqTws" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 11, "The HS is a Squat variation that is performed on a machine and involves pushing the weight away from you, at an angle, as you stand back up. You must stand on the plate with your body leaning back against the pads. The weight is moved during the concentric phase of the movement.", "Beginner", "assets/images/hackSquat.jpg", "Legs", "Hack Squat", "8-12", "https://www.youtube.com/embed/0tn5K9NlCfo" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 12, "The Arnold presses is defined by a wrist rotation movement that ends when your palms face forward at the top of the press. The Arnold press uses dumbbells to work many of the main muscle groups in your upper body, including the triceps, trapezius, and the delts.", "Beginner", "assets/images/arnolds.jpg", "Sholders", "Arnlod Press", "8-12", "https://www.youtube.com/embed/3ml7BH7mNwQ" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 13, "A lateral raise is a strength training shoulder exercise characterized by lifting a pair of dumbbells away from your body in an external rotation. Lateral raises work the trapezius muscle in your upper back as well as the deltoid muscle group in your shoulders—particularly the anterior and lateral deltoids.", "Beginner", "assets/images/lateralRaise.webp", "Sholders", "Lateral Raise", "8-12", "https://www.youtube.com/embed/kDqklk1ZESo" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 14, "What Is the Face Pull Exercise? The face pull is an isolation exercise that activates muscles in your lower back and upper back—specifically the rear deltoids on the back of your shoulders. Practice face pulls by standing in front of a cable pulley machine. Grab the rope attachment with an overhand grip.", "Beginner", "assets/images/facePulls.jpg", "Sholders", "Face Pulls", "8-12", "https://www.youtube.com/embed/V8dZ3pyiCBo" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 15, "The front raise, also known as the dumbbell front raise, is a weight training exercise that targets your shoulder muscles. Perform front raises by standing and using an overhand grip to lift a pair of dumbbells from the front of your thighs to shoulder level in front of your body.", "Beginner", "assets/images/frontRaise.png", "Sholders", "Front Raise", "8-12", "https://www.youtube.com/embed/ALNyDCkW9y8" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 16, "Lean forward, letting your arms hang down next to your calves with your elbows slightly bent. Slowly raise the weights until your elbows are level with your shoulders. Then slowly lower the weights to the starting position. You'll feel tension in your shoulders and the muscles across your upper back", "Beginner", "assets/images/reverseFly.jpg", "Sholders", "Rear Delt Fly", "8-12", "https://www.youtube.com/embed/6yMdhi2DVao" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 17, "A pullup is a challenging upper body exercise where you grip an overhead bar and lift your body until your chin is above that bar. It's a hard exercise to execute — so hard, in fact, that a U.S. Marine can receive a passing score on the annual physical fitness test without doing pullups at all.", "Intermediate", "assets/images/pullUp.jpg", "Back", "Pull ups", "8-12", "https://www.youtube.com/embed/jFmCrA6fo78" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 18, "Hold the barbell with both hands facing up so the wrists, elbows, and shoulders are in a straight line about shoulder-width apart. Lift the barbell toward the shoulders while bending the elbows and keeping them next to the middle of the body. Slowly lower the weight to return to the starting position.", "Beginner", "assets/images/bicepCurls.jpg", "Arms", "Bicep Curl", "8-12", "https://www.youtube.com/embed/av7-8igSXTs" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 19, "The more mundane name for skull crushers is “lying triceps extensions.” This exercise is typically performed lying on your back (supine) with a barbell or dumbbells. Skull crushers work your triceps — the muscle on the back of your upper arm. The triceps, as the name implies, is a muscle with three heads.", "Beginner", "assets/images/skullCrushers.jpg", "Arms", "Skull Crushers", "8-12", "https://www.youtube.com/embed/VP9Qp72zZ_c" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { 20, "The hammer curl, also known as the dumbbell hammer curl or the neutral grip dumbbell curl, is a strength training exercise that targets your biceps and forearms. The hammer curl varies from the traditional bicep curl by using a neutral grip with your palms facing each other during the full range of motion", "Beginner", "assets/images/hammerCurls.webp", "Arms", "Hammer Curls", "8-12", "https://www.youtube.com/embed/7jqi2qWAUJk" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Difficulty", "ImageURL", "MuscleGroup", "Name", "RepRange", "VideoURL" },
                values: new object[] { "Some Descr", "Easy", "x", "Chest", "Fly's", "10-15", "x" });
        }
    }
}
