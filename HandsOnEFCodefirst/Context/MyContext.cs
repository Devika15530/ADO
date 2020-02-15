using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HandsOnEFCodefirst.Models;
namespace HandsOnEFCodefirst.Context
{
    class MyContext : DbContext
    {
      //define entities
      public DbSet<Student> Students { get; set; }
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define connection string
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FG8RRLB\SQLEXPRESS ; Initial Catalog = StudentDB; User ID = sa; Password = pass@word1");

        }


    }
}
