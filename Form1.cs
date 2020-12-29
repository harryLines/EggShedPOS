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

namespace AbbeyFarmPOS
{
    public partial class Login : Form
    {
        public static frmMain Main = new frmMain();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passwordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = $"SELECT * FROM dbo.tblLogin WHERE UserID = '{userIDTxtBox.Text.Trim()}' AND Password = '{passwordTxtBox.Text.Trim()}'";  //this query selects all records that contain this matching login
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable UsersDT = new DataTable();

            if ((userIDTxtBox.Text != "") & (passwordTxtBox.Text != "")) // checks the user has entered information into both boxs
            {
                try
                {
                    SDA.Fill(UsersDT);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Input", "Input Error", MessageBoxButtons.OK);
                    return;
                }

                if (UsersDT.Rows.Count == 1) //if a record is found with this username and password, the main till form is opened
                {
                    Main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login", "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);  //displays an error if the login is invalid
                }
            }
             else if (userIDTxtBox.Text == "")
            {
                MessageBox.Show("You must enter a UserID", "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); //displays an error if the userid is blank
            } else if (passwordTxtBox.Text == "")
            {
                MessageBox.Show("You must enter a Password", "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); //displays an error if the password is blank
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerifyAdmin frmVerify = new VerifyAdmin(); //displays the admin verification window
            frmVerify.Show();
            Login frmLgn = new Login();
            frmLgn.Hide();



            

        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            frmAnalysis frmAnalysis = new frmAnalysis();
            frmAnalysis.Show();
            this.Hide();
        }
    }
}
