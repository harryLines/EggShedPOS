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
    public partial class BreadUserControl : UserControl
    {
        frmMain mainForm;

        SqlDataAdapter SDA = new SqlDataAdapter();

        public BreadUserControl()
        {
            InitializeComponent();
        }

        private void BreadUserControl_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string query = $"SELECT ItemName, Price, QuantityInStock, ItemID FROM tblItems WHERE ItemType = 'Bread'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable breadDT = new DataTable();
            SDA.Fill(breadDT);


            breadDG.DataSource = breadDT;


            con.Close();
        }

        private void breadDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void breadDG_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



            DataGridViewRow row = breadDG.Rows[e.RowIndex];
            var itemID = row.Cells[3].Value.ToString();
            string price = row.Cells[1].Value.ToString();
            decimal floatPrice = decimal.Parse(price);
            decimal priceDec = decimal.Parse(price);
            if (int.Parse(row.Cells[2].Value.ToString()) == 0)
            {
                MessageBox.Show("Out Of Stock", "Sorry This Item Is Out Of Stock", MessageBoxButtons.OK);
            }
            else
            {



                priceDec = Math.Round(priceDec, 2); //this section gets the itemID and price of the row clicked to be assigned to variables

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                Random random = new Random();


                string query1 = $"SELECT ItemQuantity FROM tblCurrentOrder WHERE ItemID = '{itemID}' AND OrderID = {frmMain.OrderID}"; //selects the item quantity of the item selected
                SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
                DataTable StockCount = new DataTable();
                SDA1.Fill(StockCount);


                breadDG.CurrentRow.Selected = true;

                if (StockCount.Rows.Count == 0)
                {

                    string query2 = $"INSERT INTO tblCurrentOrder VALUES('{itemID}', '{frmMain.OrderID}', 1, '{priceDec}' ); "; //inserts a new record for an added item, if it is the first time it has been added

                    SqlCommand myCommand = new SqlCommand(query2, con);
                    myCommand.ExecuteNonQuery();

                }
                else if (StockCount.Rows.Count > 0)
                {
                    int StockInt = Convert.ToInt32((StockCount.Rows[0]["ItemQuantity"])); //selects the item quantity that is in the order
                    decimal totalPrice = (floatPrice * StockInt) + floatPrice; //calculates the total price of the row, based on how many of that item have been selected
                    totalPrice = Math.Round(totalPrice, 2);
                    string query3 = $"UPDATE tblCurrentOrder SET ItemQuantity = '{StockInt + 1}', ItemTotalPrice = '{totalPrice}' WHERE ItemID = {itemID} AND OrderID = {frmMain.OrderID};"; //updates the record if item has already been added before
                    SqlCommand myCommand = new SqlCommand(query3, con);
                    myCommand.ExecuteNonQuery();
                }



                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string query = $"SELECT ItemName, Price, QuantityInStock, ItemID FROM tblItems WHERE ItemName LIKE '%{txtBoxSearch.Text}%' AND ItemType = 'Bread'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable breadDT = new DataTable();
            SDA.Fill(breadDT);


            breadDG.DataSource = breadDT;


            con.Close();
        }
    }
}
