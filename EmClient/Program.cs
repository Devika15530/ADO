using EFCOREDBFirst.Models;
using System;

namespace EmClient
{
    class Program
    {
        static void Main(string[] args)
        {

            using (PracticeDBContext db = new PracticeDBContext())
            {
                Project p = new Project() { Pid="1" , Pname = "BFS" ,Sdate=DateTime.Now,Edate=DateTime.Parse("9-8-2222")};
                db.Add(p);
                db.SaveChanges();
            }
        } 
    }
}
