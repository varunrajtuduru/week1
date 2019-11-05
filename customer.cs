using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace assessment5
{


    public class Customer
    {
        public int supplierid,productid,numberofproducts;
        public string customername;
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(" data source=IN5CG9214Z62 ; database=assessment5 ; integrated security = true ");

        public int InsertNewCustomer(Customer custom)
        {

            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_InsertNewCustomer";

            cmd.Parameters.AddWithValue("customername", custom.customername);
            cmd.Parameters.AddWithValue("productid", custom.productid);
            cmd.Parameters.AddWithValue("supplierid", custom.supplierid);
           
           
            cmd.Parameters.AddWithValue("numberofproducts", custom.numberofproducts);
         
            conn.Open();
            int rowcount = cmd.ExecuteNonQuery();
            conn.Close();
            return rowcount;
        }
        public void displaycustomer(Customer customer)
        {
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_display";
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t\t{rdr[1]}\t\t{rdr[2]}\t\t{rdr[3]}\t\t{rdr[4]}");
            }

            conn.Close();

        }

    }
} 
