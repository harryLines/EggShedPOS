﻿using System;
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
        int OrderIDPublic = frmMain.OrderID;
        static Random random = new Random();
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query1 = $"SELECT tblItems.ItemID, tblItems.QuantityInStock, tblItems.ItemName, tblItems.Price, tblCurrentOrder.OrderID, tblCurrentOrder.ItemQuantity FROM tblItems INNER JOIN tblCurrentOrder ON tblItems.ItemID = tblCurrentOrder.ItemID WHERE tblCurrentOrder.OrderID = {frmMain.OrderID}";
            SDA1 = new SqlDataAdapter(query1, con1);
            DataTable CurrentOrderDT = new DataTable();
            SDA1.Fill(CurrentOrderDT);
            DGCurrentOrder.DataSource = CurrentOrderDT;

            if ((CurrentOrderDT.Rows.Count > 0))
            {
                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
                string query2 = $"SELECT SUM(ItemTotalPrice) FROM tblCurrentOrder WHERE OrderID = {OrderIDPublic};"; //selects the sum of all the rows prices
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
            string query3 = $"DELETE FROM tblCurrentOrder WHERE OrderID = {OrderIDPublic};";
            SqlCommand myCommand = new SqlCommand(query3, con);
            myCommand.ExecuteNonQuery();
            con.Close();
            Application.Exit();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
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


            char[] Char = { '£' };
            string totalPriceStr = lblTotalAmount.Text.TrimStart(Char); //removes the pound sign from the price, so it can be parsed to a float value


            string query2 = $"INSERT INTO tblReceipts (OrderID, TotalOrderPrice, EmailAddress, DateAndTime) VALUES('{frmMain.OrderID}', '{float.Parse(totalPriceStr)}', '{emailAddressTxt.Text}', '{DateTime.Now}'); ";
            SqlCommand myCommandInsert = new SqlCommand(query2, con);
            myCommandInsert.ExecuteNonQuery();


            string queryItemID = $"SELECT * FROM tblCurrentOrder WHERE OrderID = '{frmMain.OrderID}' ;";
            SDA2 = new SqlDataAdapter(queryItemID, con);
            DataTable ItemIDDT = new DataTable();
            SDA2.Fill(ItemIDDT);

            int itemIDInt = int.Parse(ItemIDDT.Rows[0][0].ToString());
            int itemQuantityInt = int.Parse(ItemIDDT.Rows[0][2].ToString());
            float itemTotalPriceInt = float.Parse(ItemIDDT.Rows[0][3].ToString());
            float totalOrderPrice = 0;

            foreach (DataRow row in ItemIDDT.Rows)
            {
                itemIDInt = int.Parse(row[0].ToString());
                itemQuantityInt = int.Parse(row[2].ToString());
                itemTotalPriceInt = float.Parse(row[3].ToString());
                query2 = $"UPDATE tblCurrentOrder SET ItemQuantity = '{itemQuantityInt}', ItemTotalPrice = '{itemTotalPriceInt}' WHERE ItemID = {itemIDInt} AND OrderID = {OrderIDPublic}; ";
                myCommandInsert = new SqlCommand(query2, con);
                myCommandInsert.ExecuteNonQuery();
                totalOrderPrice += itemTotalPriceInt;
            }

            con.Close();

            frmMain.Show();
            this.Hide();


        }


        private void btnSendReceipt_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
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


            char[] Char = { '£' };
            string totalPriceStr = lblTotalAmount.Text.TrimStart(Char); //removes the pound sign from the price, so it can be parsed to a float value

            var dateAndTime = DateTime.Now;

            string query2 = $"INSERT INTO tblReceipts (OrderID, TotalOrderPrice, EmailAddress, DateAndTime) VALUES('{frmMain.OrderID}', '{float.Parse(totalPriceStr)}', '{emailAddressTxt.Text}', '{DateTime.Now}'); ";
            SqlCommand myCommandInsert = new SqlCommand(query2, con);
            myCommandInsert.ExecuteNonQuery();


            string queryItemID = $"SELECT * FROM tblCurrentOrder WHERE OrderID = '{frmMain.OrderID}' ;";
            SDA2 = new SqlDataAdapter(queryItemID, con);
            DataTable ItemIDDT = new DataTable();
            SDA2.Fill(ItemIDDT);

            int itemIDInt = int.Parse(ItemIDDT.Rows[0][0].ToString());
            int itemQuantityInt = int.Parse(ItemIDDT.Rows[0][2].ToString());
            float itemTotalPriceInt = float.Parse(ItemIDDT.Rows[0][3].ToString());
            float totalOrderPrice = 0;

            foreach (DataRow row in ItemIDDT.Rows)
            {
                itemIDInt = int.Parse(row[0].ToString());
                itemQuantityInt = int.Parse(row[2].ToString());
                itemTotalPriceInt = float.Parse(row[3].ToString());
                query2 = $"UPDATE tblCurrentOrder SET ItemQuantity = '{itemQuantityInt}', ItemTotalPrice = '{itemTotalPriceInt}' WHERE ItemID = {itemIDInt} AND OrderID = {OrderIDPublic}; ";
                myCommandInsert = new SqlCommand(query2, con);
                myCommandInsert.ExecuteNonQuery();
                totalOrderPrice += itemTotalPriceInt;
            }





            con.Close();

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("abbeyfarmeggshed@gmail.com");
                string email = emailAddressTxt.Text;
                mail.To.Add(email);
                mail.Subject = $"Egg Shed - Receipt for Order {OrderIDPublic}";

                string queryWholeTable = $"SELECT * FROM tblCurrentOrder WHERE OrderID = {OrderIDPublic};";
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

                        if (i != 1 & i != 3)
                        {
                            receipt += " " + (row[i].ToString());
                            receipt += "\n";

                        } else if (i == 3)
                        {
                            receipt += " £" + Math.Round((float.Parse(row[i].ToString())),2);
                            receipt += "\n";
                        }
                        else
                        {
                            receipt += "";
                        }
                    }

                    receipt += "\n";
                }
                receipt += $"{dateAndTime.ToString()}";





                mail.Body = $"Dear {forenameTxt.Text}, Thank you for making a purchase at the Egg Shed \n\n Your order ID is {OrderIDPublic} and you purchased:\n {receipt}";             //this section creates the email frame

                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("abbeyfarmeggshed@gmail.com", "abbeyfarm123");
                SmtpServer.EnableSsl = true; // this section provides the login for the program to use googles smtp server for sending the email through a gmail account

                SmtpServer.Send(mail); //sends the email
                MessageBox.Show("Receipt Sent Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            con.Open();
            string queryChangeOrderID = $"SELECT * FROM dbo.tblCurrentOrder WHERE OrderID = {frmMain.OrderID}"; //selects all past orders with this ID, (should be maximum 1 as this is a primary key)
            SqlDataAdapter SDA = new SqlDataAdapter(queryChangeOrderID, con);
            DataTable ReceiptDT = new DataTable();
            SDA.Fill(ReceiptDT);



            SqlCommand comm = new SqlCommand($"SELECT COUNT(OrderID) FROM tblReceipts WHERE EmailAddress = '{emailAddressTxt.Text}'", con);
            Int32 amountOfTransactions = (Int32)comm.ExecuteScalar();


            SqlCommand comm2 = new SqlCommand($"SELECT SUM(TotalOrderPrice) FROM tblReceipts WHERE EmailAddress = '{emailAddressTxt.Text}'", con);
            object totalSpent = comm2.ExecuteScalar();
            string totalSpentStr = totalSpent.ToString();
            float totalSpentFloat = float.Parse(totalSpentStr);


            query2 = $"UPDATE tblCustomers SET TotalSpent = {totalSpentFloat} + {totalOrderPrice}, AmountOfTransactions = {amountOfTransactions} + 1 WHERE EmailAddress = '{emailAddressTxt.Text}';";
            myCommandInsert = new SqlCommand(query2, con);
            myCommandInsert.ExecuteNonQuery();

            int orderIDChanged = 0;

            frmMain.OrderID = orderIDChanged;
            con.Close();

            frmMain.Show();
            this.Hide();
        }

        private void DGCurrentOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
