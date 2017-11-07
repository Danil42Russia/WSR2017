using System;
using System.Data.SqlClient;

namespace TestSql
{
    public class Test
    {
        //TODO Trusted_Connection
        private SqlConnection connection = new SqlConnection("server=localhost;" +
                                                             "Trusted_Connection=yes;" +
                                                             "database=WSR2017; " +
                                                             "connection timeout=30");

        public Array Query(string sql, params string[] arg)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sql;

            int argLen = arg.Length;

            string[] outs = new string[argLen];

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < argLen; i++)
                    {
                        outs[i] = reader[arg[i]].ToString();
                    }
                }
            }
            catch (SqlException)
            {
                outs[0] = null;
            }
            finally
            {
                connection.Close();
            }
            return outs;
        }
    }
}
