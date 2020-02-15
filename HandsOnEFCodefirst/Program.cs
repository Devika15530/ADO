using System;
using HandsOnEFCodefirst.Context;
using HandsOnEFCodefirst.Models;
using System.Linq;
using System.Collections.Generic;

namespace HandsOnEFCodefirst
{
    class Program
    {
        static void Main(string[] args)
        {
        using(MyContext db=new MyContext())
            {
                //insert new record
                //Student s = new Student() { Sname = "Dev", Age = 10, Std = "10" };
                //db.Students.Add(s);
                //db.SaveChanges();
                //Student s = db.Students.Find(1);
                //Console.WriteLine("Welcome{0}", s.Sname);
                //fetching record using non primarykey
                /* Student s1 = db.Students.SingleOrDefault(i => i.Sname=="Dev");*///single

                //List<Student> list = db.Students.Where(i => i.Age == 10).ToList();//multiplerecords
                //List<Student> list1 = db.Students.Where(i => i.Age == 10 && i.Std=="10").ToList();//multiple conditons
                //Student s2 = db.Students.Find(1);
                //s2.Age = 12;
                //db.Students.Update(s2);
                //db.SaveChanges();

                //delete record
                //Student s3 = db.Students.SingleOrDefault(i=>i.Sname=="Devika");
                //db.Students.Remove(s3);
                //db.SaveChanges();
            

            }
        }
    }
}
