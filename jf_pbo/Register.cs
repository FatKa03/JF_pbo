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

namespace jf_pbo
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_kembali(object sender, EventArgs e)
        {
            this.Hide();
            Form1 five = new Form1();
            five.Show();
        }

        private void btn_sign(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;
            int nomor = int.Parse(textBox4.Text);
            string alamat = textBox5.Text;


            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=jobpbo;Integrated Security=True");
                con.Open();
                string query = "Insert into Sign_up(Nama,Email,Password,Nomor,Alamat) values('" + nama + "','" + email + "','" + password + "','" + nomor + "','" + alamat + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registrasi Berhasil");
                this.Hide();
                Job four = new Job();
                four.Show();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Registrasi Gagal");
            }

        }
    }
}
