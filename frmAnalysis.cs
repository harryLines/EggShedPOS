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
            DGItemsAnalysis.DataSource = ItemAnalysisDT;

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
                sortByMode = "WHERE QuantityInStock = 0";
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
            DGItemsAnalysis.DataSource = ItemAnalysisDT;



        }
    }
}
