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
    public partial class CustomerAnalysisUserControl : UserControl
    {
        public CustomerAnalysisUserControl()
        {
            InitializeComponent();
        }

        private void CustomerAnalysisUserControl_Load(object sender, EventArgs e)
        {
            this.Visible = true;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query1 = $"SELECT * FROM tblCustomers";
            SqlDataAdapter SDA1 = new SqlDataAdapter();
            SDA1 = new SqlDataAdapter(query1, con);
            DataTable CustomerAnalysisDT = new DataTable();
            SDA1.Fill(CustomerAnalysisDT);
            DGCustomerAnalysis.DataSource = CustomerAnalysisDT;
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable CustomerDT = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter SDA = new SqlDataAdapter();
            con.Open();

            string query1 = $"SELECT * FROM tblCustomers";
            SqlDataAdapter SDA1 = new SqlDataAdapter();
            SDA1 = new SqlDataAdapter(query1, con);
            DataTable CustomerAnalysisDT = new DataTable();
            SDA1.Fill(CustomerAnalysisDT);

            string sortByMode = "ASC";

            if (sortByComboBox.SelectedIndex == -1 | sortByComboBox.SelectedIndex == 0)
            {
                sortByMode = "";
            }
            else
            {

                if (sortByComboBox.SelectedItem.ToString() == "Most Bought")
                {
                    sortByMode = "ORDER BY AmountOfTransactions DESC";
                }
                else if (sortByComboBox.SelectedItem.ToString() == "Most Spent")
                {
                    sortByMode = "ORDER BY TotalSpent DESC";
                }
            }


            string query2 = $"SELECT * FROM tblCustomers {sortByMode};";
            CustomerAnalysisDT.Clear();
            SDA = new SqlDataAdapter(query2, con);
            SDA.Fill(CustomerAnalysisDT);
            DGCustomerAnalysis.DataSource = CustomerAnalysisDT;
            con.Close();
        }

        private void sortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
