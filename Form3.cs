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
    public partial class VerifyAdmin : Form
    {
        public VerifyAdmin()
        {
            InitializeComponent();
        }

        private void VerifyAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = $"SELECT IsAdmin,Password FROM dbo.tblLogin WHERE UserID = '{userIDTxtBox.Text.Trim()}' AND Password = '{passwordTextBox.Text}'"; //selects the record matching the userID and password, if it is valid
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable UsersDT = new DataTable();
            SDA.Fill(UsersDT);
            if(UsersDT.Rows.Count == 1)
            {
                string password = UsersDT.Rows[0]["Password"].ToString();
                string isTrue = UsersDT.Rows[0]["IsAdmin"].ToString();  //if the "IsAdmin" boolean column is true, this variable is true
                if (isTrue == "True") //checks whether the userid entered has admin privileges
                {

                    frmNewUser frmNU = new frmNewUser();
                    frmNU.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("ID or password is not valid", "Verification Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Account with this info does not exist", "Verification Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }





        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
