using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using project_backend.Entities;

namespace project_backend.Data
{
    public class CVFitContext : DbContext
    {
        public CVFitContext(DbContextOptions<CVFitContext> options)
            :base(options)
        { }
        
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Workout> Workout { get; set; }
        public DbSet<Lift> Lift { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }

        public string DbPath { get; }

        

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog()
                { 
                    Id=1,
                    Title="Good apps for tracking macros??",
                    Author="Tommy Hamilton",
                    Content="Does anyone have suggestions for apps to track my macro intakes.  Why do you recommend?",
                    Avatar="./assets/images/ava1-modified.png",
                    Category=1
                },
                new Blog()
                {
                    Id=2,
                    Title="Mind Muscle Connection Help",
                    Author="Gina Smith",
                    Content="When chest pressing I can only feel tension in my biceps and sholders.  Any tips to engage chest and triceps?",
                    Avatar="./assets/images/ava2-modified.png",
                    Category=2
                },
                new Blog()
                {
                    Id=3,
                    Title="Best form of cadio?",
                    Author="Mike Glennon",
                    Content="What type of cardio do people prefer.  Looking to lose weight fast and have a good sweat.",
                    Avatar="./assets/images/ava3-modified.png",
                    Category=2
                },
                new Blog()
                {
                    Id=4,
                    Title="Recovery Tips",
                    Author="Jim Fisher",
                    Content="I've been waking up extremely sore recently and think its time to start prioritizing recovery.  Any tips and tricks??",
                    Avatar="./assets/images/ava4-modified.png",
                    Category=3
                });

            modelBuilder.Entity<Comment>().HasData(
                new Comment()
                { 
                    Id=1,
                    BlogId=1,
                    User="Alexander",
                    Reply="Generic Reply"
                },
                new Comment()
                { 
                    Id=2,
                    BlogId=1,
                    User="Sam",
                    Reply="Generic Reply"
                },
                new Comment()
                { 
                    Id=3,
                    BlogId=2,
                    User="Peter",
                    Reply="Generic Reply"
                },
                new Comment()
                { 
                    Id=4,
                    BlogId=3,
                    User="Jeremy",
                    Reply="Generic Reply"
                });

