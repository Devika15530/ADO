using ExOnDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace ExOnDataAccess.Context
{
   public  class MyContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FG8RRLB\SQLEXPRESS;Initial Catalog=OrderDb;User ID=sa;Password=pass@word1");

        }
        public DbSet<Order> Order { get; set; }
        public DbSet<Item>  Items { get; set; }
    }
  
}
