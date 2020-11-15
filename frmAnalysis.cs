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
            string sortByMode = "ASC";

            if (sortByComboBox.SelectedIndex == -1)
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
                    sortByMode = "AND QuantityInStock = 0";
                }

            }

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query1 = $"SELECT * FROM tblItems {sortByMode};";
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA = new SqlDataAdapter(query1, con);
            DataTable ItemAnalysisDT = new DataTable();
            SDA.Fill(ItemAnalysisDT);

            ItemAnalysisDT.Columns.Add("TotalCash", typeof(float));

            foreach (DataRow row in ItemAnalysisDT.Rows)
            {
                row["TotalCash"] = Math.Round((float.Parse((row["Price"]).ToString())) * (float.Parse((row["QuantitySold"]).ToString())),2);
            }

            string boxesChecked = "ItemType =";

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
            } else if (checkboxBread.Checked == true)
            {
                boxesChecked += "'Bread'";
                boxesCheckedCount += 1;
            }
            if (checkboxMilk.Checked == true & boxesCheckedCount >= 1)
            {
                boxesChecked += " OR ItemType='Milk'";
                boxesCheckedCount += 1;
            } else if (checkboxMilk.Checked == true)
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
                string query2 = $"SELECT * FROM tblItems WHERE {boxesChecked}{sortByMode};";
                SqlDataAdapter SDA2 = new SqlDataAdapter();
                SDA = new SqlDataAdapter(query2, con);
                DataTable ItemAnalysisModifiedDT = new DataTable();
                SDA.Fill(ItemAnalysisModifiedDT);

                ItemAnalysisModifiedDT.Columns.Add("TotalCash", typeof(float));

                foreach (DataRow row in ItemAnalysisModifiedDT.Rows)
                {
                    row["TotalCash"] = Math.Round((float.Parse((row["Price"]).ToString())) * (float.Parse((row["QuantitySold"]).ToString())), 2);
                }

                DGItemsAnalysis.DataSource = ItemAnalysisModifiedDT;

            } else
            {
                DataTable ItemAnalysisModifiedDT = new DataTable();
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

        }
    }
}