            modelBuilder.Entity<Exercise>().HasData(
                new Exercise()
                {
                Id=1,
                Name="Seated Cable Rows",
                MuscleGroup="Back",
                Description="Sit on the bench with your knees bent and grasp the cable attachment. It often has a triangle handle, but it may be a bar. Position yourself with your knees slightly bent, so you have to reach to grab the handle with outstretched arms without curling the lower back over. Brace the abdominals, and you're ready to row",
                RepRange="8-12",
                Difficulty="Intermediate",
                ImageURL="assets/images/Row.png",
                VideoURL="https://www.youtube.com/embed/sP_4vybjVJs"
                },
                new Exercise()
                {
                Id=2,
                Name="Lat Pulldowns",
                MuscleGroup="Back",
                Description="Grasp the bar with a overhand wide grip with an overhand. Pull the bar down until it's approximately level with the chin. Exhale on the downward motion. Squeeze the shoulder blades together while maintaining square shoulders.",
                RepRange="8-12",
                Difficulty="Beginner",
                ImageURL="assets/images/LatPulldown.webp",
                VideoURL="https://www.youtube.com/embed/j9jtjL8FhPI"
                },
                new Exercise()
                {
                Id=3,
                Name="Deadlift",
                MuscleGroup="Compound",
                Description="The deadlift is a movement in which your hips hinge backward to lower down and pick up a weighted barbell or kettlebell from the floor. Your back is flat throughout the movement. Some benefits of performing deadlifts include strengthening and gaining more definition in your upper and lower back, glutes, and hamstrings.",
                RepRange="1-4",
                Difficulty="Advanced",
                ImageURL="assets/images/deadLift.jpg",
                VideoURL="https://www.youtube.com/embed/r4MzxtBKyNE"
                },
                new Exercise()
                {
                Id=4,
                Name="Squat (Back)",
                MuscleGroup="Legs",
                Description="A squat is a strength exercise in which the trainee lowers their hips from a standing position and then stands back up. During the descent of a squat, the hip and knee joints flex while the ankle joint dorsiflexes; conversely the hip and knee joints extend and the ankle joint plantarflexes when standing up.",
                RepRange="4-8",
                Difficulty="Intermediate",
                ImageURL="assets/images/backSquat.jpg",
                VideoURL="https://www.youtube.com/embed/Uv_DKDl7EjA"
                },
                new Exercise()
                {
                Id=5,
                Name="Squat (Front)",
                MuscleGroup="Legs",
                Description="A front squat is a squat that is performed while holding a barbell except, unlike with a back squat, the bar is held in front of the chest. This places more force on the upper body while still working the glutes, hamstrings, and hips.",
                RepRange="4-8",
                Difficulty="Intermediate",
                ImageURL="assets/images/frontSquat.jpg",
                VideoURL="https://www.youtube.com/embed/7pyxT5hqmQY"
                },
                new Exercise()
                {
                Id=6,
                Name="Bulgarian Split Squats",
                MuscleGroup="Legs",
                Description="From a standing position, bend your knees and push your hips back as you would for a regular squat. Stop when your thighs are parallel to the ground. Pause briefly with your knees over, but not beyond, your toes. Push through your heels to return to the starting position, giving your glutes a squeeze at the top",
                RepRange="8-12",
                Difficulty="Beginner",
                ImageURL="assets/images/bulgarian.jpg",
                VideoURL="https://www.youtube.com/embed/hPlKPjohFS0"
                },
                new Exercise()
                {
                Id=7,
                Name="Leg Extensions",
                MuscleGroup="Legs",
                Description="Leg extensions are exercises usually done with a lever machine. You sit on a padded seat and raise a padded bar with your legs. The exercise works mainly the quadriceps muscles of the front of the thigh—the rectus femoris and the vastus muscles.",
                RepRange="8-12",
                Difficulty="Beginner",
                ImageURL="assets/images/legExtensions.jpg",
                VideoURL="https://www.youtube.com/embed/9nmAtebIwy8"
                },
                new Exercise()
                {
                Id=8,
                Name="Hamstring Curls",
                MuscleGroup="Legs",
                Description="The hamstring curl, also called a leg curl, is an exercise that strengthens the hamstrings. It involves bending your knees and moving your heels toward your butt while the rest of your body stays still. Typically, the exercise is done on a leg curl machine",
                RepRange="8-12",
                Difficulty="Beginner",
                ImageURL="assets/images/hamstringCurls.jpg",
                VideoURL="https://www.youtube.com/embed/F488k67BTNo"
                },
                new Exercise()
                {
                Id=9,
                Name="Calf Raises",
                MuscleGroup="Calfs",
                Description="Exercises don't come much simpler than the calf raise. Stand up straight, then push through the balls of your feet and raise your heel until you are standing on your toes. Then lower slowly back to the start.",
                RepRange="12-15",
                Difficulty="Beginner",
                ImageURL="assets/images/calfRaises.jpg",
                VideoURL="https://www.youtube.com/embed/gwLzBJYoWlI"
                },
                new Exercise()
                {
                Id=10,
                Name="Romanian Deadlifts",
                MuscleGroup="Hamstrings",
                Description="The Romanian deadlift (RDL) is a traditional barbell lift used to develop the strength of the posterior chain muscles, including the erector spinae, gluteus maximus, hamstrings and adductors. When done correctly, the RDL is an effective exercise that helps strengthen both the core and the lower body with one move.",
                RepRange="8-12",
                Difficulty="Advanced",
                ImageURL="assets/images/rdls.webp",
                VideoURL="https://www.youtube.com/embed/7AaaYhMqTws"
                },
                new Exercise()
                {
                Id=11,
                Name="Hack Squat",
                MuscleGroup="Legs",
                Description="The HS is a Squat variation that is performed on a machine and involves pushing the weight away from you, at an angle, as you stand back up. You must stand on the plate with your body leaning back against the pads. The weight is moved during the concentric phase of the movement.",
                RepRange="8-12",
                Difficulty="Beginner",
                ImageURL="assets/images/hackSquat.jpg",
                VideoURL="https://www.youtube.com/embed/0tn5K9NlCfo"
                },
                new Exercise()
                {
                Id=12,
                Name="Arnlod Press",
                MuscleGroup="Sholders",
                Description="The Arnold presses is defined by a wrist rotation movement that ends when your palms face forward at the top of the press. The Arnold press uses dumbbells to work many of the main muscle groups in your upper body, including the triceps, trapezius, and the delts.",
                RepRange="8-12",
                Difficulty="Beginner",
                ImageURL="assets/images/arnolds.jpg",
                VideoURL="https://www.youtube.com/embed/3ml7BH7mNwQ"
                },
                new Exercise()
                {
                Id=13,
                Name="Lateral Raise",
                MuscleGroup="Sholders",
                Description="A lateral raise is a strength training shoulder exercise characterized by lifting a pair of dumbbells away from your body in an external rotation. Lateral raises work the trapezius muscle in your upper back as well as the deltoid muscle group in your shoulders—particularly the anterior and lateral deltoids.",
                RepRange="8-12",
                Difficulty="Beginner",
                ImageURL="assets/images/lateralRaise.webp",
                VideoURL="https://www.youtube.com/embed/kDqklk1ZESo"
                },
                new Exercise()
                {
                Id=14,
                Name="Face Pulls",
                MuscleGroup="Sholders",
                Description="What Is the Face Pull Exercise? The face pull is an isolation exercise that activates muscles in your lower back and upper back—specifically the rear deltoids on the back of your shoulders. Practice face pulls by standing in front of a cable pulley machine. Grab the rope attachment with an overhand grip.",
                RepRange="8-12",
                Difficulty="Beginner",
                ImageURL="assets/images/facePulls.jpg",
                VideoURL="https://www.youtube.com/embed/V8dZ3pyiCBo"
                },
                new Exercise()
                {
                Id=15,
                Name="Front Raise",
                MuscleGroup="Sholders",
                Description="The front raise, also known as the dumbbell front raise, is a weight training exercise that targets your shoulder muscles. Perform front raises by standing and using an overhand grip to lift a pair of dumbbells from the front of your thighs to shoulder level in front of your body.",
                RepRange="8-12",
                Difficulty="Beginner",
                ImageURL="assets/images/frontRaise.png",
                VideoURL="https://www.youtube.com/embed/ALNyDCkW9y8"
                },
                new Exercise()
                {
                Id=16,
                Name="Rear Delt Fly",
                MuscleGroup="Sholders",
                Description="Lean forward, letting your arms hang down next to your calves with your elbows slightly bent. Slowly raise the weights until your elbows are level with your shoulders. Then slowly lower the weights to the starting position. You'll feel tension in your shoulders and the muscles across your upper back",
                RepRange="8-12",
                Difficulty="Beginner",
                ImageURL="assets/images/reverseFly.jpg",
                VideoURL="https://www.youtube.com/embed/6yMdhi2DVao"
                },
                new Exercise()
                {
                Id=17,
                Name="Pull ups",
                MuscleGroup="Back",
                Description="A pullup is a challenging upper body exercise where you grip an overhead bar and lift your body until your chin is above that bar. It's a hard exercise to execute — so hard, in fact, that a U.S. Marine can receive a passing score on the annual physical fitness test without doing pullups at all.",
                RepRange="8-12",
                Difficulty="Intermediate",
                ImageURL="assets/images/pullUp.jpg",
                VideoURL="https://www.youtube.com/embed/jFmCrA6fo78"
                },
                new Exercise()
                {
                Id=18,
                Name="Bicep Curl",
                MuscleGroup="Arms",
                Description="Hold the barbell with both hands facing up so the wrists, elbows, and shoulders are in a straight line about shoulder-width apart. Lift the barbell toward the shoulders while bending the elbows and keeping them next to the middle of the body. Slowly lower the weight to return to the starting position.",
                RepRange="8-12",
                Difficulty="Beginner",
                ImageURL="assets/images/bicepCurls.jpg",
                VideoURL="https://www.youtube.com/embed/av7-8igSXTs"
                },
                new Exercise()
                {
                Id=19,
                Name="Skull Crushers",
                MuscleGroup="Arms",
                Description="The more mundane name for skull crushers is “lying triceps extensions.” This exercise is typically performed lying on your back (supine) with a barbell or dumbbells. Skull crushers work your triceps — the muscle on the back of your upper arm. The triceps, as the name implies, is a muscle with three heads.",
                RepRange="8-12",
                Difficulty="Beginner",
                ImageURL="assets/images/skullCrushers.jpg",
                VideoURL="https://www.youtube.com/embed/VP9Qp72zZ_c"
                },
                new Exercise()
                {
                Id=20,
                Name="Hammer Curls",
                MuscleGroup="Arms",
                Description="The hammer curl, also known as the dumbbell hammer curl or the neutral grip dumbbell curl, is a strength training exercise that targets your biceps and forearms. The hammer curl varies from the traditional bicep curl by using a neutral grip with your palms facing each other during the full range of motion",
                RepRange="8-12",
                Difficulty="Beginner",
                ImageURL="assets/images/hammerCurls.webp",
                VideoURL="https://www.youtube.com/embed/7jqi2qWAUJk"
                });
            
