using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoD1.Models
{
    internal class DBLayer
    {
       public static DataTable DQL(string query)
        {

            SqlConnection con = new SqlConnection("Data Source=MUSTAFA7EGAZI;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        public static int DML(string query)
        {
            SqlConnection con = new SqlConnection("Data Source=MUSTAFA7EGAZI;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int roweffect = cmd.ExecuteNonQuery();
            con.Close();
             return roweffect;
        }
    }
}
