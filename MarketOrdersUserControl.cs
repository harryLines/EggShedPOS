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
	public partial class MarketOrdersUserControl : UserControl
	{


		class PriorityQueue
		{
			public List<int> list;
			public int Count { get { return list.Count; } }

			public PriorityQueue()
			{
				list = new List<int>();
			}

			public PriorityQueue(int count)
			{
				list = new List<int>(count);
			}


			public int Enqueue(int x)
			{
				list.Add(x);
				int i = Count - 1;

				while (i > 0)
				{
					int p = (i - 1) / 2;
					if (list[p] <= x) return i;

					list[i] = list[p];
					i = p;
				}

				if (Count > 0) list[i] = x;
				return 0;
			}

			public int Dequeue()
			{
				int min = Peek();
				int root = list[Count - 1];
				list.RemoveAt(Count - 1);

				int i = 0;
				while (i * 2 + 1 < Count)
				{
					int a = i * 2 + 1;
					int b = i * 2 + 2;
					int c = b < Count && list[b] < list[a] ? b : a;

					if (list[c] >= root) break;
					list[i] = list[c];
					i = c;
				}

				if (Count > 0) list[i] = root;
				return min;
			}

			public int Peek()
			{
				if (Count == 0) throw new InvalidOperationException("Queue is empty.");
				return list[0];
			}

			public void Clear()
			{
				list.Clear();
			}
		}

		PriorityQueue pq = new PriorityQueue();


		public MarketOrdersUserControl()
		{
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Panel pnl = this.Parent as Panel;
			pnl.Controls.Clear();
			pnl.Controls.Add(frmMain.MainControl);
		}

		private void btnEnqueue_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");

			DataTable QuanDT = new DataTable();
			string queryQuan = $"SELECT QuantityInStock FROM tblItems WHERE ItemID = {txtBoxItemID.Text}";
			SqlDataAdapter SDAQuan = new SqlDataAdapter(queryQuan, con);

			try
			{
				SDAQuan.Fill(QuanDT);
			}
			catch (Exception ex)
            {
				MessageBox.Show("Invalid Input", "Market Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int quantityInStock = 0;

			if (QuanDT.Rows.Count == 0)
            {
				MessageBox.Show("Invalid Item ID", "Market Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			} else
            {
				quantityInStock = int.Parse(QuanDT.Rows[0]["QuantityInStock"].ToString());
			}

			if (numericUpDownQuantity.Value > quantityInStock)
			{
				MessageBox.Show("Not enough stock to queue this order", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				string query = $"SELECT OrderNumber, ItemID, Priority, Quantity, queueIndex FROM tblMarketOrders ORDER BY Priority DESC";
				con.Open();
				SqlDataAdapter SDA = new SqlDataAdapter(query, con);
				DataTable MarketOrderDT = new DataTable();

				SDA.Fill(MarketOrderDT);

				int count = MarketOrderDT.Rows.Count;
				int orderNumber = count;
				if (orderNumber == 0)
				{
					orderNumber = 1;
				}
				else
				{
					orderNumber = count + 1;
				}

				//the order number is assigned above

				int priority = int.Parse(numericUpDownPriority.Value.ToString());
				int queueIndex = 0;
				string queryInsert = $"INSERT INTO tblMarketOrders (OrderNumber, ItemID, Priority, Quantity) VALUES ({orderNumber}, {txtBoxItemID.Text}, {priority}, {numericUpDownQuantity.Value})";
				SqlCommand myCommand = new SqlCommand(queryInsert, con);
				SqlDataAdapter SDA1 = new SqlDataAdapter(queryInsert, con);
				myCommand.ExecuteNonQuery();
				MarketOrderDT.Clear();
				SDA.Fill(MarketOrderDT);

				//the new order is inserted


				DataTable ItemIDAndQuanDT = new DataTable();
				string queryItemIDAndQuan = $"SELECT ItemID, Quantity FROM tblMarketOrders WHERE OrderNumber = {orderNumber}";
				SqlDataAdapter SDAItemIDAndQuan = new SqlDataAdapter(queryItemIDAndQuan, con);
				SDAItemIDAndQuan.Fill(ItemIDAndQuanDT);

				int itemID = int.Parse(ItemIDAndQuanDT.Rows[0]["ItemID"].ToString());
				int quantity = int.Parse(ItemIDAndQuanDT.Rows[0]["Quantity"].ToString());

				string queryUpdateStock = $"UPDATE tblItems SET QuantityInStock = QuantityInStock - {quantity} WHERE ItemID = {itemID}";
				SqlCommand myCommand4 = new SqlCommand(queryUpdateStock, con);
				myCommand4.ExecuteNonQuery();

				//the above sections update the quantity of the item in stock to reflect the orders quantity being negated from it


				queueIndex = pq.Enqueue(priority);

				MarketOrderDT.Rows[orderNumber - 1]["queueIndex"] = queueIndex;

				string queryUpdate = $"UPDATE tblMarketOrders SET queueIndex = '{queueIndex}' WHERE OrderNumber = '{orderNumber}'";
				SqlCommand myCommand2 = new SqlCommand(queryUpdate, con);
				myCommand2.ExecuteNonQuery();

				dataGridView1.DataSource = MarketOrderDT;
				con.Close();

			}
		}

		private void MarketOrdersUserControl_Load(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
			con.Open();
			string query = $"SELECT OrderNumber, ItemID, Priority, Quantity, queueIndex FROM tblMarketOrders ORDER BY Priority DESC";
			SqlDataAdapter SDA = new SqlDataAdapter(query, con);
			DataTable MarketOrderDT = new DataTable();
			SDA.Fill(MarketOrderDT);
			foreach (DataRow row in MarketOrderDT.Rows)
			{
				int queueIndex = pq.Enqueue(int.Parse(row["Priority"].ToString()));
				row["queueIndex"] = queueIndex;

			}
			dataGridView1.DataSource = MarketOrderDT;
			con.Close();
		}

		private void btnDequeue_Click(object sender, EventArgs e)
		{
			pq.Dequeue();


			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
			con.Open();
			string query2 = $"SELECT OrderNumber, ItemID, Priority, Quantity, queueIndex FROM tblMarketOrders ORDER BY Priority DESC";
			SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
			DataTable MarketOrderDT = new DataTable();

			SDA2.Fill(MarketOrderDT);

			int orderNumber = 0;
			int minQueueIndex = 999;


			foreach (DataRow row in MarketOrderDT.Rows)
			{
				int queueIndex = row.Field<int>("queueIndex");
				minQueueIndex = Math.Min(minQueueIndex, queueIndex);
				minQueueIndex = queueIndex;
				if (minQueueIndex == queueIndex)
                {
					orderNumber = int.Parse(row["OrderNumber"].ToString());
				}



				if (int.Parse(row["queueIndex"].ToString()) == 0)
				{
					orderNumber = int.Parse(row["OrderNumber"].ToString());
					minQueueIndex = -1;
				}
			}
				
			
				DataTable ItemIDAndQuanDT = new DataTable();
				string queryItemIDAndQuan = $"SELECT ItemID, Quantity FROM tblMarketOrders WHERE OrderNumber = {orderNumber}";
				SqlDataAdapter SDAItemIDAndQuan = new SqlDataAdapter(queryItemIDAndQuan, con);
				SDAItemIDAndQuan.Fill(ItemIDAndQuanDT);

				int itemID = int.Parse(ItemIDAndQuanDT.Rows[0]["ItemID"].ToString());
				int quantity = int.Parse(ItemIDAndQuanDT.Rows[0]["Quantity"].ToString());




				string queryDequeue = $"DELETE FROM tblMarketOrders WHERE OrderNumber = {orderNumber}";
				SqlCommand myCommand = new SqlCommand(queryDequeue, con);
				myCommand.ExecuteNonQuery();

				string query = $"SELECT OrderNumber, ItemID, Priority, Quantity, queueIndex FROM tblMarketOrders ORDER BY Priority DESC";
				SqlDataAdapter SDA = new SqlDataAdapter(query, con);
				MarketOrderDT.Clear();
				SDA.Fill(MarketOrderDT);

				int count = 0;
				foreach (DataRow row in MarketOrderDT.Rows)
				{
					string queryInsert = $"UPDATE tblMarketOrders SET OrderNumber = {int.Parse(row["OrderNumber"].ToString()) + 999} WHERE OrderNumber = {row["OrderNumber"]}";
					row["OrderNumber"] = int.Parse(row["OrderNumber"].ToString()) + 999;
					SqlCommand myCommand2 = new SqlCommand(queryInsert, con);
					myCommand2.ExecuteNonQuery();

				}
				foreach (DataRow row2 in MarketOrderDT.Rows)
				{
					count++;
					string queryInsert2 = $"UPDATE tblMarketOrders SET OrderNumber = {count} WHERE OrderNumber = {row2["OrderNumber"]}";
					row2["OrderNumber"] = count;
					SqlCommand myCommand3 = new SqlCommand(queryInsert2, con);
					myCommand3.ExecuteNonQuery();
				}


			string queryUpdateStock = $"UPDATE tblItems SET QuantityInStock = QuantityInStock - {quantity} WHERE ItemID = {itemID}";
			SqlCommand myCommand4 = new SqlCommand(queryUpdateStock, con);
			myCommand4.ExecuteNonQuery();

			dataGridView1.DataSource = MarketOrderDT;
			con.Close();
			}

        private void button1_Click(object sender, EventArgs e)
        {
			pq.Dequeue();

			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Users\user\source\repos\AbbeyFarmPOS\AbbeyFarmDB.mdf;Integrated Security=True;Connect Timeout=30");
			con.Open();
			string query2 = $"SELECT OrderNumber, ItemID, Priority, Quantity, queueIndex FROM tblMarketOrders ORDER BY Priority DESC";
			SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
			DataTable MarketOrderDT = new DataTable();

			SDA2.Fill(MarketOrderDT);

			int orderNumber = 0;
			int minQueueIndex = 999;


			foreach (DataRow row in MarketOrderDT.Rows)
			{
				int queueIndex = row.Field<int>("queueIndex");
				minQueueIndex = Math.Min(minQueueIndex, queueIndex);
				minQueueIndex = queueIndex;
				if (minQueueIndex == queueIndex)
				{
					orderNumber = int.Parse(row["OrderNumber"].ToString());
				}



				if (int.Parse(row["queueIndex"].ToString()) == 0)
				{
					orderNumber = int.Parse(row["OrderNumber"].ToString());
					minQueueIndex = -1;
				}
			}

			string queryDequeue = $"DELETE FROM tblMarketOrders WHERE OrderNumber = {orderNumber}";
			SqlCommand myCommand = new SqlCommand(queryDequeue, con);
			myCommand.ExecuteNonQuery();

			string query = $"SELECT OrderNumber, ItemID, Priority, Quantity, queueIndex FROM tblMarketOrders ORDER BY Priority DESC";
			SqlDataAdapter SDA = new SqlDataAdapter(query, con);
			MarketOrderDT.Clear();
			SDA.Fill(MarketOrderDT);

			int count = 0;
			foreach (DataRow row in MarketOrderDT.Rows)
			{
				string queryInsert = $"UPDATE tblMarketOrders SET OrderNumber = {int.Parse(row["OrderNumber"].ToString()) + 999} WHERE OrderNumber = {row["OrderNumber"]}";
				row["OrderNumber"] = int.Parse(row["OrderNumber"].ToString()) + 999;
				SqlCommand myCommand2 = new SqlCommand(queryInsert, con);
				myCommand2.ExecuteNonQuery();

			}
			foreach (DataRow row2 in MarketOrderDT.Rows)
			{
				count++;
				string queryInsert2 = $"UPDATE tblMarketOrders SET OrderNumber = {count} WHERE OrderNumber = {row2["OrderNumber"]}";
				row2["OrderNumber"] = count;
				SqlCommand myCommand3 = new SqlCommand(queryInsert2, con);
				myCommand3.ExecuteNonQuery();
			}

			dataGridView1.DataSource = MarketOrderDT;
			con.Close();
		}
    }
	}

