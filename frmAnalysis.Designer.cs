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
            this.btnExit = new System.Windows.Forms.Button();
            this.DGItemsAnalysis = new System.Windows.Forms.DataGridView();
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
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGItemsAnalysis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSet)).BeginInit();
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
            this.TotalCash,
            this.Price,
            this.ItemType,
            this.QuantityInStock});
            this.DGItemsAnalysis.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGItemsAnalysis.DataSource = this.abbeyFarmDBDataSetBindingSource;
            this.DGItemsAnalysis.Location = new System.Drawing.Point(374, 71);
            this.DGItemsAnalysis.Name = "DGItemsAnalysis";
            this.DGItemsAnalysis.ReadOnly = true;
            this.DGItemsAnalysis.Size = new System.Drawing.Size(501, 500);
            this.DGItemsAnalysis.TabIndex = 21;
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
            this.btnRefresh.Location = new System.Drawing.Point(88, 375);
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
            "Best Selling",
            "Worst Selling",
            "Out Of Stock"});
            this.sortByComboBox.Location = new System.Drawing.Point(26, 118);
            this.sortByComboBox.Name = "sortByComboBox";
            this.sortByComboBox.Size = new System.Drawing.Size(324, 47);
            this.sortByComboBox.TabIndex = 35;
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
            this.Quantity.Width = 75;
            // 
            // TotalCash
            // 
            this.TotalCash.DataPropertyName = "TotalCash";
            this.TotalCash.HeaderText = "Total Cash (£)";
            this.TotalCash.Name = "TotalCash";
            this.TotalCash.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Visible = false;
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
            // frmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 642);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnalysis";
            this.Load += new System.EventHandler(this.frmAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGItemsAnalysis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
    }
}