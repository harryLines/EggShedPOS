using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AbbeyFarmPOS
{
    public partial class EggsUserControl : UserControl
    {



        SqlDataAdapter SDA = new SqlDataAdapter();
        public EggsUserControl()
        {
            InitializeComponent();
        }

        private void EggsUserControl_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string query = $"SELECT ItemName, Price, QuantityInStock, ItemID FROM tblItems WHERE ItemType = 'Eggs'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable EggsDT = new DataTable();
            SDA.Fill(EggsDT);


            eggDG.DataSource = EggsDT;


            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainTillUserControl frmMainTill = new MainTillUserControl();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = $"SELECT tblItems.ItemID, tblItems.QuantityInStock, tblItems.ItemName, tblItems.Price, tblCurrentOrder.OrderID, tblCurrentOrder.ItemQuantity FROM tblItems INNER JOIN tblCurrentOrder ON tblItems.ItemID = tblCurrentOrder.ItemID";
            SDA = new SqlDataAdapter(query, con);
            DataTable CurrentOrderDT = new DataTable();
            SDA.Fill(CurrentOrderDT);

            frmMainTill.DGCurrentOrder.DataSource = CurrentOrderDT;

            frmMainTill.BringToFront();
            this.SendToBack();



        }

        private void eggDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       


        }



        private void eggDG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



            DataGridViewRow row = eggDG.Rows[e.RowIndex];
            var itemID = row.Cells[3].Value.ToString();
            string price = row.Cells[1].Value.ToString();
            decimal floatPrice = decimal.Parse(price); 
            decimal priceDec = decimal.Parse(price);
            priceDec = Math.Round(priceDec, 2); //this section gets the itemID and price of the row clicked to be assigned to variables

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            Random random = new Random();
            

            string query1 = $"SELECT ItemQuantity FROM tblCurrentOrder WHERE ItemID = '{itemID}'"; //selects the item quantity of the item selected
            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
            DataTable StockCount = new DataTable();
            SDA1.Fill(StockCount);


            eggDG.CurrentRow.Selected = true;

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
                string query3 = $"UPDATE tblCurrentOrder SET ItemQuantity = '{StockInt + 1}', TotalPrice = '{totalPrice}' WHERE ItemID = {itemID};"; //updates the record if item has already been added before
                SqlCommand myCommand = new SqlCommand(query3, con);
                myCommand.ExecuteNonQuery();
            }
            


            con.Close();

        }

        private void eggDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
