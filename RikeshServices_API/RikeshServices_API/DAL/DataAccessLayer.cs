using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using RikeshServices_API.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;



namespace RikeshServices_API.DAL
{
    public class DataAccessLayer
    {
        SqlConnection conn;
        string ConnectionString = string.Empty;
        public DataAccessLayer()
        {
            ConnectionString = "Data Source=sgirdb017v.cmkmodxnbj0u.eu-west-1.rds.amazonaws.com;Initial Catalog=SGDB; User=A12142;Password=iprdatabase123;";
            conn = new SqlConnection(ConnectionString);
        }
        public int InsertStudentDetails(Student std)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertStdDetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sid", std.StdID);
            cmd.Parameters.AddWithValue("@stdName", std.StdName);
            cmd.Parameters.AddWithValue("@stdAddress", std.StdAddress);
            cmd.Parameters.AddWithValue("@stdClass", std.stdClass);
            cmd.Parameters.AddWithValue("@stdMobile", std.StdMobile);
            cmd.Parameters.AddWithValue("@stdEmail", std.StdEmail);
            conn.Open();
            int k= cmd.ExecuteNonQuery();

            if (k!=0)
            {
              return 1;
            }
            conn.Close();
            return 0;
        
        }   
    }
}
