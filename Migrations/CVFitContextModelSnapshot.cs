﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project_backend.Data;

#nullable disable

namespace project_backend.Migrations
{
    [DbContext(typeof(CVFitContext))]
    partial class CVFitContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("project_backend.Entities.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("Avatar")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<int>("Likes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Tommy Hamilton",
                            Avatar = "./assets/images/ava1-modified.png",
                            Content = "Does anyone have suggestions for apps to track my macro intakes.  Why do you recommend?",
                            Likes = 5,
                            Title = "Good apps for tracking macros??"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Gina Smith",
                            Avatar = "./assets/images/ava2-modified.png",
                            Content = "When chest pressing I can only feel tension in my biceps and sholders.  Any tips to engage chest and triceps?",
                            Likes = 2,
                            Title = "Mind Muscle Connection Help"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Mike Glennon",
                            Avatar = "./assets/images/ava3-modified.png",
                            Content = "What type of cardio do people prefer.  Looking to lose weight fast and have a good sweat.",
                            Likes = 12,
                            Title = "Best form of cadio?"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Jim Fisher",
                            Avatar = "./assets/images/ava4-modified.png",
                            Content = "I've been waking up extremely sore recently and think its time to start prioritizing recovery.  Any tips and tricks??",
                            Likes = 9,
                            Title = "Recovery Tips"
                        });
                });

            modelBuilder.Entity("project_backend.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlogId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Reply")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Comment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlogId = 1,
                            Reply = "Generic Reply",
                            User = "Alexander"
                        },
                        new
                        {
                            Id = 2,
                            BlogId = 1,
                            Reply = "Generic Reply",
                            User = "Sam"
                        },
                        new
                        {
                            Id = 3,
                            BlogId = 2,
                            Reply = "Generic Reply",
                            User = "Peter"
                        },
                        new
                        {
                            Id = 4,
                            BlogId = 3,
                            Reply = "Generic Reply",
                            User = "Jeremy"
                        });
                });

            modelBuilder.Entity("project_backend.Entities.ContactUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ContactUs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "mGreen234@gmail.com",
                            Firstname = "Mike",
                            Lastname = "Green",
                            Notes = "Some generic message about what they want to get out of a membership"
                        },
                        new
                        {
                            Id = 2,
                            Email = "sCassel893@gmail.com",
                            Firstname = "Shannon",
                            Lastname = "Cassel",
                            Notes = "Some generic message about what they want to get out of a membership"
                        },
                        new
                        {
                            Id = 3,
                            Email = "lRice034@gmail.com",
                            Firstname = "Lexi",
                            Lastname = "Rice",
                            Notes = "Some generic message about what they want to get out of a membership"
                        },
                        new
                        {
                            Id = 4,
                            Email = "tMaderia432@gmail.com",
                            Firstname = "Tyler",
                            Lastname = "Maderia",
                            Notes = "Some generic message about what they want to get out of a membership"
                        });
                });

            modelBuilder.Entity("project_backend.Entities.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Difficulty")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("MuscleGroup")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("RepRange")
                        .HasColumnType("TEXT");

                    b.Property<string>("VideoURL")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Sit on the bench with your knees bent and grasp the cable attachment. It often has a triangle handle, but it may be a bar. Position yourself with your knees slightly bent, so you have to reach to grab the handle with outstretched arms without curling the lower back over. Brace the abdominals, and you're ready to row",
                            Difficulty = "Intermediate",
                            ImageURL = "assets/images/Row.png",
                            MuscleGroup = "Back",
                            Name = "Seated Cable Rows",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/sP_4vybjVJs"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Grasp the bar with a overhand wide grip with an overhand. Pull the bar down until it's approximately level with the chin. Exhale on the downward motion. Squeeze the shoulder blades together while maintaining square shoulders.",
                            Difficulty = "Beginner",
                            ImageURL = "assets/images/LatPulldown.webp",
                            MuscleGroup = "Back",
                            Name = "Lat Pulldowns",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/j9jtjL8FhPI"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The deadlift is a movement in which your hips hinge backward to lower down and pick up a weighted barbell or kettlebell from the floor. Your back is flat throughout the movement. Some benefits of performing deadlifts include strengthening and gaining more definition in your upper and lower back, glutes, and hamstrings.",
                            Difficulty = "Advanced",
                            ImageURL = "assets/images/deadLift.jpg",
                            MuscleGroup = "Compound",
                            Name = "Deadlift",
                            RepRange = "1-4",
                            VideoURL = "https://www.youtube.com/embed/r4MzxtBKyNE"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A squat is a strength exercise in which the trainee lowers their hips from a standing position and then stands back up. During the descent of a squat, the hip and knee joints flex while the ankle joint dorsiflexes; conversely the hip and knee joints extend and the ankle joint plantarflexes when standing up.",
                            Difficulty = "Intermediate",
                            ImageURL = "assets/images/backSquat.jpg",
                            MuscleGroup = "Legs",
                            Name = "Squat (Back)",
                            RepRange = "4-8",
                            VideoURL = "https://www.youtube.com/embed/Uv_DKDl7EjA"
                        },
                        new
                        {
                            Id = 5,
                            Description = "A front squat is a squat that is performed while holding a barbell except, unlike with a back squat, the bar is held in front of the chest. This places more force on the upper body while still working the glutes, hamstrings, and hips.",
                            Difficulty = "Intermediate",
                            ImageURL = "assets/images/frontSquat.jpg",
                            MuscleGroup = "Legs",
                            Name = "Squat (Front)",
                            RepRange = "4-8",
                            VideoURL = "https://www.youtube.com/embed/7pyxT5hqmQY"
                        },
                        new
                        {
                            Id = 6,
                            Description = "From a standing position, bend your knees and push your hips back as you would for a regular squat. Stop when your thighs are parallel to the ground. Pause briefly with your knees over, but not beyond, your toes. Push through your heels to return to the starting position, giving your glutes a squeeze at the top",
                            Difficulty = "Beginner",
                            ImageURL = "assets/images/bulgarian.jpg",
                            MuscleGroup = "Legs",
                            Name = "Bulgarian Split Squats",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/hPlKPjohFS0"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Leg extensions are exercises usually done with a lever machine. You sit on a padded seat and raise a padded bar with your legs. The exercise works mainly the quadriceps muscles of the front of the thigh—the rectus femoris and the vastus muscles.",
                            Difficulty = "Beginner",
                            ImageURL = "assets/images/legExtensions.jpg",
                            MuscleGroup = "Legs",
                            Name = "Leg Extensions",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/9nmAtebIwy8"
                        },
                        new
                        {
                            Id = 8,
                            Description = "The hamstring curl, also called a leg curl, is an exercise that strengthens the hamstrings. It involves bending your knees and moving your heels toward your butt while the rest of your body stays still. Typically, the exercise is done on a leg curl machine",
                            Difficulty = "Beginner",
                            ImageURL = "assets/images/hamstringCurls.jpg",
                            MuscleGroup = "Legs",
                            Name = "Hamstring Curls",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/F488k67BTNo"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Exercises don't come much simpler than the calf raise. Stand up straight, then push through the balls of your feet and raise your heel until you are standing on your toes. Then lower slowly back to the start.",
                            Difficulty = "Beginner",
                            ImageURL = "assets/images/calfRaises.jpg",
                            MuscleGroup = "Calfs",
                            Name = "Calf Raises",
                            RepRange = "12-15",
                            VideoURL = "https://www.youtube.com/embed/gwLzBJYoWlI"
                        },
                        new
                        {
                            Id = 10,
                            Description = "The Romanian deadlift (RDL) is a traditional barbell lift used to develop the strength of the posterior chain muscles, including the erector spinae, gluteus maximus, hamstrings and adductors. When done correctly, the RDL is an effective exercise that helps strengthen both the core and the lower body with one move.",
                            Difficulty = "Advanced",
                            ImageURL = "assets/images/rdls.webp",
                            MuscleGroup = "Hamstrings",
                            Name = "Romanian Deadlifts",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/7AaaYhMqTws"
                        },
                        new
                        {
                            Id = 11,
                            Description = "The HS is a Squat variation that is performed on a machine and involves pushing the weight away from you, at an angle, as you stand back up. You must stand on the plate with your body leaning back against the pads. The weight is moved during the concentric phase of the movement.",
                            Difficulty = "Beginner",
                            ImageURL = "assets/images/hackSquat.jpg",
                            MuscleGroup = "Legs",
                            Name = "Hack Squat",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/0tn5K9NlCfo"
                        },
                        new
                        {
                            Id = 12,
                            Description = "The Arnold presses is defined by a wrist rotation movement that ends when your palms face forward at the top of the press. The Arnold press uses dumbbells to work many of the main muscle groups in your upper body, including the triceps, trapezius, and the delts.",
                            Difficulty = "Beginner",
                            ImageURL = "assets/images/arnolds.jpg",
                            MuscleGroup = "Sholders",
                            Name = "Arnlod Press",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/3ml7BH7mNwQ"
                        },
                        new
                        {
                            Id = 13,
                            Description = "A lateral raise is a strength training shoulder exercise characterized by lifting a pair of dumbbells away from your body in an external rotation. Lateral raises work the trapezius muscle in your upper back as well as the deltoid muscle group in your shoulders—particularly the anterior and lateral deltoids.",
                            Difficulty = "Beginner",
                            ImageURL = "assets/images/lateralRaise.webp",
                            MuscleGroup = "Sholders",
                            Name = "Lateral Raise",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/kDqklk1ZESo"
                        },
                        new
                        {
                            Id = 14,
                            Description = "What Is the Face Pull Exercise? The face pull is an isolation exercise that activates muscles in your lower back and upper back—specifically the rear deltoids on the back of your shoulders. Practice face pulls by standing in front of a cable pulley machine. Grab the rope attachment with an overhand grip.",
                            Difficulty = "Beginner",
                            ImageURL = "assets/images/facePulls.jpg",
                            MuscleGroup = "Sholders",
                            Name = "Face Pulls",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/V8dZ3pyiCBo"
                        },
                        new
                        {
                            Id = 15,
                            Description = "The front raise, also known as the dumbbell front raise, is a weight training exercise that targets your shoulder muscles. Perform front raises by standing and using an overhand grip to lift a pair of dumbbells from the front of your thighs to shoulder level in front of your body.",
                            Difficulty = "Beginner",
                            ImageURL = "assets/images/frontRaise.png",
                            MuscleGroup = "Sholders",
                            Name = "Front Raise",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/ALNyDCkW9y8"
                        },
                        new
                        {
                            Id = 16,
                            Description = "Lean forward, letting your arms hang down next to your calves with your elbows slightly bent. Slowly raise the weights until your elbows are level with your shoulders. Then slowly lower the weights to the starting position. You'll feel tension in your shoulders and the muscles across your upper back",
                            Difficulty = "Beginner",
                            ImageURL = "assets/images/reverseFly.jpg",
                            MuscleGroup = "Sholders",
                            Name = "Rear Delt Fly",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/6yMdhi2DVao"
                        },
                        new
                        {
                            Id = 17,
                            Description = "A pullup is a challenging upper body exercise where you grip an overhead bar and lift your body until your chin is above that bar. It's a hard exercise to execute — so hard, in fact, that a U.S. Marine can receive a passing score on the annual physical fitness test without doing pullups at all.",
                            Difficulty = "Intermediate",
                            ImageURL = "assets/images/pullUp.jpg",
                            MuscleGroup = "Back",
                            Name = "Pull ups",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/jFmCrA6fo78"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Hold the barbell with both hands facing up so the wrists, elbows, and shoulders are in a straight line about shoulder-width apart. Lift the barbell toward the shoulders while bending the elbows and keeping them next to the middle of the body. Slowly lower the weight to return to the starting position.",
                            Difficulty = "Beginner",
                            ImageURL = "assets/images/bicepCurls.jpg",
                            MuscleGroup = "Arms",
                            Name = "Bicep Curl",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/av7-8igSXTs"
                        },
                        new
                        {
                            Id = 19,
                            Description = "The more mundane name for skull crushers is “lying triceps extensions.” This exercise is typically performed lying on your back (supine) with a barbell or dumbbells. Skull crushers work your triceps — the muscle on the back of your upper arm. The triceps, as the name implies, is a muscle with three heads.",
                            Difficulty = "Beginner",
                            ImageURL = "assets/images/skullCrushers.jpg",
                            MuscleGroup = "Arms",
                            Name = "Skull Crushers",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/VP9Qp72zZ_c"
                        },
                        new
                        {
                            Id = 20,
                            Description = "The hammer curl, also known as the dumbbell hammer curl or the neutral grip dumbbell curl, is a strength training exercise that targets your biceps and forearms. The hammer curl varies from the traditional bicep curl by using a neutral grip with your palms facing each other during the full range of motion",
                            Difficulty = "Beginner",
                            ImageURL = "assets/images/hammerCurls.webp",
                            MuscleGroup = "Arms",
                            Name = "Hammer Curls",
                            RepRange = "8-12",
                            VideoURL = "https://www.youtube.com/embed/7jqi2qWAUJk"
                        });
                });

            modelBuilder.Entity("project_backend.Entities.Lift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Reps")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Sets")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Weight")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Lift");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bench",
                            Reps = 12,
                            Sets = 4,
                            Weight = 45,
                            WorkoutId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fly's",
                            Reps = 12,
                            Sets = 4,
                            Weight = 145,
                            WorkoutId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Pushups",
                            Reps = 20,
                            Sets = 4,
                            Weight = 0,
                            WorkoutId = 3
                        });
                });

            modelBuilder.Entity("project_backend.Entities.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AzureId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Workout");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AzureId = "1",
                            Title = "Full Body Day"
                        },
                        new
                        {
                            Id = 2,
                            AzureId = "1",
                            Title = "Leg Day"
                        },
                        new
                        {
                            Id = 3,
                            AzureId = "2",
                            Title = "Chest"
                        },
                        new
                        {
                            Id = 4,
                            AzureId = "2",
                            Title = "Armd"
                        },
                        new
                        {
                            Id = 5,
                            AzureId = "2",
                            Title = "Back & Bi's"
                        },
                        new
                        {
                            Id = 6,
                            AzureId = "3",
                            Title = "FullBody"
                        },
                        new
                        {
                            Id = 7,
                            AzureId = "3",
                            Title = "Cardio and Abs"
                        });
                });

            modelBuilder.Entity("project_backend.Entities.Comment", b =>
                {
                    b.HasOne("project_backend.Entities.Blog", "Blog")
                        .WithMany("Comment")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("project_backend.Entities.Lift", b =>
                {
                    b.HasOne("project_backend.Entities.Workout", "Workout")
                        .WithMany("Lift")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("project_backend.Entities.Blog", b =>
                {
                    b.Navigation("Comment");
                });

            modelBuilder.Entity("project_backend.Entities.Workout", b =>
                {
                    b.Navigation("Lift");
                });
#pragma warning restore 612, 618
        }
    }
}
