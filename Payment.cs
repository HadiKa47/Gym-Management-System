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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\itm\Documents\GymDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillName()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MName FROM MemberTbl", Con);
                SqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("MName", typeof(string));
                dt.Load(rdr);

                NameCB.ValueMember = "MName";
                NameCB.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Handle the exception (log, display error message, etc.)
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close(); // Close the connection in the finally block
                }
            }
        }

        private void filterByName()
        {
            Con.Open();
            string query = "select * from PaymentTbl where PMember = '"+SearchName.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from PaymentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AmountTB.Text = "";
            
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            FillName();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NameCB.Text == "" || AmountTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string payperiode = Periode.Value.Month.ToString() + Periode.Value.Year.ToString();
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM PaymentTbl WHERE PMember ='" + NameCB.SelectedValue.ToString() + "'and PMonth='" + payperiode + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Already Paid For This Month");
                }
                else
                {
                    // Assuming 'MAmount' is the correct column name for the amount
                    string query = "INSERT INTO PaymentTbl VALUES ('" + payperiode + "','" + NameCB.SelectedValue.ToString() + "'," + AmountTB.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Paid Successfully");
                }

                Con.Close();
                populate();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            filterByName();
            SearchName.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
