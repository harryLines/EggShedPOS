namespace AbbeyFarmPOS
{
    partial class frmPayment
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblChangeDueAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblChangeDue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cashGivenTxtBox = new System.Windows.Forms.TextBox();
            this.DGCurrentOrder = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.PWLine = new System.Windows.Forms.Panel();
            this.lblForename = new System.Windows.Forms.Label();
            this.forenameTxt = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.emailAddressTxt = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSendReceipt = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCurrentOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(90, 470);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 5);
            this.panel3.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblChangeDueAmount);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.lblChangeDue);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(90, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 50);
            this.panel1.TabIndex = 41;
            // 
            // lblChangeDueAmount
            // 
            this.lblChangeDueAmount.AutoSize = true;
            this.lblChangeDueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeDueAmount.Location = new System.Drawing.Point(410, 10);
            this.lblChangeDueAmount.Name = "lblChangeDueAmount";
            this.lblChangeDueAmount.Size = new System.Drawing.Size(71, 29);
            this.lblChangeDueAmount.TabIndex = 39;
            this.lblChangeDueAmount.Text = "£0.00";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(110, 10);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(71, 29);
            this.lblTotalAmount.TabIndex = 38;
            this.lblTotalAmount.Text = "£0.00";
            // 
            // lblChangeDue
            // 
            this.lblChangeDue.AutoSize = true;
            this.lblChangeDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeDue.Location = new System.Drawing.Point(220, 10);
            this.lblChangeDue.Name = "lblChangeDue";
            this.lblChangeDue.Size = new System.Drawing.Size(185, 33);
            this.lblChangeDue.TabIndex = 37;
            this.lblChangeDue.Text = "Change Due:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(10, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 33);
            this.lblTotal.TabIndex = 36;
            this.lblTotal.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Money Recieved:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(440, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 39;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cashGivenTxtBox
            // 
            this.cashGivenTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cashGivenTxtBox.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashGivenTxtBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cashGivenTxtBox.Location = new System.Drawing.Point(240, 530);
            this.cashGivenTxtBox.MaxLength = 5;
            this.cashGivenTxtBox.Name = "cashGivenTxtBox";
            this.cashGivenTxtBox.Size = new System.Drawing.Size(197, 41);
            this.cashGivenTxtBox.TabIndex = 38;
            // 
            // DGCurrentOrder
            // 
            this.DGCurrentOrder.AllowUserToAddRows = false;
            this.DGCurrentOrder.AllowUserToDeleteRows = false;
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
            this.DGCurrentOrder.Location = new System.Drawing.Point(90, 0);
            this.DGCurrentOrder.Name = "DGCurrentOrder";
            this.DGCurrentOrder.ReadOnly = true;
            this.DGCurrentOrder.Size = new System.Drawing.Size(500, 470);
            this.DGCurrentOrder.TabIndex = 36;
            this.DGCurrentOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCurrentOrder_CellContentClick);
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
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1050, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 43;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PWLine
            // 
            this.PWLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PWLine.Location = new System.Drawing.Point(632, 240);
            this.PWLine.Name = "PWLine";
            this.PWLine.Size = new System.Drawing.Size(188, 1);
            this.PWLine.TabIndex = 49;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblForename.Location = new System.Drawing.Point(630, 170);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(126, 29);
            this.lblForename.TabIndex = 48;
            this.lblForename.Text = "Forename";
            // 
            // forenameTxt
            // 
            this.forenameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.forenameTxt.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forenameTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.forenameTxt.Location = new System.Drawing.Point(630, 210);
            this.forenameTxt.MaxLength = 50;
            this.forenameTxt.Name = "forenameTxt";
            this.forenameTxt.Size = new System.Drawing.Size(190, 28);
            this.forenameTxt.TabIndex = 50;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSurname.Location = new System.Drawing.Point(850, 170);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(111, 29);
            this.lblSurname.TabIndex = 51;
            this.lblSurname.Text = "Surname";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(852, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 1);
            this.panel4.TabIndex = 52;
            // 
            // surnameTxt
            // 
            this.surnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameTxt.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.surnameTxt.Location = new System.Drawing.Point(850, 210);
            this.surnameTxt.MaxLength = 50;
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(190, 28);
            this.surnameTxt.TabIndex = 53;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(630, 350);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(408, 1);
            this.panel5.TabIndex = 55;
            // 
            // emailAddressTxt
            // 
            this.emailAddressTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailAddressTxt.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.emailAddressTxt.Location = new System.Drawing.Point(630, 320);
            this.emailAddressTxt.MaxLength = 50;
            this.emailAddressTxt.Name = "emailAddressTxt";
            this.emailAddressTxt.Size = new System.Drawing.Size(410, 28);
            this.emailAddressTxt.TabIndex = 56;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblEmailAddress.Location = new System.Drawing.Point(630, 280);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(168, 29);
            this.lblEmailAddress.TabIndex = 54;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(242, 570);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 1);
            this.panel2.TabIndex = 50;
            // 
            // btnSendReceipt
            // 
            this.btnSendReceipt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSendReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendReceipt.Location = new System.Drawing.Point(890, 530);
            this.btnSendReceipt.Name = "btnSendReceipt";
            this.btnSendReceipt.Size = new System.Drawing.Size(150, 40);
            this.btnSendReceipt.TabIndex = 57;
            this.btnSendReceipt.Text = "Send Receipt";
            this.btnSendReceipt.UseVisualStyleBackColor = false;
            this.btnSendReceipt.Click += new System.EventHandler(this.btnSendReceipt_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(630, 530);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(150, 40);
            this.btnSkip.TabIndex = 58;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(630, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 33);
            this.label4.TabIndex = 59;
            this.label4.Text = "Email Receipt";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(830, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 581);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnSendReceipt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.emailAddressTxt);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.PWLine);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.forenameTxt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cashGivenTxtBox);
            this.Controls.Add(this.DGCurrentOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCurrentOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChangeDueAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblChangeDue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cashGivenTxtBox;
        public System.Windows.Forms.DataGridView DGCurrentOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel PWLine;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox forenameTxt;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox emailAddressTxt;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSendReceipt;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}