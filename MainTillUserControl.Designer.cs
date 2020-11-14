namespace AbbeyFarmPOS
{
    partial class MainTillUserControl
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
            this.btnBread.Location = new System.Drawing.Point(840, 127);
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
            this.btnMilk.Location = new System.Drawing.Point(840, 241);
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
            this.btnSpreads.Location = new System.Drawing.Point(840, 352);
            this.btnSpreads.Name = "btnSpreads";
            this.btnSpreads.Size = new System.Drawing.Size(240, 61);
            this.btnSpreads.TabIndex = 27;
            this.btnSpreads.Text = "Spreads";
            this.btnSpreads.UseVisualStyleBackColor = false;
            // 
            // btnHoney
            // 
            this.btnHoney.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoney.Location = new System.Drawing.Point(840, 460);
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
            this.lblTotalPrice.Location = new System.Drawing.Point(470, 550);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(82, 31);
            this.lblTotalPrice.TabIndex = 31;
            this.lblTotalPrice.Text = "£0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "Total Price:";
            // 
            // MainTillUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "MainTillUserControl";
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
    }
}
