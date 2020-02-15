using ExOnDataAccess.Context;
using ExOnDataAccess.Models;
using System;

namespace EXClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
        Item p = new Item() { Itemname = "DAS"  };
                //Order o = new Order() { ItemId = 1, OrderDate = DateTime.Now };
                //db.Add(o);
                db.Add(p);
            
           
                db.SaveChanges();
            }
        }
    }
}
