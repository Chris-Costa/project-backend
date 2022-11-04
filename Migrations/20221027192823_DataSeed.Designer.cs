﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project_backend.Data;

#nullable disable

namespace project_backend.Migrations
{
    [DbContext(typeof(CVFitContext))]
    [Migration("20221027192823_DataSeed")]
    partial class DataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.ToTable("BlogPosts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Alexander",
                            Avatar = "x",
                            Content = "Content for test1",
                            Likes = 5,
                            Title = "Test1"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Alonso",
                            Avatar = "x",
                            Content = "Content for test2",
                            Likes = 24,
                            Title = "Test2"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Anand",
                            Avatar = "x",
                            Content = "Content for test3",
                            Likes = 12,
                            Title = "Test3"
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
                            Description = "Some Descr",
                            Difficulty = "Easy",
                            ImageURL = "x",
                            MuscleGroup = "Chest",
                            Name = "Pushups",
                            RepRange = "10-20",
                            VideoURL = "x"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Some Descr",
                            Difficulty = "Medium",
                            ImageURL = "x",
                            MuscleGroup = "Chest",
                            Name = "Bench",
                            RepRange = "5-10",
                            VideoURL = "x"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Some Descr",
                            Difficulty = "Easy",
                            ImageURL = "x",
                            MuscleGroup = "Chest",
                            Name = "Fly's",
                            RepRange = "10-15",
                            VideoURL = "x"
                        });
                });

            modelBuilder.Entity("project_backend.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Avatar")
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<int>("WeightGoal")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avatar = "x",
                            Firstname = "Linda",
                            Lastname = "Martin",
                            Username = "LMartin567",
                            WeightGoal = 145
                        },
                        new
                        {
                            Id = 2,
                            Avatar = "x",
                            Firstname = "Jack",
                            Lastname = "Smith",
                            Username = "JSmith215",
                            WeightGoal = 175
                        },
                        new
                        {
                            Id = 3,
                            Avatar = "x",
                            Firstname = "Cindy",
                            Lastname = "Long",
                            Username = "CLong498",
                            WeightGoal = 115
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
