using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void masuk_Click(object sender, EventArgs e)
        {
            if (nis.Text == "" || password.Text == "")
            {
                MessageBox.Show("Lengkapi data !");
            }
            else if (Login(nis.Text, password.Text) == true)
            {
                MessageBox.Show("Berhasil Masuk!", "Informasi");

                user u = new user();
                u.Show();
                this.Hide();

                string kiriman;
                kiriman = nis.Text;
            }
            else
            {
                MessageBox.Show("Username dan Password SALAH !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nis.Text = "";
                password.Text = "";
                nis.Focus();
            }
        }

        private Boolean Login(String nis, String password)
        {
            string host = "localhost";
            string user = "root";
            string pass = "";
            string DB = "db_login";
            string con = "server = " + host + ";database = " + DB + ";user = " + user + ";password = " + pass + ";";

            nis = nis.ToUpper();
            password = password.ToUpper();

            MySqlConnection koneksi = new MySqlConnection(con);

            koneksi.Open();
            MySqlCommand dbcmd = koneksi.CreateCommand();
            string sql = "SELECT nis, password FROM tb_user";
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

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            daftar d = new daftar();
            d.Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void angka(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