            modelBuilder.Entity<Lift>().HasData(
                new Lift()
                {
                    Id=1,
                    Name="Bench",
                    WorkoutId=1,
                    Weight=45,
                    Sets=4,
                    Reps=12
                },
                new Lift()
                {
                    Id=2,
                    Name="Fly's",
                    WorkoutId=1,
                    Weight=145,
                    Sets=4,
                    Reps=12
                },
                new Lift()
                {
                    Id=3,
                    Name="Pushups",
                    WorkoutId=3,
                    Weight=0,
                    Sets=4,
                    Reps=20
                });

            modelBuilder.Entity<Workout>().HasData(
                new Workout()
                {
                    Id=1,
                    AzureId="1",
                    Title="Full Body Day"
                },
                new Workout()
                {
                    Id=2,
                    AzureId="1",
                    Title="Leg Day"
                },
                new Workout()
                {
                    Id=3,
                    AzureId="2",
                    Title="Chest"
                },
                new Workout()
                {
                    Id=4,
                    AzureId="2",
                    Title="Armd"
                },
                new Workout()
                {
                    Id=5,
                    AzureId="2",
                    Title="Back & Bi's"
                },
                new Workout()
                {
                    Id=6,
                    AzureId="3",
                    Title="FullBody"
                },
                new Workout()
                {
                    Id=7,
                    AzureId="3",
                    Title="Cardio and Abs"
                });

            modelBuilder.Entity<ContactUs>().HasData(
                new ContactUs()
                {
                    Id=1,
                    Firstname= "Mike",
                    Lastname="Green",
                    Email="mGreen234@gmail.com",
                    Notes="Some generic message about what they want to get out of a membership"
                },
                new ContactUs()
                {
                    Id=2,
                    Firstname="Shannon",
                    Lastname="Cassel",
                    Email="sCassel893@gmail.com",
                    Notes="Some generic message about what they want to get out of a membership"
                },
                new ContactUs()
                {
                    Id=3,
                    Firstname="Lexi",
                    Lastname="Rice",
                    Email="lRice034@gmail.com",
                    Notes="Some generic message about what they want to get out of a membership"
                },
                new ContactUs()
                {
                    Id=4,
                    Firstname="Tyler",
                    Lastname="Maderia",
                    Email="tMaderia432@gmail.com",
                    Notes="Some generic message about what they want to get out of a membership"
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}