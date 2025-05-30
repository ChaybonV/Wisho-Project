using System;
using System.Data;
using System.Configuration;
using MySqlConnector;


namespace Wisho.DataAccess
{
    public class DBContext
    {
        private readonly MySqlConnection conn;

        public DBContext()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Wisho"].ConnectionString;
            conn = new MySqlConnection(connectionString);
        }

        // SELECT QUERY
        public DataTable ExecuteQuery(string commandText)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(commandText, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error when executing query", ex);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        // OTHER QUERY
        public int ExecuteNonQuery(string commandText)
        {
            int affectedRows = 0;
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(commandText, conn);
                affectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error when executing non-query", ex);
            }
            finally
            {
                conn.Close();
            }
            return affectedRows;
        }
    }
}