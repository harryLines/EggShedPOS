namespace AbbeyFarmPOS
{
    partial class EggsUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.eggDG = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbeyFarmDBDataSet = new AbbeyFarmPOS.AbbeyFarmDBDataSet();
            this.abbeyFarmDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eggDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eggDG
            // 
            this.eggDG.AllowUserToAddRows = false;
            this.eggDG.AllowUserToDeleteRows = false;
            this.eggDG.AllowUserToOrderColumns = true;
            this.eggDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.eggDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.eggDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eggDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.eggDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eggDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Price,
            this.QuantityInStock,
            this.ItemID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.eggDG.DefaultCellStyle = dataGridViewCellStyle2;
            this.eggDG.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.eggDG.Location = new System.Drawing.Point(300, 20);
            this.eggDG.Name = "eggDG";
            this.eggDG.ReadOnly = true;
            this.eggDG.Size = new System.Drawing.Size(500, 500);
            this.eggDG.TabIndex = 0;
            this.eggDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eggDG_CellClick);
            this.eggDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eggDG_CellContentClick);
            this.eggDG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eggDG_CellDoubleClick);
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemName.Width = 220;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.Width = 70;
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QuantityInStock.DataPropertyName = "QuantityInStock";
            this.QuantityInStock.HeaderText = "Stock";
            this.QuantityInStock.Name = "QuantityInStock";
            this.QuantityInStock.ReadOnly = true;
            this.QuantityInStock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ItemID
            // 
            this.ItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemID.Width = 70;
            // 
            // abbeyFarmDBDataSet
            // 
            this.abbeyFarmDBDataSet.DataSetName = "AbbeyFarmDBDataSet";
            this.abbeyFarmDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abbeyFarmDBDataSetBindingSource
            // 
            this.abbeyFarmDBDataSetBindingSource.DataSource = this.abbeyFarmDBDataSet;
            this.abbeyFarmDBDataSetBindingSource.Position = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(10, 590);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 25);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EggsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.eggDG);
            this.Name = "EggsUserControl";
            this.Size = new System.Drawing.Size(1100, 620);
            this.Load += new System.EventHandler(this.EggsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eggDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView eggDG;
        private AbbeyFarmDBDataSet abbeyFarmDBDataSet;
        private System.Windows.Forms.BindingSource abbeyFarmDBDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.Button btnBack;
    }
}
