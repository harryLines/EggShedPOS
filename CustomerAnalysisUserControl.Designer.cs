
namespace AbbeyFarmPOS
{
    partial class CustomerAnalysisUserControl
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
            this.label6 = new System.Windows.Forms.Label();
            this.sortByComboBox = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.DGCustomerAnalysis = new System.Windows.Forms.DataGridView();
            this.abbeyFarmDBDataSet = new AbbeyFarmPOS.AbbeyFarmDBDataSet();
            this.btnBack = new System.Windows.Forms.Button();
            this.abbeyFarmDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfTransactions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomerAnalysis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(637, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 27);
            this.label6.TabIndex = 92;
            this.label6.Text = "Sort By:";
            // 
            // sortByComboBox
            // 
            this.sortByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortByComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByComboBox.FormattingEnabled = true;
            this.sortByComboBox.Items.AddRange(new object[] {
            "None",
            "Most Bought",
            "Most Spent"});
            this.sortByComboBox.Location = new System.Drawing.Point(642, 583);
            this.sortByComboBox.Name = "sortByComboBox";
            this.sortByComboBox.Size = new System.Drawing.Size(324, 47);
            this.sortByComboBox.TabIndex = 91;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(972, 584);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(170, 46);
            this.btnRefresh.TabIndex = 84;
            this.btnRefresh.Text = "Search";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // DGCustomerAnalysis
            // 
            this.DGCustomerAnalysis.AllowUserToAddRows = false;
            this.DGCustomerAnalysis.AllowUserToDeleteRows = false;
            this.DGCustomerAnalysis.AutoGenerateColumns = false;
            this.DGCustomerAnalysis.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGCustomerAnalysis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGCustomerAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCustomerAnalysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.Surname,
            this.AmountOfTransactions,
            this.TotalSpent,
            this.EmailAddress});
            this.DGCustomerAnalysis.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGCustomerAnalysis.DataSource = this.abbeyFarmDBDataSetBindingSource;
            this.DGCustomerAnalysis.Location = new System.Drawing.Point(371, 29);
            this.DGCustomerAnalysis.Name = "DGCustomerAnalysis";
            this.DGCustomerAnalysis.ReadOnly = true;
            this.DGCustomerAnalysis.Size = new System.Drawing.Size(771, 510);
            this.DGCustomerAnalysis.TabIndex = 83;
            // 
            // abbeyFarmDBDataSet
            // 
            this.abbeyFarmDBDataSet.DataSetName = "AbbeyFarmDBDataSet";
            this.abbeyFarmDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(14, 605);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 25);
            this.btnBack.TabIndex = 93;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // abbeyFarmDBDataSetBindingSource
            // 
            this.abbeyFarmDBDataSetBindingSource.DataSource = this.abbeyFarmDBDataSet;
            this.abbeyFarmDBDataSetBindingSource.Position = 0;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "Forename";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 130;
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 130;
            // 
            // AmountOfTransactions
            // 
            this.AmountOfTransactions.DataPropertyName = "AmountOfTransactions";
            this.AmountOfTransactions.HeaderText = "Purchases";
            this.AmountOfTransactions.Name = "AmountOfTransactions";
            this.AmountOfTransactions.ReadOnly = true;
            // 
            // TotalSpent
            // 
            this.TotalSpent.DataPropertyName = "TotalSpent";
            this.TotalSpent.HeaderText = "Total Spent";
            this.TotalSpent.Name = "TotalSpent";
            this.TotalSpent.ReadOnly = true;
            // 
            // EmailAddress
            // 
            this.EmailAddress.DataPropertyName = "EmailAddress";
            this.EmailAddress.HeaderText = "Email Address";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Width = 199;
            // 
            // CustomerAnalysisUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sortByComboBox);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.DGCustomerAnalysis);
            this.Name = "CustomerAnalysisUserControl";
            this.Size = new System.Drawing.Size(1248, 642);
            this.Load += new System.EventHandler(this.CustomerAnalysisUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomerAnalysis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abbeyFarmDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sortByComboBox;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.DataGridView DGCustomerAnalysis;
        private AbbeyFarmDBDataSet abbeyFarmDBDataSet;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource abbeyFarmDBDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOfTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSpent;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
    }
}
