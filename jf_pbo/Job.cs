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
    public partial class Job : Form
    {
        public Job()
        {
            InitializeComponent();
        }

        private void btn_rgstr(object sender, EventArgs e)
        {
            int idd = int.Parse(textBox1.Text);
            string file = textBox2.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=jobpbo;Integrated Security=True");
            con.Open();
            string query = "update Record1 set Cv='" + file + "' where Id='" + idd + "'";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            this.Hide();
            Form1 eleven = new Form1();
            eleven.Show();
        }

        private void btn_browse(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "jpg";
            openFileDialog1.Filter = "Image files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if ((openFileDialog1.ShowDialog() == DialogResult.OK))
            {
                textBox2.Text = openFileDialog1.FileName;
            }
        }

        private void btn_kembali5(object sender, EventArgs e)
        {
            this.Hide();
            Login twelve = new Login();
            twelve.Show();
        }

        private void load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=jobpbo;Integrated Security=True");
            con.Open();
            string query = "Select Id,Deskripsi from Record1";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
