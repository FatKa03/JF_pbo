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
    public partial class enter_job : Form
    {
        public enter_job()
        {
            InitializeComponent();
        }

        private void btn_addjob(object sender, EventArgs e)
        {
            string deskripsi = textBox1.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=jobpbo;Integrated Security=True");
            con.Open();
            string query1 = "insert into Record1(Deskripsi)values('" + deskripsi + "')";
            SqlCommand cmd = new SqlCommand(query1, con);
            cmd.ExecuteNonQuery();
          
        }

        private void btn_display(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=jobpbo;Integrated Security=True");
            con.Open();
            string query = "select *from Record1";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void btn_kembali4(object sender, EventArgs e)
        {
            this.Hide();
            Admin ten = new Admin();
            ten.Show();
        }
    }
}
