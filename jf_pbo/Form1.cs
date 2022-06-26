namespace jf_pbo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_register(object sender, EventArgs e)
        {
            this.Hide();
            Register one = new Register();
            one.Show();
        }

        private void btn_login(object sender, EventArgs e)
        {
            this.Hide();
            Login two = new Login();
            two.Show();
        }

        private void btn_admin(object sender, EventArgs e)
        {
            this.Hide();
            Admin three = new Admin();
            three.Show();
        }
    }
}