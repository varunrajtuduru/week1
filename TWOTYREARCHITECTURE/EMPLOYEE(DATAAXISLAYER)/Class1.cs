using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EMPLOYEE_DATAAXISLAYER_
{


    public class Employee
    {
        public int id;
        public string name, gender, location;
        public long salary;
   
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(" data source=IN5CG9214Z62 ; database=ADODEMO ; integrated security = true ");






        public int InsertNewEmployee(Employee employee)
        {
            
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_InsertNewEmployee";
            
            cmd.Parameters.AddWithValue("name", employee.name);
            cmd.Parameters.AddWithValue("gender", employee.gender);
            cmd.Parameters.AddWithValue("location", employee.location);
            cmd.Parameters.AddWithValue("salary", employee.salary);
            conn.Open();
            int rowcount = cmd.ExecuteNonQuery();
            conn.Close();
            return rowcount;
        }
        public int deleteemployee(Employee employee)
        {
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id",employee.id);
            
            cmd.CommandText = "sp_deleteEmployee";
           
            
            conn.Open();
            int rowcount = cmd.ExecuteNonQuery();
            conn.Close();
            return rowcount;
        }

        public int updateEmployee(Employee employee)
        {
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", employee.id);
            cmd.CommandText = "sp_updateEmployee";

            cmd.Parameters.AddWithValue("name", employee.name);
            cmd.Parameters.AddWithValue("gender", employee.gender);
            cmd.Parameters.AddWithValue("location", employee.location);
            cmd.Parameters.AddWithValue("salary", employee.salary);
            conn.Open();
            int rowcount = cmd.ExecuteNonQuery();
            conn.Close();
            return rowcount;


        }
        public void displayemployee(Employee employee)
        {
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_display";
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t\t{rdr[1]}\t\t{rdr["gender"]}\t\t{rdr["Location"]}\t\t{rdr["salary"]}");
            }

            conn.Close();

        }
        public void displayemploye(Employee employee)
        {
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_display";
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t\t{rdr[1]}\t\t{rdr["gender"]}\t\t{rdr["Location"]}\t\t{rdr["salary"]}");
            }

            conn.Close();

        }
        public void displayemploy(Employee employee)
        {
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
          
            cmd.CommandText = "sp_displayEmployee";
            cmd.Parameters.AddWithValue("id", employee.id);
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t\t{rdr[1]}\t\t{rdr["gender"]}\t\t{rdr["Location"]}\t\t{rdr["salary"]}");
            }

            conn.Close();

        }
    }
    }

