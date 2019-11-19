using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FantasySports.DataAccess
{
    public class StoredProcedures
    {
        public static DataTable getRowsFromSproc(String sprocName)
        {
            

            string connectionString = ConfigurationManager.ConnectionStrings["ADOString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sprocName, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(rdr);               

                return table;
            }
        }

        public static DataTable getRowsFromSproc(String sprocName, SqlParameter[] parameters)
        {


            string connectionString = ConfigurationManager.ConnectionStrings["ADOString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sprocName, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }

                connection.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(rdr);

                return table;
            }
        }
    }
}