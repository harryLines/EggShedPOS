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
    public partial class frmMain : Form
    {
        static Random random = new Random();
        public static int OrderID = random.Next(10000, 99999); //initializes the orderid variable, equal to a random number
        public frmMain()
        {
            InitializeComponent();

        }

        private void dateTimeLbl_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimeLbl.Text = DateTime.Now.ToShortTimeString(); //displays the current time in 00:00 format, updating every time the timer object ticks (every 1000ms)
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = $"SELECT OrderID FROM dbo.tblReceipt WHERE OrderID = {OrderID} "; //selects all past orders with this ID, (should be maximum 1 as this is a primary key)
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable ReceiptDT = new DataTable();

            while (ReceiptDT.Rows.Count != 0) //this while loop checks whether any orders in the receipt database table have the orderid assigned to the OrderID variable, and assigns a new one until it is unique
            {
                OrderID = random.Next(10000, 99999);
                query = $"SELECT * FROM dbo.tblLogin WHERE OrderID = {OrderID}";
                SDA.Fill(ReceiptDT);
            }




            EggsUserControl frmEgg = new EggsUserControl();
            frmEgg.Hide();
            MainTillUserControl frmMainTill = new MainTillUserControl();
            frmMainTill.Show();
            con.Close();
        }


    private void btnExit_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
        con.Open();
        string query3 = $"DELETE FROM tblCurrentOrder;";  //deletes all values from the current order
        SqlCommand myCommand = new SqlCommand(query3, con);
        myCommand.ExecuteNonQuery();
        con.Close();
        Application.Exit(); //the application is closed, stopping all processes
        }

    private void btnLogOut_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
        con.Open();
        string query3 = $"DELETE FROM tblCurrentOrder;"; //deletes all values from the current order
        SqlCommand myCommand = new SqlCommand(query3, con);
        myCommand.ExecuteNonQuery();
        con.Close();
        this.Hide();  
        Login frmLgn = new Login();    //the main form is hidden and the user is sent back to the login form
        frmLgn.Show();
    }

    private void userControl11_Load(object sender, EventArgs e)
    {
            //this loads the main till user control to the main form
    }
}
}
