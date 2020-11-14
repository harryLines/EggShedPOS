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
using System.Net.Mail;
using System.Net;

namespace AbbeyFarmPOS
{


    public partial class frmPayment : Form
    {
        public static DataTable CurrentOrderDT;
        SqlDataAdapter SDA1 = new SqlDataAdapter();
        SqlDataAdapter SDA2 = new SqlDataAdapter();
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query1 = $"SELECT tblItems.ItemID, tblItems.QuantityInStock, tblItems.ItemName, tblItems.Price, tblCurrentOrder.OrderID, tblCurrentOrder.ItemQuantity FROM tblItems INNER JOIN tblCurrentOrder ON tblItems.ItemID = tblCurrentOrder.ItemID";
            SDA1 = new SqlDataAdapter(query1, con1);
            DataTable CurrentOrderDT = new DataTable();
            SDA1.Fill(CurrentOrderDT);
            DGCurrentOrder.DataSource = CurrentOrderDT;

            if ((CurrentOrderDT.Rows.Count > 0))
            {
                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
                string query2 = $"SELECT SUM(TotalPrice) FROM tblCurrentOrder;"; //selects the sum of all the rows prices
                SDA2 = new SqlDataAdapter(query2, con2);
                DataTable TotalPriceDT = new DataTable();
                SDA2.Fill(TotalPriceDT);



                string priceStr = TotalPriceDT.Rows[0][0].ToString();

                decimal priceDec = decimal.Parse(priceStr);

                priceDec = Math.Round(priceDec, 2);

                priceStr = priceDec.ToString();

                lblTotalAmount.Text = "£" + priceStr; //the total price is calculated and displayed

            }
            else
            {
                lblTotalAmount.Text = "£0.00"; //if there are no items in the order, the total price is automatically £0
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string changeGivenStr = (cashGivenTxtBox.Text).ToString();
            string totalPriceStr = lblTotalAmount.Text;
            float changeGiven = float.Parse(changeGivenStr);
            float totalPrice = float.Parse(totalPriceStr.Trim(new Char[] { '£' }));

            if (changeGiven >= totalPrice)
            {
                lblChangeDueAmount.Text = "£" + (Math.Round((changeGiven - totalPrice), 2).ToString());
            }
            else
            {
                MessageBox.Show("Not enough change given", "Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query3 = $"DELETE FROM tblCurrentOrder;";
            SqlCommand myCommand = new SqlCommand(query3, con);
            myCommand.ExecuteNonQuery();
            con.Close();
            Application.Exit();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            //DataGridViewRow row = DGCurrentOrder.Rows[0];
            //var itemID = row.Cells[1].Value.ToString();

            string query1 = $"SELECT TOP 1 OrderID FROM tblCurrentOrder"; //selects the order id of the order being processed
            SDA2 = new SqlDataAdapter(query1, con);
            DataTable OrderIDDT = new DataTable();
            SDA2.Fill(OrderIDDT);


            var orderID = OrderIDDT.Rows[0][0];
            string orderIDStr = orderID.ToString();
            int orderIDInt = int.Parse(orderIDStr);


            char[] Char = { '£' };
            string totalPriceStr = lblTotalAmount.Text.TrimStart(Char);


            string query2 = $"INSERT INTO tblReceipts (OrderID, TotalPrice, DateAndTime) VALUES('{orderIDInt}', '{float.Parse(totalPriceStr)}', '{DateTime.Now}'); "; //creates a new recipt record for the order, which is now processed
            SqlCommand myCommandInsert = new SqlCommand(query2, con);
            myCommandInsert.ExecuteNonQuery();


            string queryWholeTable = $"SELECT * FROM tblCurrentOrder;";
            SDA2 = new SqlDataAdapter(queryWholeTable, con);
            DataTable CurrentOrderDT = new DataTable();
            SDA2.Fill(CurrentOrderDT);



            for (int i = CurrentOrderDT.Rows.Count; i!=0; i--)
            {
                string itemIDStr = CurrentOrderDT.Rows[i-1]["ItemID"].ToString();
                int itemID = int.Parse(itemIDStr);
                string itemQuantityStr = CurrentOrderDT.Rows[i-1]["ItemQuantity"].ToString();
                int itemQuantity = int.Parse(itemQuantityStr);
                string query4 = $"UPDATE tblItems SET QuantitySold = QuantitySold + '{itemQuantity}', QuantityInStock = QuantityInStock - '{itemQuantity}' WHERE ItemID = '{itemID}';"; //updates the required fields in the items table
                SqlCommand myCommandUpdate = new SqlCommand(query4, con);
                myCommandUpdate.ExecuteNonQuery();

            }


            string query3 = $"DELETE FROM tblCurrentOrder;"; //deletes the now processed order from the current order table
            SqlCommand myCommandDelete = new SqlCommand(query3, con);
            myCommandDelete.ExecuteNonQuery();

            con.Close();
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }


        private void btnSendReceipt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string queryCheckCustomerExists = $"SELECT * FROM tblCustomers WHERE EmailAddress = '{emailAddressTxt.Text}'";
            SDA2 = new SqlDataAdapter(queryCheckCustomerExists, con);
            DataTable CustomerExistsDT = new DataTable();
            SDA2.Fill(CustomerExistsDT);

            if (CustomerExistsDT.Rows.Count == 0)
            {
                string query = $"INSERT INTO tblCustomers (EmailAddress, Forename, Surname) VALUES('{emailAddressTxt.Text}', '{forenameTxt.Text}', '{surnameTxt.Text}'); ";
                SqlCommand newCustomer = new SqlCommand(query, con);
                newCustomer.ExecuteNonQuery();
            }

            DataGridViewRow DGVrow = DGCurrentOrder.Rows[0];
            var itemID = DGVrow.Cells["ItemID"].Value.ToString();

            string query1 = $"SELECT OrderID FROM tblCurrentOrder WHERE ItemID = '{itemID}' ;";
            SDA2 = new SqlDataAdapter(query1, con);
            DataTable OrderIDDT = new DataTable();
            SDA2.Fill(OrderIDDT);

            var orderID = OrderIDDT.Rows[0][0];
            string orderIDStr = orderID.ToString();
            int orderIDInt = int.Parse(orderIDStr);

            char[] Char = { '£' };
            string totalPriceStr = lblTotalAmount.Text.TrimStart(Char); //removes the pound sign from the price, so it can be parsed to a float value

            string query2 = $"INSERT INTO tblReceipts (OrderID, TotalPrice, EmailAddress, DateAndTime) VALUES('{orderIDInt}', '{float.Parse(totalPriceStr)}', '{emailAddressTxt.Text}', '{DateTime.Now}'); ";
            SqlCommand myCommandInsert = new SqlCommand(query2, con);
            myCommandInsert.ExecuteNonQuery();
            con.Close(); //creates a receipt record for the order

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("abbeyfarmeggshed@gmail.com");
                string email = emailAddressTxt.Text;
                mail.To.Add(email);
                mail.Subject = $"Egg Shed - Receipt for Order {orderIDInt.ToString()}";

                string queryWholeTable = $"SELECT * FROM tblCurrentOrder;";
                SDA2 = new SqlDataAdapter(queryWholeTable, con);
                DataTable CurrentOrderDT = new DataTable();
                SDA2.Fill(CurrentOrderDT);



                string receipt = "";
                foreach (DataRow row in CurrentOrderDT.Rows)
                {
                    string queryNameOfItem = $"SELECT ItemName FROM tblItems WHERE ItemID = {int.Parse((row["ItemID"]).ToString())};";
                    SDA2 = new SqlDataAdapter(queryNameOfItem, con);
                    DataTable NameDT = new DataTable();
                    SDA2.Fill(NameDT);

                    receipt += (NameDT.Rows[0][0]).ToString();
                    receipt += "\n";

                    for (int i = 0; i != 4; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                receipt += "Item ID:";
                                break;
                            case 1:
                                break;
                            case 2:
                                receipt += "Item Quantity:";
                                break;
                            case 3:
                                receipt += "Price:";
                                break;
                            default:
                                break;
                        }

                        if (i != 1)
                        {
                            receipt += " " + (row[i].ToString());
                            receipt += "\n";

                        } else
                        {
                            receipt += "";
                        }
                    }

                    receipt += "\n";
                }





                mail.Body = $"Thank you for making a purchase at the Egg Shed {forenameTxt.Text}\n\n Your order ID is {orderIDInt.ToString()} and you purchased:\n {receipt}";             //this section creates the email frame

                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("abbeyfarmeggshed@gmail.com", "abbeyfarm123");
                SmtpServer.EnableSsl = true; // this section provides the login for the program to use googles smtp server for sending the email through a gmail account

                SmtpServer.Send(mail); //sends the email
                MessageBox.Show("Receipt Sent Successfully");
              
                con.Open();
                string query3 = $"DELETE FROM tblCurrentOrder;";
                SqlCommand myCommand = new SqlCommand(query3, con);
                myCommand.ExecuteNonQuery();
                con.Close();
                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }


        }

        private void DGCurrentOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
