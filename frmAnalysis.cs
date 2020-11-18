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
    public partial class frmAnalysis : Form
    {
        public frmAnalysis()
        {
            InitializeComponent();
        }

        private void frmAnalysis_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query1 = $"SELECT * FROM tblItems";
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA = new SqlDataAdapter(query1, con);
            DataTable ItemAnalysisDT = new DataTable();
            SDA.Fill(ItemAnalysisDT);

            ItemAnalysisDT.Columns.Add("TotalCash", typeof(float));

            foreach (DataRow row in ItemAnalysisDT.Rows)
            {
                row["TotalCash"] = Math.Round((float.Parse((row["Price"]).ToString())) * (float.Parse((row["QuantitySold"]).ToString())), 2);
            }
            DGItemsAnalysis.DataSource = ItemAnalysisDT;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable ItemAnalysisModifiedDT = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter SDA = new SqlDataAdapter();

            string sortByMode = "ASC";

            if (sortByComboBox.SelectedIndex == -1 | sortByComboBox.SelectedIndex == 0)
            {
                sortByMode = "";
            } 
            else
            {

                if (sortByComboBox.SelectedItem.ToString() == "Best Selling")
                {
                    sortByMode = "ORDER BY QuantitySold DESC";
                }
                else if (sortByComboBox.SelectedItem.ToString() == "Worst Selling")
                {
                    sortByMode = "ORDER BY QuantitySold ASC";
                }
                else if (sortByComboBox.SelectedItem.ToString() == "Out Of Stock")
                {
                    sortByMode = "AND QuantityInStock=0";
                }

            }


            string boxesChecked = "ItemType=";

            int boxesCheckedCount = 0;

            if (checkboxEggs.Checked == true)
            {
                boxesChecked += "'Eggs'";
                boxesCheckedCount += 1;
            }
            if (checkboxBread.Checked == true & boxesCheckedCount >= 1)
            {
                boxesChecked += " OR ItemType='Bread'";
                boxesCheckedCount += 1;
            }
            else if (checkboxBread.Checked == true)
            {
                boxesChecked += "'Bread'";
                boxesCheckedCount += 1;
            }
            if (checkboxMilk.Checked == true & boxesCheckedCount >= 1)
            {
                boxesChecked += " OR ItemType='Milk'";
                boxesCheckedCount += 1;
            }
            else if (checkboxMilk.Checked == true)
            {
                boxesChecked += "'Milk'";
                boxesCheckedCount += 1;
            }
            if (checkboxHoney.Checked == true & boxesCheckedCount >= 1)
            {
                boxesChecked += " OR ItemType='Honey'";
                boxesCheckedCount += 1;
            }
            else if (checkboxHoney.Checked == true)
            {
                boxesChecked += "'Honey'";
                boxesCheckedCount += 1;
            }
            if (checkboxSpreads.Checked == true & boxesCheckedCount >= 1)
            {
                boxesChecked += " OR ItemType='Spread'";
                boxesCheckedCount += 1;
            }
            else if (checkboxSpreads.Checked == true)
            {
                boxesChecked += "'Spread'";
                boxesCheckedCount += 1;
            }


            if (boxesCheckedCount > 0)
            {
                string query2 = $"SELECT * FROM tblItems WHERE ({boxesChecked}){sortByMode};";
                SDA = new SqlDataAdapter(query2, con);
                
                SDA.Fill(ItemAnalysisModifiedDT);
                ItemAnalysisModifiedDT.Columns.Add("TotalCash", typeof(float));

                foreach (DataRow row in ItemAnalysisModifiedDT.Rows)
                {
                    row["TotalCash"] = Math.Round((float.Parse((row["Price"]).ToString())) * (float.Parse((row["QuantitySold"]).ToString())), 2);
                }

                DGItemsAnalysis.DataSource = ItemAnalysisModifiedDT;

            }
            else
            {
                ItemAnalysisModifiedDT = null;
                boxesChecked = "";
                SDA.Fill(ItemAnalysisModifiedDT);
                DGItemsAnalysis.DataSource = ItemAnalysisModifiedDT;
            }


        }

        private void forenameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new System.Random(); //initializing a new "random" object, allowing for random numbers to be created
            int randomNum = random.Next(10000, 99999);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();


            string query = $"SELECT * FROM dbo.tblItems WHERE ItemID = {randomNum}"; //this string variable must be intialized to equal our SQL query


            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable ItemsDT = new DataTable();
            while (ItemsDT.Rows.Count != 0) // this while loop keeps assigning a random number to the UserID until it is one that has not been used
            {
                randomNum = random.Next(10000, 99999); //the randomNum variable is assigned a random number between 10000 and 99999 (to preserve 5 digit format)
                query = $"SELECT * FROM dbo.tblLogin WHERE UserID = {randomNum}"; //selects all from the rows which userID is equal to our random number
                SDA.Fill(ItemsDT); //fills the c# datatable with this data (if any are found)
            }

            if (comboBoxItemType.SelectedIndex == -1 | txtBoxItemName == null | txtBoxPrice == null | txtBoxQuantityInStock == null | txtBoxUserID == null | txtBoxPassword == null)
            {
                MessageBox.Show("There are empty fields - all fields must contain a value to create an item", "Item Creation Error", MessageBoxButtons.OK);
            }
            else
            {
                string query3 = $"SELECT * FROM dbo.tblLogin WHERE UserID = '{txtBoxUserID.Text.Trim()}' AND Password = '{txtBoxPassword.Text.Trim()}' AND IsAdmin = True";  //this query selects all records that contain this matching login
                SqlDataAdapter SDA2 = new SqlDataAdapter(query3, con);
                DataTable UsersDT = new DataTable();

                if ((txtBoxUserID.Text != "") & (txtBoxPassword.Text != "")) // checks the user has entered information into both boxs
                {
                    SDA2.Fill(UsersDT);
                    if (UsersDT.Rows.Count == 1) //if a record is found with this username and password, the item creation is processed
                    {

                        string queryItemExistsCheck = $"SELECT * FROM dbo.tblItems WHERE ItemName = '{txtBoxItemName.Text.Trim()}'";  //this query selects all records that contain this matching login
                        SqlDataAdapter SDA3 = new SqlDataAdapter(queryItemExistsCheck, con);
                        DataTable ItemExistsCheckDT = new DataTable();
                        SDA3.Fill(ItemExistsCheckDT);

                        if (ItemExistsCheckDT.Rows.Count == 0) //if a record is found with this name already, the item creation is denied
                        {

                            string query2 = $"INSERT INTO tblItems (ItemID, Price, QuantityInStock, ItemName, ItemType) VALUES('{randomNum}', '{float.Parse(txtBoxPrice.Text)}', '{int.Parse(txtBoxQuantityInStock.Text)}', '{txtBoxItemName.Text}', '{comboBoxItemType.SelectedItem.ToString()}'); "; //inserts a new record into the "TblItems" database table
                            SqlCommand myCommand = new SqlCommand(query2, con);
                            myCommand.ExecuteNonQuery();
                            txtBoxItemName.Text = "";
                            txtBoxPrice.Text = "";
                            txtBoxQuantityInStock.Text = "";
                            comboBoxItemType.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Item Already Exists", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  //displays an error if the login is invalid
                    }
                } else
                {
                    MessageBox.Show("Invalid Login", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  //displays an error if the login is invalid
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login(); //if the "back" button is pressed, this form is hidden and the login form is once again displayed
            frmLogin.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string query = $"UPDATE tblItems SET QuantityInStock = QuantityInStock + {numericUpDownRestock.Value} WHERE ItemID = {int.Parse(txtBoxItemIDRestock.Text)}"; //updates the stock count of the item matching the input item ID, to the current value plus the value selected in the updown number box
            SqlCommand myCommand = new SqlCommand(query, con);
            myCommand.ExecuteNonQuery();

            lblItemRestocked.Visible = true;
            itemRestockedTimer.Enabled = true;

            numericUpDownRestock.Value = 0;
            txtBoxItemIDRestock.Text = "";


        }

        private void timerRestockTick(object sender, EventArgs e)
        {
            lblItemRestocked.Visible = false;
            itemRestockedTimer.Enabled = false;
        }
    }
}
