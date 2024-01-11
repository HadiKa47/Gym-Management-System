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

namespace Gym_Management_System
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\itm\Documents\GymDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {

                    Con.Open();
                    string query = "INSERT INTO MemberTbl (MName, MPhone, MGen, MAge, MAmount, MTiming) " +
                                    "VALUES (@MName, @MPhone, @MGen, @MAge, @MAmount, @MTiming)";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        // Assuming Con is your SqlConnection object
                        cmd.Parameters.AddWithValue("@MName", NameTb.Text);
                        cmd.Parameters.AddWithValue("@MPhone", PhoneTb.Text);
                        cmd.Parameters.AddWithValue("@MGen", GenderCB.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@MAge", AgeTb.Text);
                        cmd.Parameters.AddWithValue("@MAmount", AmountTb.Text);
                        cmd.Parameters.AddWithValue("@MTiming", TimingCB.SelectedItem.ToString());


                        cmd.ExecuteNonQuery();

                        // show a Message and Close the connection after executing the command 
                        MessageBox.Show("Member Successful Adedd");
                        AmountTb.Text = "";
                        AgeTb.Text = "";
                        NameTb.Text = "";
                        PhoneTb.Text = "";
                        GenderCB.Text = "";
                        TimingCB.Text = "";

                        
                        Con.Close();

                    }
                    
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "";
            AgeTb.Text = "";
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCB.Text = "";
            TimingCB.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {
            if (PhoneTb.Text != 18)
            { 
            }
        }
    }
}
