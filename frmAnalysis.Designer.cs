﻿
namespace AbbeyFarmPOS
{
    partial class frmAnalysis
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalysis));
            this.btnExit = new System.Windows.Forms.Button();
            this.DGItemsAnalysis = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbeyFarmDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abbeyFarmDBDataSet = new AbbeyFarmPOS.AbbeyFarmDBDataSet();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.checkboxEggs = new System.Windows.Forms.CheckBox();
            this.lblYourUserID = new System.Windows.Forms.Label();
            this.checkboxBread = new System.Windows.Forms.CheckBox();
            this.checkboxMilk = new System.Windows.Forms.CheckBox();
            this.checkboxHoney = new System.Windows.Forms.CheckBox();
            this.checkboxSpreads = new System.Windows.Forms.CheckBox();
            this.sortByComboBox = new System.Windows.Forms.ComboBox();
            this.comboBoxItemType = new System.Windows.Forms.ComboBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.PWLine = new System.Windows.Forms.Panel();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtBoxItemName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.lblAddNewUser = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxQuantityInStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxUserID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxItemIDRestock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownRestock = new System.Windows.Forms.NumericUpDown();
            this.itemRestockedTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblItemRestocked = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.customerAnalysisUserControl1 = new AbbeyFarmPOS.CustomerAnalysisUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.DGItemsAnalysis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1211, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DGItemsAnalysis
            // 
            this.DGItemsAnalysis.AllowUserToAddRows = false;
            this.DGItemsAnalysis.AllowUserToDeleteRows = false;
            this.DGItemsAnalysis.AutoGenerateColumns = false;
            this.DGItemsAnalysis.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGItemsAnalysis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGItemsAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGItemsAnalysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.itemName,
            this.Quantity,
            this.Price,
            this.TotalCash,
            this.ItemType,
            this.QuantityInStock});
            this.DGItemsAnalysis.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGItemsAnalysis.DataSource = this.abbeyFarmDBDataSetBindingSource;
            this.DGItemsAnalysis.Location = new System.Drawing.Point(374, 71);
            this.DGItemsAnalysis.Name = "DGItemsAnalysis";
            this.DGItemsAnalysis.ReadOnly = true;
            this.DGItemsAnalysis.Size = new System.Drawing.Size(500, 500);
            this.DGItemsAnalysis.TabIndex = 21;
            this.DGItemsAnalysis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGItemsAnalysis_CellContentClick);
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
            this.ItemID.Width = 50;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "ItemName";
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Width = 194;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "QuantitySold";
            this.Quantity.HeaderText = "Quantity Sold";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 50;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 65;
            // 
            // TotalCash
            // 
            this.TotalCash.DataPropertyName = "TotalCash";
            this.TotalCash.HeaderText = "Total Cash (£)";
            this.TotalCash.Name = "TotalCash";
            this.TotalCash.ReadOnly = true;
            this.TotalCash.Width = 60;
            // 
            // ItemType
            // 
            this.ItemType.HeaderText = "Item Type";
            this.ItemType.Name = "ItemType";
            this.ItemType.ReadOnly = true;
            this.ItemType.Visible = false;
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.DataPropertyName = "QuantityInStock";
            this.QuantityInStock.HeaderText = "In Stock";
            this.QuantityInStock.Name = "QuantityInStock";
            this.QuantityInStock.ReadOnly = true;
            this.QuantityInStock.Width = 40;
            // 
            // abbeyFarmDBDataSetBindingSource
            // 
            this.abbeyFarmDBDataSetBindingSource.DataSource = this.abbeyFarmDBDataSet;
            this.abbeyFarmDBDataSetBindingSource.Position = 0;
            // 
            // abbeyFarmDBDataSet
            // 
            this.abbeyFarmDBDataSet.DataSetName = "AbbeyFarmDBDataSet";
            this.abbeyFarmDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(88, 366);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(190, 46);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Search";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // checkboxEggs
            // 
            this.checkboxEggs.AutoSize = true;
            this.checkboxEggs.Checked = true;
            this.checkboxEggs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxEggs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxEggs.Location = new System.Drawing.Point(68, 256);
            this.checkboxEggs.Name = "checkboxEggs";
            this.checkboxEggs.Size = new System.Drawing.Size(80, 29);
            this.checkboxEggs.TabIndex = 29;
            this.checkboxEggs.Text = "Eggs";
            this.checkboxEggs.UseVisualStyleBackColor = true;
            // 
            // lblYourUserID
            // 
            this.lblYourUserID.AutoSize = true;
            this.lblYourUserID.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold);
            this.lblYourUserID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYourUserID.Location = new System.Drawing.Point(121, 207);
            this.lblYourUserID.Name = "lblYourUserID";
            this.lblYourUserID.Size = new System.Drawing.Size(137, 27);
            this.lblYourUserID.TabIndex = 30;
            this.lblYourUserID.Text = "Show Items:";
            // 
            // checkboxBread
            // 
            this.checkboxBread.AutoSize = true;
            this.checkboxBread.Checked = true;
            this.checkboxBread.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxBread.Location = new System.Drawing.Point(154, 256);
            this.checkboxBread.Name = "checkboxBread";
            this.checkboxBread.Size = new System.Drawing.Size(88, 29);
            this.checkboxBread.TabIndex = 31;
            this.checkboxBread.Text = "Bread";
            this.checkboxBread.UseVisualStyleBackColor = true;
            // 
            // checkboxMilk
            // 
            this.checkboxMilk.AutoSize = true;
            this.checkboxMilk.Checked = true;
            this.checkboxMilk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxMilk.Location = new System.Drawing.Point(248, 256);
            this.checkboxMilk.Name = "checkboxMilk";
            this.checkboxMilk.Size = new System.Drawing.Size(70, 29);
            this.checkboxMilk.TabIndex = 32;
            this.checkboxMilk.Text = "Milk";
            this.checkboxMilk.UseVisualStyleBackColor = true;
            // 
            // checkboxHoney
            // 
            this.checkboxHoney.AutoSize = true;
            this.checkboxHoney.Checked = true;
            this.checkboxHoney.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxHoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxHoney.Location = new System.Drawing.Point(185, 307);
            this.checkboxHoney.Name = "checkboxHoney";
            this.checkboxHoney.Size = new System.Drawing.Size(93, 29);
            this.checkboxHoney.TabIndex = 34;
            this.checkboxHoney.Text = "Honey";
            this.checkboxHoney.UseVisualStyleBackColor = true;
            // 
            // checkboxSpreads
            // 
            this.checkboxSpreads.AutoSize = true;
            this.checkboxSpreads.Checked = true;
            this.checkboxSpreads.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxSpreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxSpreads.Location = new System.Drawing.Point(68, 307);
            this.checkboxSpreads.Name = "checkboxSpreads";
            this.checkboxSpreads.Size = new System.Drawing.Size(111, 29);
            this.checkboxSpreads.TabIndex = 33;
            this.checkboxSpreads.Text = "Spreads";
            this.checkboxSpreads.UseVisualStyleBackColor = true;
            // 
            // sortByComboBox
            // 
            this.sortByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortByComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByComboBox.FormattingEnabled = true;
            this.sortByComboBox.Items.AddRange(new object[] {
            "None",
            "Best Selling",
            "Worst Selling",
            "Out Of Stock"});
            this.sortByComboBox.Location = new System.Drawing.Point(17, 84);
            this.sortByComboBox.Name = "sortByComboBox";
            this.sortByComboBox.Size = new System.Drawing.Size(324, 47);
            this.sortByComboBox.TabIndex = 35;
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItemType.FormattingEnabled = true;
            this.comboBoxItemType.Items.AddRange(new object[] {
            "Eggs",
            "Bread",
            "Milk",
            "Spread",
            "Honey"});
            this.comboBoxItemType.Location = new System.Drawing.Point(886, 451);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Size = new System.Drawing.Size(238, 47);
            this.comboBoxItemType.TabIndex = 36;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(1135, 451);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 46);
            this.btnEnter.TabIndex = 37;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // PWLine
            // 
            this.PWLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PWLine.Location = new System.Drawing.Point(885, 273);
            this.PWLine.Name = "PWLine";
            this.PWLine.Size = new System.Drawing.Size(316, 1);
            this.PWLine.TabIndex = 52;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblForename.Location = new System.Drawing.Point(880, 212);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(136, 29);
            this.lblForename.TabIndex = 51;
            this.lblForename.Text = "Item Name";
            // 
            // txtBoxItemName
            // 
            this.txtBoxItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxItemName.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxItemName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxItemName.Location = new System.Drawing.Point(883, 246);
            this.txtBoxItemName.MaxLength = 50;
            this.txtBoxItemName.Name = "txtBoxItemName";
            this.txtBoxItemName.Size = new System.Drawing.Size(318, 28);
            this.txtBoxItemName.TabIndex = 53;
            this.txtBoxItemName.TextChanged += new System.EventHandler(this.forenameTxt_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(884, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 1);
            this.panel2.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(884, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 57;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPrice.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxPrice.Location = new System.Drawing.Point(884, 181);
            this.txtBoxPrice.MaxLength = 50;
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(102, 28);
            this.txtBoxPrice.TabIndex = 59;
            this.txtBoxPrice.TextChanged += new System.EventHandler(this.txtBoxPrice_TextChanged);
            // 
            // lblAddNewUser
            // 
            this.lblAddNewUser.AutoSize = true;
            this.lblAddNewUser.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewUser.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblAddNewUser.Location = new System.Drawing.Point(880, 71);
            this.lblAddNewUser.Name = "lblAddNewUser";
            this.lblAddNewUser.Size = new System.Drawing.Size(340, 61);
            this.lblAddNewUser.TabIndex = 60;
            this.lblAddNewUser.Text = "Add New Item";
            this.lblAddNewUser.Click += new System.EventHandler(this.lblAddNewUser_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(1084, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(69, 1);
            this.panel3.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(1000, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 29);
            this.label3.TabIndex = 61;
            this.label3.Text = "How Many In Stock?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBoxQuantityInStock
            // 
            this.txtBoxQuantityInStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxQuantityInStock.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQuantityInStock.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxQuantityInStock.Location = new System.Drawing.Point(1084, 181);
            this.txtBoxQuantityInStock.MaxLength = 50;
            this.txtBoxQuantityInStock.Name = "txtBoxQuantityInStock";
            this.txtBoxQuantityInStock.Size = new System.Drawing.Size(71, 28);
            this.txtBoxQuantityInStock.TabIndex = 63;
            this.txtBoxQuantityInStock.TextChanged += new System.EventHandler(this.txtBoxQuantityInStock_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(882, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 64;
            this.label1.Text = "Item Type";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(886, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 1);
            this.panel1.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(881, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 29);
            this.label4.TabIndex = 65;
            this.label4.Text = "Admin User ID";
            // 
            // txtBoxUserID
            // 
            this.txtBoxUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUserID.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxUserID.Location = new System.Drawing.Point(884, 311);
            this.txtBoxUserID.MaxLength = 50;
            this.txtBoxUserID.Name = "txtBoxUserID";
            this.txtBoxUserID.Size = new System.Drawing.Size(318, 28);
            this.txtBoxUserID.TabIndex = 67;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(886, 403);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 1);
            this.panel4.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(881, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 29);
            this.label5.TabIndex = 68;
            this.label5.Text = "Admin Passsword";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPassword.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxPassword.Location = new System.Drawing.Point(884, 376);
            this.txtBoxPassword.MaxLength = 50;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '•';
            this.txtBoxPassword.Size = new System.Drawing.Size(318, 28);
            this.txtBoxPassword.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 27);
            this.label6.TabIndex = 71;
            this.label6.Text = "Sort By:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 605);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 25);
            this.btnBack.TabIndex = 72;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestock.Location = new System.Drawing.Point(239, 476);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(120, 47);
            this.btnRestock.TabIndex = 73;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 27);
            this.label7.TabIndex = 74;
            this.label7.Text = "Restock:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(12, 515);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 1);
            this.panel5.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(12, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 29);
            this.label8.TabIndex = 75;
            this.label8.Text = "Item ID";
            // 
            // txtBoxItemIDRestock
            // 
            this.txtBoxItemIDRestock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxItemIDRestock.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxItemIDRestock.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxItemIDRestock.Location = new System.Drawing.Point(12, 488);
            this.txtBoxItemIDRestock.MaxLength = 50;
            this.txtBoxItemIDRestock.Name = "txtBoxItemIDRestock";
            this.txtBoxItemIDRestock.Size = new System.Drawing.Size(102, 28);
            this.txtBoxItemIDRestock.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(135, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 29);
            this.label9.TabIndex = 78;
            this.label9.Text = "Count";
            // 
            // numericUpDownRestock
            // 
            this.numericUpDownRestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRestock.Location = new System.Drawing.Point(140, 485);
            this.numericUpDownRestock.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDownRestock.Name = "numericUpDownRestock";
            this.numericUpDownRestock.Size = new System.Drawing.Size(77, 31);
            this.numericUpDownRestock.TabIndex = 81;
            // 
            // itemRestockedTimer
            // 
            this.itemRestockedTimer.Interval = 2000;
            this.itemRestockedTimer.Tick += new System.EventHandler(this.timerRestockTick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(881, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 41);
            this.button1.TabIndex = 83;
            this.button1.Text = "Customer Analysis";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lblItemRestocked
            // 
            this.lblItemRestocked.AutoSize = true;
            this.lblItemRestocked.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold);
            this.lblItemRestocked.ForeColor = System.Drawing.Color.Lime;
            this.lblItemRestocked.Location = new System.Drawing.Point(7, 524);
            this.lblItemRestocked.Name = "lblItemRestocked";
            this.lblItemRestocked.Size = new System.Drawing.Size(179, 27);
            this.lblItemRestocked.TabIndex = 82;
            this.lblItemRestocked.Text = "Item Restocked!";
            this.lblItemRestocked.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(881, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(355, 41);
            this.button2.TabIndex = 85;
            this.button2.Text = "Item Popularity";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // customerAnalysisUserControl1
            // 
            this.customerAnalysisUserControl1.Location = new System.Drawing.Point(-2, 0);
            this.customerAnalysisUserControl1.Name = "customerAnalysisUserControl1";
            this.customerAnalysisUserControl1.Size = new System.Drawing.Size(1248, 642);
            this.customerAnalysisUserControl1.TabIndex = 84;
            this.customerAnalysisUserControl1.Visible = false;
            this.customerAnalysisUserControl1.Load += new System.EventHandler(this.customerAnalysisUserControl1_Load);
            // 
            // frmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 642);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblItemRestocked);
            this.Controls.Add(this.numericUpDownRestock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxItemIDRestock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRestock);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxQuantityInStock);
            this.Controls.Add(this.lblAddNewUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.PWLine);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.txtBoxItemName);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.comboBoxItemType);
            this.Controls.Add(this.sortByComboBox);
            this.Controls.Add(this.checkboxHoney);
            this.Controls.Add(this.checkboxSpreads);
            this.Controls.Add(this.checkboxMilk);
            this.Controls.Add(this.checkboxBread);
            this.Controls.Add(this.lblYourUserID);
            this.Controls.Add(this.checkboxEggs);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.DGItemsAnalysis);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.customerAnalysisUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnalysis";
            this.Load += new System.EventHandler(this.frmAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGItemsAnalysis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.DataGridView DGItemsAnalysis;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox checkboxEggs;
        private System.Windows.Forms.Label lblYourUserID;
        private System.Windows.Forms.CheckBox checkboxBread;
        private System.Windows.Forms.CheckBox checkboxMilk;
        private System.Windows.Forms.CheckBox checkboxHoney;
        private System.Windows.Forms.CheckBox checkboxSpreads;
        private System.Windows.Forms.BindingSource abbeyFarmDBDataSetBindingSource;
        private AbbeyFarmDBDataSet abbeyFarmDBDataSet;
        private System.Windows.Forms.ComboBox sortByComboBox;
        private System.Windows.Forms.ComboBox comboBoxItemType;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Panel PWLine;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtBoxItemName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label lblAddNewUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxQuantityInStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxUserID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxItemIDRestock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownRestock;
        private System.Windows.Forms.Timer itemRestockedTimer;
        private System.Windows.Forms.Button button1;
        private CustomerAnalysisUserControl customerAnalysisUserControl1;
        private System.Windows.Forms.Label lblItemRestocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
        private System.Windows.Forms.Button button2;
    }
}