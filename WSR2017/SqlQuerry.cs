using System;
using System.Data.SqlClient;

namespace WSR2017
{
    public class SqlQuerry
    {
        //TODO Trusted_Connection
        private SqlConnection connection = new SqlConnection("server=localhost;" +
                                                           "Trusted_Connection=yes;" +
                                                           "database=WSR2017; " +
                                                           "connection timeout=30");

        public Array SQlSelect(string sql,params string[] arg)
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

        public String SQLInsertInto(string sql)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sql;

            string outs = "";
            try
            {
                connection.Open();
                outs = Convert.ToString(command.ExecuteNonQuery());
            }
            catch (SqlException)
            {
                outs = null;
            }
            finally
            {
                connection.Close();
            }
            return outs;
        }
    }
}
