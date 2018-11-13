
using System;
using MySql.Data.MySqlClient;

namespace Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectStr = "server=168.33.162.63;port=3306;user=root;password=fairhr0755SZ; database=HealthCheck;";
            string sql = "select * from orders where id = '1997'";
            MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString("PeopleName");
                    Console.WriteLine(name);
                }


            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
