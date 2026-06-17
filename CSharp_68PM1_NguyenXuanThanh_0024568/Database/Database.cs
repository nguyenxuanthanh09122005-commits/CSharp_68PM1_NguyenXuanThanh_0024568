using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace CSharp_68PM1_NguyenXuanThanh_0024568.Database
{
    public class Database
    {
        string strCon = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(strCon);
        }

        public DataTable GetTable(string sql, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlDataAdapter ad = new MySqlDataAdapter(sql, conn);
                if (parameters != null) ad.SelectCommand.Parameters.AddRange(parameters);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
        }

        public void Execute(string sql, MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public object GetValue(string sql, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}