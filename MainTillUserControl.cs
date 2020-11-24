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
    public partial class w : UserControl
    {
        EggsUserControl eggFrm = new EggsUserControl();

        public static DataTable CurrentOrderDT;
        SqlDataAdapter SDA1 = new SqlDataAdapter();
        SqlDataAdapter SDA2 = new SqlDataAdapter();
        public w()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            DGCurrentOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //when a user clicks a cell in the datagrid, it selects the whole row
            DGCurrentOrder.DataSource = CurrentOrderDT; //assigns the datagrid source to be the current order datatable
        }

        private void btnEggs_Click(object sender, EventArgs e)
        {
            this.SendToBack(); //sends the user control to the back

            eggFrm.Show(); //displays the egg user control


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private bool voidClicked = false;

        private void button2_Click(object sender, EventArgs e)
        {
            voidClicked = true; //if the "void selected items" button is clicked
            int rowIndex = DGCurrentOrder.CurrentCell.RowIndex;


            DataGridViewRow row = DGCurrentOrder.Rows[rowIndex];
            string itemIDStr = row.Cells["ItemID"].Value.ToString();

            int itemIDInt = int.Parse(itemIDStr); //the itemid in the row clicked is assigned to a variable 


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query3 = $"DELETE FROM tblCurrentOrder WHERE ItemID = '{itemIDInt}';"; //the row selected is deleted from the table
            SqlCommand myCommand = new SqlCommand(query3, con);
            myCommand.ExecuteNonQuery();
            con.Close();

            DGCurrentOrder.Rows.RemoveAt(rowIndex); //the datagrid has the row removed
            voidClicked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (voidClicked == false) //updates the datagrid every time the timer ticks (every 5000ms)
            {
                SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
                string query1 = $"SELECT tblItems.ItemID, tblItems.ItemName, tblItems.Price, tblCurrentOrder.ItemQuantity FROM tblItems INNER JOIN tblCurrentOrder ON tblItems.ItemID = tblCurrentOrder.ItemID WHERE OrderID = {frmMain.OrderID}";
                SDA1 = new SqlDataAdapter(query1, con1);
                DataTable CurrentOrderDT = new DataTable();
                SDA1.Fill(CurrentOrderDT);
                DGCurrentOrder.DataSource = CurrentOrderDT;

                if ((CurrentOrderDT.Rows.Count > 0))
                {
                    SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
                    string query2 = $"SELECT SUM(ItemTotalPrice) FROM tblCurrentOrder WHERE OrderID = {frmMain.OrderID};"; //selects the sum of all the price values
                    SDA2 = new SqlDataAdapter(query2, con2);
                    DataTable TotalPriceDT = new DataTable();
                    SDA2.Fill(TotalPriceDT); 



                    string priceStr = TotalPriceDT.Rows[0][0].ToString();

                    decimal priceDec = decimal.Parse(priceStr);

                    priceDec = Math.Round(priceDec, 2); //the number is rounded to 2 decimal places, as currency cannot have more than 2

                    priceStr = priceDec.ToString();

                    lblTotalPrice.Text = "£" + priceStr; //the total price is displayed 

                } else
                {
                    lblTotalPrice.Text = "£0.00"; //if there are no items in the datagrid, the price is automatically set to £0
                }
            }

        }

        private void timerTotalPrice_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query1 = $"SELECT tblItems.ItemID, tblItems.QuantityInStock, tblItems.ItemName, tblItems.Price, tblCurrentOrder.OrderID, tblCurrentOrder.ItemQuantity FROM tblItems INNER JOIN tblCurrentOrder ON tblItems.ItemID = tblCurrentOrder.ItemID WHERE OrderID = {frmMain.OrderID}"; //inner join to create a table based on the current order, containing all the data needed for the payment form receipt process
            SDA1 = new SqlDataAdapter(query1, con1);
            DataTable CurrentOrderDT = new DataTable();
            SDA1.Fill(CurrentOrderDT);
            DGCurrentOrder.DataSource = CurrentOrderDT;
            if (CurrentOrderDT.Rows.Count > 0) //if there are items in the current order, payment is proceeded to
            {
                frmPayment frmPayment = new frmPayment();
                frmPayment.Show();
                Login.Main.Close();

            } else
            {
                MessageBox.Show("No items selected", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void abbeyFarmDBDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string queryDeleteFromCO = $"DELETE FROM tblCurrentOrder WHERE ItemID = '{txtBoxItemID.Text}' AND OrderID = '{txtBoxOrderID.Text}';"; //the row selected is deleted from the table
            SqlCommand myCommand = new SqlCommand(queryDeleteFromCO, con);
            myCommand.ExecuteNonQuery();

            string queryFindOrderExistence = $"SELECT * FROM tblCurrentOrder WHERE OrderID = {txtBoxOrderID.Text}";
            SDA1 = new SqlDataAdapter(queryFindOrderExistence, con);
            DataTable CurrentOrderDT = new DataTable();
            SDA1.Fill(CurrentOrderDT);

            if (CurrentOrderDT.Rows.Count == 0)
            {
                string queryDeleteFromReceipts = $"DELETE FROM tblReceipts WHERE OrderID = '{txtBoxOrderID.Text}';"; //the order is deleted from the receipts database as all items have been returned
                myCommand = new SqlCommand(queryDeleteFromCO, con);
                myCommand.ExecuteNonQuery();
            }


            con.Close();


        }
    }
}
