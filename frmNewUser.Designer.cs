namespace AbbeyFarmPOS
{
    partial class frmNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewUser));
            this.lblAddNewUser = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.forenameTxt = new System.Windows.Forms.TextBox();
            this.PWLine = new System.Windows.Forms.Panel();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.SNLine = new System.Windows.Forms.Panel();
            this.FNLine = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.UserIcon = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.lblUserCreated = new System.Windows.Forms.Label();
            this.lblIsAdmin = new System.Windows.Forms.Label();
            this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.lblSuccessfulCreation = new System.Windows.Forms.Label();
            this.lblYourUserID = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxRemoveUserID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddNewUser
            // 
            this.lblAddNewUser.AutoSize = true;
            this.lblAddNewUser.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddNewUser.Location = new System.Drawing.Point(229, 30);
            this.lblAddNewUser.Name = "lblAddNewUser";
            this.lblAddNewUser.Size = new System.Drawing.Size(342, 61);
            this.lblAddNewUser.TabIndex = 4;
            this.lblAddNewUser.Text = "Add New User";
            this.lblAddNewUser.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblForename.Location = new System.Drawing.Point(302, 120);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(126, 29);
            this.lblForename.TabIndex = 5;
            this.lblForename.Text = "Forename";
            this.lblForename.Click += new System.EventHandler(this.lblForename_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSurname.Location = new System.Drawing.Point(302, 210);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(111, 29);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            this.lblSurname.Click += new System.EventHandler(this.lblSurname_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPassword.Location = new System.Drawing.Point(302, 300);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(117, 29);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Location = new System.Drawing.Point(302, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 1);
            this.panel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 1);
            this.panel4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox3.Location = new System.Drawing.Point(0, -11);
            this.textBox3.MaxLength = 5;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 19);
            this.textBox3.TabIndex = 11;
            // 
            // forenameTxt
            // 
            this.forenameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.forenameTxt.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.forenameTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.forenameTxt.Location = new System.Drawing.Point(302, 170);
            this.forenameTxt.MaxLength = 25;
            this.forenameTxt.Name = "forenameTxt";
            this.forenameTxt.Size = new System.Drawing.Size(197, 19);
            this.forenameTxt.TabIndex = 9;
            // 
            // PWLine
            // 
            this.PWLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PWLine.Location = new System.Drawing.Point(302, 370);
            this.PWLine.Name = "PWLine";
            this.PWLine.Size = new System.Drawing.Size(197, 1);
            this.PWLine.TabIndex = 12;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxt.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.passwordTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordTxt.Location = new System.Drawing.Point(300, 350);
            this.passwordTxt.MaxLength = 50;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '•';
            this.passwordTxt.Size = new System.Drawing.Size(197, 19);
            this.passwordTxt.TabIndex = 13;
            // 
            // SNLine
            // 
            this.SNLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SNLine.Location = new System.Drawing.Point(300, 280);
            this.SNLine.Name = "SNLine";
            this.SNLine.Size = new System.Drawing.Size(197, 1);
            this.SNLine.TabIndex = 13;
            // 
            // FNLine
            // 
            this.FNLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.FNLine.Location = new System.Drawing.Point(302, 190);
            this.FNLine.Name = "FNLine";
            this.FNLine.Size = new System.Drawing.Size(197, 1);
            this.FNLine.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(20, 410);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 25);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserIcon
            // 
            this.UserIcon.Image = ((System.Drawing.Image)(resources.GetObject("UserIcon.Image")));
            this.UserIcon.Location = new System.Drawing.Point(570, 40);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(50, 50);
            this.UserIcon.TabIndex = 15;
            this.UserIcon.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(440, 400);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(60, 25);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // surnameTxt
            // 
            this.surnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameTxt.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.surnameTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.surnameTxt.Location = new System.Drawing.Point(300, 260);
            this.surnameTxt.MaxLength = 25;
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(197, 19);
            this.surnameTxt.TabIndex = 11;
            // 
            // lblUserCreated
            // 
            this.lblUserCreated.AutoSize = true;
            this.lblUserCreated.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCreated.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserCreated.Location = new System.Drawing.Point(230, 30);
            this.lblUserCreated.Name = "lblUserCreated";
            this.lblUserCreated.Size = new System.Drawing.Size(341, 61);
            this.lblUserCreated.TabIndex = 17;
            this.lblUserCreated.Text = "User Created!";
            this.lblUserCreated.Visible = false;
            // 
            // lblIsAdmin
            // 
            this.lblIsAdmin.AutoSize = true;
            this.lblIsAdmin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsAdmin.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblIsAdmin.Location = new System.Drawing.Point(230, 380);
            this.lblIsAdmin.Name = "lblIsAdmin";
            this.lblIsAdmin.Size = new System.Drawing.Size(147, 22);
            this.lblIsAdmin.TabIndex = 18;
            this.lblIsAdmin.Text = "Make User Admin?";
            this.lblIsAdmin.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // isAdminCheckBox
            // 
            this.isAdminCheckBox.AutoSize = true;
            this.isAdminCheckBox.Location = new System.Drawing.Point(300, 410);
            this.isAdminCheckBox.Name = "isAdminCheckBox";
            this.isAdminCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isAdminCheckBox.TabIndex = 19;
            this.isAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // lblSuccessfulCreation
            // 
            this.lblSuccessfulCreation.AutoSize = true;
            this.lblSuccessfulCreation.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessfulCreation.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSuccessfulCreation.Location = new System.Drawing.Point(217, 120);
            this.lblSuccessfulCreation.Name = "lblSuccessfulCreation";
            this.lblSuccessfulCreation.Size = new System.Drawing.Size(367, 29);
            this.lblSuccessfulCreation.TabIndex = 20;
            this.lblSuccessfulCreation.Text = "New User Successfully Created!";
            // 
            // lblYourUserID
            // 
            this.lblYourUserID.AutoSize = true;
            this.lblYourUserID.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold);
            this.lblYourUserID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYourUserID.Location = new System.Drawing.Point(240, 210);
            this.lblYourUserID.Name = "lblYourUserID";
            this.lblYourUserID.Size = new System.Drawing.Size(169, 27);
            this.lblYourUserID.TabIndex = 21;
            this.lblYourUserID.Text = "Your User ID is:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold);
            this.lblUserID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserID.Location = new System.Drawing.Point(410, 210);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(78, 27);
            this.lblUserID.TabIndex = 22;
            this.lblUserID.Text = "UserID";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(710, 410);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(70, 25);
            this.btnContinue.TabIndex = 23;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(572, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 1);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(567, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "User ID";
            // 
            // txtboxRemoveUserID
            // 
            this.txtboxRemoveUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxRemoveUserID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.txtboxRemoveUserID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxRemoveUserID.Location = new System.Drawing.Point(570, 274);
            this.txtboxRemoveUserID.MaxLength = 50;
            this.txtboxRemoveUserID.Name = "txtboxRemoveUserID";
            this.txtboxRemoveUserID.PasswordChar = '•';
            this.txtboxRemoveUserID.Size = new System.Drawing.Size(130, 19);
            this.txtboxRemoveUserID.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(706, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 25);
            this.button1.TabIndex = 27;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(565, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Remove Users:";
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxRemoveUserID);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblYourUserID);
            this.Controls.Add(this.lblSuccessfulCreation);
            this.Controls.Add(this.isAdminCheckBox);
            this.Controls.Add(this.lblIsAdmin);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.UserIcon);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.FNLine);
            this.Controls.Add(this.SNLine);
            this.Controls.Add(this.PWLine);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.lblAddNewUser);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.forenameTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.lblUserCreated);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "t";
            this.Load += new System.EventHandler(this.frmNewUser_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewUser;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox forenameTxt;
        private System.Windows.Forms.Panel PWLine;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Panel SNLine;
        private System.Windows.Forms.Panel FNLine;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox UserIcon;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.Label lblUserCreated;
        private System.Windows.Forms.Label lblIsAdmin;
        private System.Windows.Forms.CheckBox isAdminCheckBox;
        private System.Windows.Forms.Label lblSuccessfulCreation;
        private System.Windows.Forms.Label lblYourUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxRemoveUserID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}