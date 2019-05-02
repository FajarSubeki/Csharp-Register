using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Register
{
    class koneksi
    {
        public Boolean Login(String nis, String password)
        {
            string host = "localhost";
            string pass = "";
            string user = "root";
            string DB = "db_login";
            string con = "server =" + host + ";database" + DB + ";user" + user + ";password" + pass + ";";

            nis = nis.ToUpper();
            password = password.ToUpper();

            MySqlConnection koneksi = new MySqlConnection(con);
            koneksi.Open();
            MySqlCommand dbcmd = koneksi.CreateCommand();
            string sql = "select username,password from tb_user";
            dbcmd.CommandText = sql;
            MySqlDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                if ((reader.GetString(0).ToString().ToUpper() == nis) && (reader.GetString(1).ToString().ToUpper() == password))
                {
                    return true;
                }
            }
            koneksi.Close();
            return false;
        }
    }
}
