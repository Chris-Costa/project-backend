using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using project_backend.Entities;

namespace project_backend.Data
{
    public class CVFitContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Workout> Workout { get; set; }
        public DbSet<Lift> Lift { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }

        public string DbPath { get; }

        public CVFitContext(DbContextOptions<CVFitContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog()
                { 
                    Id=1,
                    Title="Test1",
                    Author="Alexander",
                    Content="Content for test1",
                    Avatar="x",
                    Likes=5
                },
                new Blog()
                {
                    Id=2,
                    Title="Test2",
                    Author="Alonso",
                    Content="Content for test2",
                    Avatar="x",
                    Likes=24
                },
                new Blog()
                {
                    Id=3,
                    Title="Test3",
                    Author="Anand",
                    Content="Content for test3",
                    Avatar="x",
                    Likes=12
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
                    Name="Fly's",
                    MuscleGroup="Chest",
                    Description="Some Descr",
                    RepRange="10-15",
                    Difficulty="Easy",
                    ImageURL="x",
                    VideoURL="x"
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
            
            modelBuilder.Entity<User>().HasData(
                new User()
                { 
                    Id=1,
                    Firstname="Linda",
                    Lastname="Martin",
                    Username="LMartin567",
                    Avatar="x",
                    WeightGoal=145
                },
                new User()
                {
                    Id=2,
                    Firstname="Jack",
                    Lastname="Smith",
                    Username="JSmith215",
                    Avatar="x",
                    WeightGoal=175
                },
                new User()
                {
                    Id=3,
                    Firstname="Cindy",
                    Lastname="Long",
                    Username="CLong498",
                    Avatar="x",
                    WeightGoal=115
                });

            modelBuilder.Entity<Workout>().HasData(
                new Workout()
                {
                    Id=1,
                    UserId=1,
                    Title="Full Body Day"
                },
                new Workout()
                {
                    Id=2,
                    UserId=1,
                    Title="Leg Day"
                },
                new Workout()
                {
                    Id=3,
                    UserId=2,
                    Title="Chest"
                },
                new Workout()
                {
                    Id=4,
                    UserId=2,
                    Title="Armd"
                },
                new Workout()
                {
                    Id=5,
                    UserId=2,
                    Title="Back & Bi's"
                },
                new Workout()
                {
                    Id=6,
                    UserId=3,
                    Title="FullBody"
                },
                new Workout()
                {
                    Id=7,
                    UserId=3,
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