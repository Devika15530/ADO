using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExOnAdo
{
    class Program
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FG8RRLB\SQLEXPRESS;Initial Catalog=PracticeDB;User ID=sa;Password=pass@word1");
        SqlCommand cmd = null;

        public void Add()
        {
            try
            {

                cmd = new SqlCommand("Insert into product values(@id,@name,@price,@stock)", con);//passing values to parameters
                cmd.Parameters.AddWithValue("@id", "p3");
                cmd.Parameters.AddWithValue("@name", "c");
                cmd.Parameters.AddWithValue("@price", 348);
                cmd.Parameters.AddWithValue("@stock", 451);
                con.Open();//open connection
                cmd.ExecuteNonQuery();//execute query(dml)
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Get(string id)
        {
            try
            {
                cmd = new SqlCommand("select * from product where id=@pid", con);
                cmd.Parameters.AddWithValue("@pid", id);
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();//execute select statements
                if (dr.HasRows)//check rows existensce
                {
                    dr.Read();//read only one record
                    Console.WriteLine("ID:{0} Name:{1} price:{2} stock:{3} ", dr["id"], dr["name"], dr["price"], dr["stock"]);
                }
                else
                    Console.WriteLine("Invalid projecr ID");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        public void GetAll()
        {
            try
            {
                cmd = new SqlCommand("select * from product", con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("ID:{0} Name:{1} price:{2} stock:{3} ", dr["id"], dr["name"], dr["price"], dr["stock"]);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        public void Delete(string id)
        {
            try
            {
                cmd = new SqlCommand("Delete from product where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();

                //SqlDataReader dr = cmd.ExecuteReader();//execute select statements
                //if (dr.HasRows)//check rows existensce
                //{
                //    dr.Read();//read only one record
                //    Console.WriteLine("ID:{0} Name:{1} price:{2} stock:{3} ", dr["id"], dr["name"], dr["price"], dr["stock"]);
                //}
                //else
                //    Console.WriteLine("Invalid projecr ID");
            }
      
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }



        public void Add(string id, string name, int price, int stock)
        {
            try
            {
                cmd = new SqlCommand("insert into product values(@id,@name,@price,@stock)", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                con.Open();//open connection
                cmd.ExecuteNonQuery();//execute query(dml)
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Update(string id, int price,int stock )
        {
            try
            {
                cmd = new SqlCommand("UPDATE product set price=@price,stock=@stock where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                con.Open();//open connection
                cmd.ExecuteNonQuery();//execute query(dml)
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        static void Main(string[] args)
        {

            Program obj = new Program();
            // obj.Add();
            //  obj.Get("p3");
            // obj.GetAll();
            // obj.Delete("p1");
            //obj.GetAll();
           // obj.Add("p4", "S", 456, 678);
            //obj.Add("p5", "V", 406, 608);
            //obj.GetAll();
            obj.Update("p4", 789, 123);
            obj.GetAll();
            Console.ReadKey();

        }
    }
    }

