namespace AbbeyFarmPOS
{
    partial class w
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGCurrentOrder = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbeyFarmDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abbeyFarmDBDataSet = new AbbeyFarmPOS.AbbeyFarmDBDataSet();
            this.btnEggs = new System.Windows.Forms.Button();
            this.btnBread = new System.Windows.Forms.Button();
            this.btnMilk = new System.Windows.Forms.Button();
            this.btnSpreads = new System.Windows.Forms.Button();
            this.btnHoney = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnVoid = new System.Windows.Forms.Button();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMakeReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxOrderID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxItemID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMarketOrders = new System.Windows.Forms.Button();
            this.lblItemReturned = new System.Windows.Forms.Label();
            this.itemReturnedTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGCurrentOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DGCurrentOrder
            // 
            this.DGCurrentOrder.AllowUserToAddRows = false;
            this.DGCurrentOrder.AllowUserToDeleteRows = false;
            this.DGCurrentOrder.AutoGenerateColumns = false;
            this.DGCurrentOrder.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGCurrentOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGCurrentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCurrentOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemID,
            this.Quantity,
            this.Price,
            this.OrderID,
            this.QuantityInStock});
            this.DGCurrentOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGCurrentOrder.DataSource = this.abbeyFarmDBDataSetBindingSource;
            this.DGCurrentOrder.Location = new System.Drawing.Point(300, 20);
            this.DGCurrentOrder.Name = "DGCurrentOrder";
            this.DGCurrentOrder.ReadOnly = true;
            this.DGCurrentOrder.Size = new System.Drawing.Size(500, 500);
            this.DGCurrentOrder.TabIndex = 0;
            this.DGCurrentOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 125;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.ItemID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemID.Width = 84;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "ItemQuantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Visible = false;
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.DataPropertyName = "QuantityInStock";
            this.QuantityInStock.HeaderText = "QuantityInStock";
            this.QuantityInStock.Name = "QuantityInStock";
            this.QuantityInStock.ReadOnly = true;
            this.QuantityInStock.Visible = false;
            // 
            // abbeyFarmDBDataSetBindingSource
            // 
            this.abbeyFarmDBDataSetBindingSource.DataSource = this.abbeyFarmDBDataSet;
            this.abbeyFarmDBDataSetBindingSource.Position = 0;
            this.abbeyFarmDBDataSetBindingSource.CurrentChanged += new System.EventHandler(this.abbeyFarmDBDataSetBindingSource_CurrentChanged);
            // 
            // abbeyFarmDBDataSet
            // 
            this.abbeyFarmDBDataSet.DataSetName = "AbbeyFarmDBDataSet";
            this.abbeyFarmDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEggs
            // 
            this.btnEggs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEggs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEggs.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEggs.Location = new System.Drawing.Point(840, 20);
            this.btnEggs.Name = "btnEggs";
            this.btnEggs.Size = new System.Drawing.Size(240, 60);
            this.btnEggs.TabIndex = 24;
            this.btnEggs.Text = "Eggs";
            this.btnEggs.UseVisualStyleBackColor = false;
            this.btnEggs.Click += new System.EventHandler(this.btnEggs_Click);
            // 
            // btnBread
            // 
            this.btnBread.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBread.Location = new System.Drawing.Point(840, 121);
            this.btnBread.Name = "btnBread";
            this.btnBread.Size = new System.Drawing.Size(240, 67);
            this.btnBread.TabIndex = 25;
            this.btnBread.Text = "Bread";
            this.btnBread.UseVisualStyleBackColor = false;
            // 
            // btnMilk
            // 
            this.btnMilk.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMilk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMilk.Location = new System.Drawing.Point(840, 229);
            this.btnMilk.Name = "btnMilk";
            this.btnMilk.Size = new System.Drawing.Size(240, 64);
            this.btnMilk.TabIndex = 26;
            this.btnMilk.Text = "Milk";
            this.btnMilk.UseVisualStyleBackColor = false;
            // 
            // btnSpreads
            // 
            this.btnSpreads.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSpreads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpreads.Location = new System.Drawing.Point(840, 334);
            this.btnSpreads.Name = "btnSpreads";
            this.btnSpreads.Size = new System.Drawing.Size(240, 61);
            this.btnSpreads.TabIndex = 27;
            this.btnSpreads.Text = "Conserves";
            this.btnSpreads.UseVisualStyleBackColor = false;
            // 
            // btnHoney
            // 
            this.btnHoney.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoney.Location = new System.Drawing.Point(840, 436);
            this.btnHoney.Name = "btnHoney";
            this.btnHoney.Size = new System.Drawing.Size(240, 60);
            this.btnHoney.TabIndex = 28;
            this.btnHoney.Text = "Honey";
            this.btnHoney.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(560, 540);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(240, 60);
            this.btnPayment.TabIndex = 29;
            this.btnPayment.Text = "Make Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVoid
            // 
            this.btnVoid.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid.Location = new System.Drawing.Point(10, 540);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(290, 60);
            this.btnVoid.TabIndex = 30;
            this.btnVoid.Text = "Void Selected Item";
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.button2_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 5000;
            this.timerRefresh.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(387, 569);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(82, 31);
            this.lblTotalPrice.TabIndex = 31;
            this.lblTotalPrice.Text = "£0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "Total Price:";
            // 
            // btnMakeReturn
            // 
            this.btnMakeReturn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMakeReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReturn.Location = new System.Drawing.Point(37, 436);
            this.btnMakeReturn.Name = "btnMakeReturn";
            this.btnMakeReturn.Size = new System.Drawing.Size(223, 48);
            this.btnMakeReturn.TabIndex = 33;
            this.btnMakeReturn.Text = "Make Return";
            this.btnMakeReturn.UseVisualStyleBackColor = false;
            this.btnMakeReturn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(30, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 37);
            this.label2.TabIndex = 35;
            this.label2.Text = "Order ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(178, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 1);
            this.panel2.TabIndex = 34;
            // 
            // txtBoxOrderID
            // 
            this.txtBoxOrderID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxOrderID.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOrderID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxOrderID.Location = new System.Drawing.Point(178, 318);
            this.txtBoxOrderID.MaxLength = 5;
            this.txtBoxOrderID.Name = "txtBoxOrderID";
            this.txtBoxOrderID.Size = new System.Drawing.Size(100, 34);
            this.txtBoxOrderID.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(46, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 37);
            this.label3.TabIndex = 38;
            this.label3.Text = "Item ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(180, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 1);
            this.panel1.TabIndex = 37;
            // 
            // txtBoxItemID
            // 
            this.txtBoxItemID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxItemID.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxItemID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxItemID.Location = new System.Drawing.Point(178, 376);
            this.txtBoxItemID.MaxLength = 5;
            this.txtBoxItemID.Name = "txtBoxItemID";
            this.txtBoxItemID.Size = new System.Drawing.Size(100, 34);
            this.txtBoxItemID.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 33);
            this.label4.TabIndex = 40;
            this.label4.Text = "Returns:";
            // 
            // btnMarketOrders
            // 
            this.btnMarketOrders.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMarketOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarketOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarketOrders.Location = new System.Drawing.Point(840, 540);
            this.btnMarketOrders.Name = "btnMarketOrders";
            this.btnMarketOrders.Size = new System.Drawing.Size(240, 60);
            this.btnMarketOrders.TabIndex = 41;
            this.btnMarketOrders.Text = "Supermarket Orders";
            this.btnMarketOrders.UseVisualStyleBackColor = false;
            this.btnMarketOrders.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lblItemReturned
            // 
            this.lblItemReturned.AutoSize = true;
            this.lblItemReturned.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold);
            this.lblItemReturned.ForeColor = System.Drawing.Color.Lime;
            this.lblItemReturned.Location = new System.Drawing.Point(66, 493);
            this.lblItemReturned.Name = "lblItemReturned";
            this.lblItemReturned.Size = new System.Drawing.Size(162, 27);
            this.lblItemReturned.TabIndex = 83;
            this.lblItemReturned.Text = "Item Returned";
            this.lblItemReturned.Visible = false;
            // 
            // itemReturnedTimer
            // 
            this.itemReturnedTimer.Interval = 2000;
            this.itemReturnedTimer.Tick += new System.EventHandler(this.itemRestockedTimer_Tick);
            // 
            // w
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblItemReturned);
            this.Controls.Add(this.btnMarketOrders);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxItemID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBoxOrderID);
            this.Controls.Add(this.btnMakeReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnHoney);
            this.Controls.Add(this.btnSpreads);
            this.Controls.Add(this.btnMilk);
            this.Controls.Add(this.btnBread);
            this.Controls.Add(this.btnEggs);
            this.Controls.Add(this.DGCurrentOrder);
            this.Name = "w";
            this.Size = new System.Drawing.Size(1100, 620);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCurrentOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource abbeyFarmDBDataSetBindingSource;
        private AbbeyFarmDBDataSet abbeyFarmDBDataSet;
        private System.Windows.Forms.Button btnEggs;
        private System.Windows.Forms.Button btnBread;
        private System.Windows.Forms.Button btnMilk;
        private System.Windows.Forms.Button btnSpreads;
        private System.Windows.Forms.Button btnHoney;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnVoid;
        public System.Windows.Forms.DataGridView DGCurrentOrder;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
        private System.Windows.Forms.Button btnMakeReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxOrderID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxItemID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMarketOrders;
        private System.Windows.Forms.Label lblItemReturned;
        private System.Windows.Forms.Timer itemReturnedTimer;
    }
}
