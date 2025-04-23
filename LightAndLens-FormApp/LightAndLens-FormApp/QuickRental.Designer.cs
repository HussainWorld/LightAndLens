namespace LightAndLens_FormApp
{
    partial class QuickRental
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            processReturnBtn = new Button();
            addNewUserBtn = new Button();
            lblRole = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblFullName = new Label();
            lblSearch = new Label();
            btnSearch = new Button();
            panelSelectedUser = new Panel();
            txtSearch = new TextBox();
            lblUserInfo = new Label();
            clbCameras = new CheckedListBox();
            clbLenses = new CheckedListBox();
            clbLights = new CheckedListBox();
            clbAccessories = new CheckedListBox();
            lblStartDate = new Label();
            lblEndDate = new Label();
            lblRentalFee = new Label();
            lblDeposit = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            txtFee = new TextBox();
            txtDeposit = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panelSelectedUser.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 41, 55);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(panelSelectedUser);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(lblSearch);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 166);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 41, 55);
            panel2.Controls.Add(clbCameras);
            panel2.Controls.Add(lblFullName);
            panel2.Location = new Point(12, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 180);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(31, 41, 55);
            panel3.Controls.Add(clbLenses);
            panel3.Controls.Add(lblEmail);
            panel3.Location = new Point(201, 202);
            panel3.Name = "panel3";
            panel3.Size = new Size(167, 180);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(31, 41, 55);
            panel4.Controls.Add(clbLights);
            panel4.Controls.Add(lblPhone);
            panel4.Location = new Point(391, 202);
            panel4.Name = "panel4";
            panel4.Size = new Size(167, 180);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(31, 41, 55);
            panel5.Controls.Add(clbAccessories);
            panel5.Controls.Add(lblRole);
            panel5.Location = new Point(585, 202);
            panel5.Name = "panel5";
            panel5.Size = new Size(167, 180);
            panel5.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(31, 41, 55);
            panel6.Controls.Add(txtDeposit);
            panel6.Controls.Add(txtFee);
            panel6.Controls.Add(dtpEndDate);
            panel6.Controls.Add(dtpStartDate);
            panel6.Controls.Add(lblDeposit);
            panel6.Controls.Add(lblRentalFee);
            panel6.Controls.Add(lblEndDate);
            panel6.Controls.Add(lblStartDate);
            panel6.Location = new Point(12, 405);
            panel6.Name = "panel6";
            panel6.Size = new Size(740, 167);
            panel6.TabIndex = 1;
            // 
            // processReturnBtn
            // 
            processReturnBtn.BackColor = Color.Red;
            processReturnBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            processReturnBtn.ForeColor = Color.White;
            processReturnBtn.Location = new Point(629, 592);
            processReturnBtn.Name = "processReturnBtn";
            processReturnBtn.Size = new Size(123, 42);
            processReturnBtn.TabIndex = 12;
            processReturnBtn.Text = "Cancel";
            processReturnBtn.UseVisualStyleBackColor = false;
            // 
            // addNewUserBtn
            // 
            addNewUserBtn.BackColor = Color.Green;
            addNewUserBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addNewUserBtn.ForeColor = Color.White;
            addNewUserBtn.Location = new Point(12, 592);
            addNewUserBtn.Name = "addNewUserBtn";
            addNewUserBtn.Size = new Size(611, 42);
            addNewUserBtn.TabIndex = 11;
            addNewUserBtn.Text = "Confirm Rental";
            addNewUserBtn.UseVisualStyleBackColor = false;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(4, 8);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(97, 21);
            lblRole.TabIndex = 14;
            lblRole.Text = "Accessories";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(4, 8);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(56, 21);
            lblPhone.TabIndex = 15;
            lblPhone.Text = "Lights";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(4, 8);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 21);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Lenses";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFullName.ForeColor = Color.White;
            lblFullName.Location = new Point(4, 8);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(75, 21);
            lblFullName.TabIndex = 17;
            lblFullName.Text = "Cameras";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(4, 3);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(138, 21);
            lblSearch.TabIndex = 18;
            lblSearch.Text = "Customer Search";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(628, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 26);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // panelSelectedUser
            // 
            panelSelectedUser.BackColor = Color.SlateGray;
            panelSelectedUser.Controls.Add(lblUserInfo);
            panelSelectedUser.Location = new Point(14, 77);
            panelSelectedUser.Name = "panelSelectedUser";
            panelSelectedUser.Size = new Size(712, 76);
            panelSelectedUser.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(14, 37);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(608, 23);
            txtSearch.TabIndex = 19;
            txtSearch.Text = "Search by phone or full name";
            // 
            // lblUserInfo
            // 
            lblUserInfo.AutoSize = true;
            lblUserInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserInfo.ForeColor = Color.White;
            lblUserInfo.Location = new Point(13, 14);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(124, 42);
            lblUserInfo.TabIndex = 20;
            lblUserInfo.Text = " Jaffer Mossa\r\n+973 12345678\r\n";
            lblUserInfo.Click += label1_Click;
            // 
            // clbCameras
            // 
            clbCameras.BackColor = Color.SlateGray;
            clbCameras.BorderStyle = BorderStyle.FixedSingle;
            clbCameras.FormattingEnabled = true;
            clbCameras.Location = new Point(6, 32);
            clbCameras.Name = "clbCameras";
            clbCameras.Size = new Size(155, 128);
            clbCameras.TabIndex = 18;
            // 
            // clbLenses
            // 
            clbLenses.BackColor = Color.SlateGray;
            clbLenses.BorderStyle = BorderStyle.FixedSingle;
            clbLenses.FormattingEnabled = true;
            clbLenses.Location = new Point(6, 32);
            clbLenses.Name = "clbLenses";
            clbLenses.Size = new Size(155, 128);
            clbLenses.TabIndex = 19;
            // 
            // clbLights
            // 
            clbLights.BackColor = Color.SlateGray;
            clbLights.BorderStyle = BorderStyle.FixedSingle;
            clbLights.FormattingEnabled = true;
            clbLights.Location = new Point(6, 32);
            clbLights.Name = "clbLights";
            clbLights.Size = new Size(155, 128);
            clbLights.TabIndex = 20;
            // 
            // clbAccessories
            // 
            clbAccessories.BackColor = Color.SlateGray;
            clbAccessories.BorderStyle = BorderStyle.FixedSingle;
            clbAccessories.FormattingEnabled = true;
            clbAccessories.Location = new Point(7, 32);
            clbAccessories.Name = "clbAccessories";
            clbAccessories.Size = new Size(155, 128);
            clbAccessories.TabIndex = 21;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStartDate.ForeColor = Color.White;
            lblStartDate.Location = new Point(13, 12);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(86, 21);
            lblStartDate.TabIndex = 20;
            lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndDate.ForeColor = Color.White;
            lblEndDate.Location = new Point(423, 12);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(79, 21);
            lblEndDate.TabIndex = 21;
            lblEndDate.Text = "End Date";
            // 
            // lblRentalFee
            // 
            lblRentalFee.AutoSize = true;
            lblRentalFee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRentalFee.ForeColor = Color.White;
            lblRentalFee.Location = new Point(14, 84);
            lblRentalFee.Name = "lblRentalFee";
            lblRentalFee.Size = new Size(114, 21);
            lblRentalFee.TabIndex = 22;
            lblRentalFee.Text = "Rental Fee ($)";
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeposit.ForeColor = Color.White;
            lblDeposit.Location = new Point(423, 84);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(94, 21);
            lblDeposit.TabIndex = 21;
            lblDeposit.Text = "Deposit ($)";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(14, 49);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(282, 23);
            dtpStartDate.TabIndex = 13;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(427, 49);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(282, 23);
            dtpEndDate.TabIndex = 23;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(14, 119);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(282, 23);
            txtFee.TabIndex = 20;
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(427, 119);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(282, 23);
            txtDeposit.TabIndex = 24;
            // 
            // QuickRental
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(764, 650);
            Controls.Add(processReturnBtn);
            Controls.Add(addNewUserBtn);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "QuickRental";
            Text = "QuickRental";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panelSelectedUser.ResumeLayout(false);
            panelSelectedUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button processReturnBtn;
        private Button addNewUserBtn;
        private Label lblSearch;
        private Label lblFullName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblRole;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panelSelectedUser;
        private Label lblUserInfo;
        private CheckedListBox clbCameras;
        private CheckedListBox clbLenses;
        private CheckedListBox clbLights;
        private CheckedListBox clbAccessories;
        private Label lblDeposit;
        private Label lblRentalFee;
        private Label lblEndDate;
        private Label lblStartDate;
        private TextBox txtDeposit;
        private TextBox txtFee;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
    }
}