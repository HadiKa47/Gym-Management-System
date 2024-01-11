namespace Gym_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UidTB.Text = "";
            PassTB.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UidTB.Text == "" || PassTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (UidTB.Text == "Admin" && PassTB.Text == "Admin")
            {
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong ID or Password Please Try Again");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}