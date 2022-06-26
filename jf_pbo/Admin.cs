using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jf_pbo
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btn_kembali3(object sender, EventArgs e)
        {
            this.Hide();
            Form1 nine = new Form1();
            nine.Show();
        }

        private void btn_adlogin(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            int password = int.Parse(textBox2.Text);
            if (nama == "admin" && password == 12345)
            {
                int.Parse(textBox2.Text);
                this.Hide();
                enter_job eight = new enter_job();
                eight.Show();
            }
            else
            {
                MessageBox.Show("nama atau password salah");
            }
        }
    }
}
