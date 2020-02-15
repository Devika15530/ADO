using System;
using DataAccesslayer;
using DataAccesslayer.Context;
using DataAccesslayer.Models;

namespace EMSClient
{
    class Program
    {
        static void Main(string[] args)
        {
   //Add New Project


            using(MyContext db=new MyContext())
            {
                Project p = new Project() { ProjectName = "BFS" };
                db.Add(p);
                db.SaveChanges();
            }                
        }
    }
}
