﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project_backend.Data;

#nullable disable

namespace project_backend.Migrations
{
    [DbContext(typeof(CVFitContext))]
    [Migration("20221111192740_updateLiftTable")]
    partial class updateLiftTable
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

                    b.ToTable("Blogs");

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

            modelBuilder.Entity("project_backend.Entities.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Workout");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Full Body Day",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Title = "Leg Day",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Title = "Chest",
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            Title = "Armd",
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            Title = "Back & Bi's",
                            UserId = 2
                        },
                        new
                        {
                            Id = 6,
                            Title = "FullBody",
                            UserId = 3
                        },
                        new
                        {
                            Id = 7,
                            Title = "Cardio and Abs",
                            UserId = 3
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

            modelBuilder.Entity("project_backend.Entities.Workout", b =>
                {
                    b.HasOne("project_backend.Entities.User", "User")
                        .WithMany("Workout")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("project_backend.Entities.Blog", b =>
                {
                    b.Navigation("Comment");
                });

            modelBuilder.Entity("project_backend.Entities.User", b =>
                {
                    b.Navigation("Workout");
                });

            modelBuilder.Entity("project_backend.Entities.Workout", b =>
                {
                    b.Navigation("Lift");
                });
#pragma warning restore 612, 618
        }
    }
}
