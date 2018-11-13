using MySql.Data.MySqlClient;
using System;


namespace Connection
{
    public static class MysqlHelper
    {
        public static void Connect()
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
                    string s  = reader.GetEnumerator().ToString();
                    Console.WriteLine(name + s);
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
