using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class SqlRepository:IRepository
    {
        ObjectCache cache = MemoryCache.Default;

        public void Add(IProduct product,int fare)
        {
            History.Instance.AddToLogFile("Adding Product Details to Database.");
            SqlConnection connectionobject = new SqlConnection();
            
            connectionobject.ConnectionString = "Data Source=TAVDESK087;Initial Catalog=Product;Integrated Security=True";
            connectionobject.Open();
            string query = "insert into " +product.ProductType+" values(@name,@fare,@isbooked)";
            SqlCommand cmd = new SqlCommand(query,connectionobject);
            cmd.Parameters.Add(new SqlParameter("@name", product.ProductName));
            cmd.Parameters.Add(new SqlParameter("@fare",fare));
            cmd.Parameters.Add(new SqlParameter("@isbooked", product.IsBooked));


            cmd.ExecuteNonQuery();
            connectionobject.Close();
        }

        public void Get(IProduct product )

        { 
            //if (cache.Contains(product.ProductType))
            //{

            //    IProduct refobject = cacheobject.getFromCache(product.ProductType,product);
            //    Console.WriteLine(refobject.ProductName);
            //    Console.WriteLine(refobject.IsBooked);
            //    Console.WriteLine(refobject.fare);
            //}
            //else
            //{
               // cacheobject.AddtoCache(product.ProductType,product);
                SqlConnection connectionobject = new SqlConnection();

                connectionobject.ConnectionString = "Data Source=TAVDESK087;Initial Catalog=Product;Integrated Security=True";
                connectionobject.Open();
                string query = "Select * from " + product.ProductType;
                SqlCommand cmd = new SqlCommand(query, connectionobject);
                SqlDataReader datareader = cmd.ExecuteReader();
                while (datareader.Read())
                {
                    Console.WriteLine(datareader["ProductName"].ToString());
                    Console.WriteLine(datareader["ProductFare"].ToString());
                    Console.WriteLine(datareader["IsBooked"].ToString());
                }



                connectionobject.Close();
            //}
            

        }



        
    }
}
