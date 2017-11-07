using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TestSql
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("server=localhost;" +
            "Trusted_Connection=yes;" +
            "database=WSR2017; " +
            "connection timeout=30");
            
            string login = "125";
            string password = "556";

            string sql = String.Format("INSERT INTO [dbo].[User] ([login] ,[password] ,[role]) VALUES ('{0}','{1}','0')",
                login, password);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sql;

            try
            {
                connection.Open();
                int reader = command.ExecuteNonQuery();


                    Console.WriteLine(reader);
            }
            catch (SqlException)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
