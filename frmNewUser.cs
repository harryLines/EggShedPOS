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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            lblUserCreated.Hide();
            lblSuccessfulCreation.Hide();
            btnContinue.Hide();
            lblUserID.Hide();
            lblYourUserID.Hide();



        }

        private void lblForename_Click(object sender, EventArgs e)
        {

        }

        private void lblSurname_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login(); //if the "back" button is pressed, this form is hidden and the login form is once again displayed
            frmLogin.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            Random random = new System.Random(); //initializing a new "random" object, allowing for random numbers to be created
            int randomNum = 0;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();


            string query = $"SELECT * FROM dbo.tblLogin WHERE UserID = {randomNum}"; //this string variable must be intialized to equal our SQL query


            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable UsersDT = new DataTable();
            while (UsersDT.Rows.Count != 0) // this while loop keeps assigning a random number to the UserID until it is one that has not been used
            {
                randomNum = random.Next(10000, 99999); //the randomNum variable is assigned a random number between 10000 and 99999 (to preserve 5 digit format)
                query = $"SELECT * FROM dbo.tblLogin WHERE UserID = {randomNum}"; //selects all from the rows which userID is equal to our random number
                SDA.Fill(UsersDT); //fills the c# datatable with this data (if any are found)
            }
        


            randomNum = random.Next(10000, 99999);
            string query2 = $"INSERT INTO tblLogin (UserID, Password, Forename, Surname, isAdmin) VALUES('{randomNum}', '{passwordTxt.Text}', '{forenameTxt.Text}', '{surnameTxt.Text}', '{isAdminCheckBox.Checked}'); "; //inserts a new record into the "TblLogin" database table
            SqlCommand myCommand = new SqlCommand(query2, con);
            myCommand.ExecuteNonQuery();


            lblAddNewUser.Hide();
            lblForename.Hide();
            lblSurname.Hide();
            lblPassword.Hide();
            lblIsAdmin.Hide();
            forenameTxt.Hide();
            surnameTxt.Hide();
            passwordTxt.Hide();
            FNLine.Hide();
            SNLine.Hide();
            PWLine.Hide();
            UserIcon.Hide();
            isAdminCheckBox.Hide();
            btnCreate.Hide();

            lblUserCreated.Show();
            lblSuccessfulCreation.Show();
            btnContinue.Show();        
            lblYourUserID.Show();

            lblUserID.Text = randomNum.ToString();


            lblUserID.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm1Load = new Login();
            frm1Load.Show();
        }
    }
}
