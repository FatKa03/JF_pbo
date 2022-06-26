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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_kembali2(object sender, EventArgs e)
        {
            this.Hide();
            Form1 seven = new Form1();
            seven.Show();
        }

        private void btn_login(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Masukkan email dan password");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=jobpbo;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select Count(*) from Sign_up where Email='"+textBox1.Text+"'and Password='"+textBox2.Text+"'",con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Job six = new Job();
                    six.Show();
                    six.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
