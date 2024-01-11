using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\itm\Documents\GymDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from MemberTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int Key = 0;
        private void MemberSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Key = Convert.ToInt32(MemberSDGV.SelectedRows[0].Cells[0].Value.ToString());
            NameTB.Text = MemberSDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTB.Text = MemberSDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderCB.Text = MemberSDGV.SelectedRows[0].Cells[3].Value.ToString();
            AgeTB.Text = MemberSDGV.SelectedRows[0].Cells[4].Value.ToString();
            AmountTB.Text = MemberSDGV.SelectedRows[0].Cells[5].Value.ToString();
            TimingCB.Text = MemberSDGV.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameTB.Text = "";
            PhoneTB.Text = "";
            AmountTB.Text = "";
            AgeTB.Text = "";
            GenderCB.Text = "";
            TimingCB.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Member To Be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from MemberTbl where Mid=" + Key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Deleted Successfuly");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Key == 0 || NameTB.Text == "" || PhoneTB.Text == "" || AgeTB.Text == "" || AmountTB.Text == "" || GenderCB.Text == "" || TimingCB.Text == "") 
            {
                MessageBox.Show("Mising Informtion");
            }
            else
            {
                try
                {
                    string query = "UPDATE MemberTbl SET MName = @Name, MPhone = @Phone, MGen = @Gender, MAge = @Age, MAmount = @Amount, MTiming = @Timing where Mid=" + Key + ";";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@Name", NameTB.Text);
                        cmd.Parameters.AddWithValue("@Phone", PhoneTB.Text);
                        cmd.Parameters.AddWithValue("@Gender", GenderCB.Text);
                        cmd.Parameters.AddWithValue("@Age", AgeTB.Text);
                        cmd.Parameters.AddWithValue("@Amount", AmountTB.Text);
                        cmd.Parameters.AddWithValue("@Timing", TimingCB.Text);
                        MessageBox.Show("Member Update Successfuly");
                        Con.Open();
                        cmd.ExecuteNonQuery();
                        Con.Close();
                        populate();
                    }

                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
