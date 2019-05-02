using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Register
{
    public partial class daftar : Form
    {
        public daftar()
        {
            InitializeComponent();
        }

        private void daftar_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void daftar_Click(object sender, EventArgs e)
        {
            if (nis.Text == "" || nama.Text == "" || rombel.Text == "" || rayon.Text == "" || password.Text == "")
            {
                MessageBox.Show("Lengkapi data terlebih dahulu ! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                string host = "localhost";
                string pass = "";
                string user = "root";
                string DB = "db_login";
                string con = "server =" + host + ";database=" + DB + ";user=" + user + ";password=" + pass + ";";

                MySqlConnection koneksi = new MySqlConnection(con);

                koneksi.Open();

                MySqlCommand dbcmd = koneksi.CreateCommand();
                string sql = "insert into tb_user(nis,nama,rombel,rayon,password) VALUES ('" + nis.Text + "','" + nama.Text + "','" + rombel.Text 
                    + "','" + rayon.Text + "','" + password.Text + "')";
                dbcmd.CommandText = sql;
                dbcmd.ExecuteNonQuery();

                MessageBox.Show("Akun berhasil di buat ", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
                   
                }

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
            Form1 f1 = new Form1();
            f1.Show();
        }
            
         
        }

    }

