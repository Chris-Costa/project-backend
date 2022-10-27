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