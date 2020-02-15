using System;
using System.Collections.Generic;
using System.Text;
using DataAccesslayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccesslayer.Context
{
   public class MyContext:DbContext
    {
protected  override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FG8RRLB\SQLEXPRESS;Initial Catalog=EMSDB;User ID=sa;Password=pass@word1");

        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
