using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class retrive
    {
        static void Main(string[] args)
        {
            string ConString = @" Data Source=sravaniVM;Initial Catalog=Employee;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            string querystring = "Select * from Employee_tb";
            con.Open();
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
        }
    }
}
