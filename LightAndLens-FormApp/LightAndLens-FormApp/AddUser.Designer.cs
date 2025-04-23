namespace LightAndLens_FormApp
{
    partial class AddUser
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
            cmbRoles = new ComboBox();
            lblRole = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblFullName = new Label();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            btnCancel = new Button();
            btnAddUser = new Button();
            txtPhone = new TextBox();
            label1 = new Label();
            lblFullNameError = new Label();
            lblEmailError = new Label();
            lblPhoneError = new Label();
            lblRoleError = new Label();
            SuspendLayout();
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(208, 193);
            cmbRoles.Margin = new Padding(3, 2, 3, 2);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(177, 23);
            cmbRoles.TabIndex = 15;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(43, 195);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(48, 21);
            lblRole.TabIndex = 10;
            lblRole.Text = "Role:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(43, 142);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(63, 21);
            lblPhone.TabIndex = 11;
            lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(43, 97);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFullName.ForeColor = Color.White;
            lblFullName.Location = new Point(43, 48);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(92, 21);
            lblFullName.TabIndex = 13;
            lblFullName.Text = "Full Name:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(208, 95);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(208, 48);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(177, 23);
            txtFullName.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(112, 279);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Green;
            btnAddUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddUser.ForeColor = SystemColors.ButtonFace;
            btnAddUser.Location = new Point(238, 279);
            btnAddUser.Margin = new Padding(3, 2, 3, 2);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(94, 28);
            btnAddUser.TabIndex = 18;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(208, 144);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(177, 23);
            txtPhone.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 77);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 21;
            // 
            // lblFullNameError
            // 
            lblFullNameError.AutoSize = true;
            lblFullNameError.ForeColor = Color.Red;
            lblFullNameError.Location = new Point(207, 74);
            lblFullNameError.Name = "lblFullNameError";
            lblFullNameError.Size = new Size(0, 15);
            lblFullNameError.TabIndex = 22;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(208, 122);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(0, 15);
            lblEmailError.TabIndex = 23;
            // 
            // lblPhoneError
            // 
            lblPhoneError.AutoSize = true;
            lblPhoneError.ForeColor = Color.Red;
            lblPhoneError.Location = new Point(208, 171);
            lblPhoneError.Name = "lblPhoneError";
            lblPhoneError.Size = new Size(0, 15);
            lblPhoneError.TabIndex = 24;
            // 
            // lblRoleError
            // 
            lblRoleError.AutoSize = true;
            lblRoleError.ForeColor = Color.Red;
            lblRoleError.Location = new Point(208, 223);
            lblRoleError.Name = "lblRoleError";
            lblRoleError.Size = new Size(0, 15);
            lblRoleError.TabIndex = 25;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(434, 338);
            Controls.Add(lblRoleError);
            Controls.Add(lblPhoneError);
            Controls.Add(lblEmailError);
            Controls.Add(lblFullNameError);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(btnCancel);
            Controls.Add(btnAddUser);
            Controls.Add(cmbRoles);
            Controls.Add(lblRole);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblFullName);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Name = "AddUser";
            Text = "AddUser";
            Load += AddUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbRoles;
        private Label lblRole;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblFullName;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private Button btnCancel;
        private Button btnAddUser;
        private TextBox txtPhone;
        private Label label1;
        private Label lblFullNameError;
        private Label lblEmailError;
        private Label lblPhoneError;
        private Label lblRoleError;
    }
}