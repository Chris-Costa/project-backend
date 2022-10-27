using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using project_backend.Entities;

namespace project_backend.Data
{
    public class CVFitContext : DbContext
    {
        public DbSet<Blog> BlogPosts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<User> Users { get; set; }

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

            modelBuilder.Entity<Exercise>().HasData(
                new Exercise()
                {
                    Id=1,
                    Name="Pushups",
                    MuscleGroup="Chest",
                    Description="Some Descr",
                    RepRange="10-20",
                    Difficulty="Easy",
                    ImageURL="x",
                    VideoURL="x"
                },
                new Exercise()
                {
                    Id=2,
                    Name="Bench",
                    MuscleGroup="Chest",
                    Description="Some Descr",
                    RepRange="5-10",
                    Difficulty="Medium",
                    ImageURL="x",
                    VideoURL="x"
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

            base.OnModelCreating(modelBuilder);
        }
        /*
        public CVFitContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "blogging.db");
        }
        // The following configures EF to create a Sqlite database file in the special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
        */
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("connectionstring");
            base.OnConfiguring(optionsBuilder);
        }
        */
    }
}