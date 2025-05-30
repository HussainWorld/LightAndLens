namespace LightAndLens_FormApp
{
    partial class Login
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            recentActivitiesTxt = new Label();
            lblAvailability = new Label();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            checkBoxShowPassword = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(22, 34, 68);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 507);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(224, 232, 255);
            panel2.Controls.Add(checkBoxShowPassword);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxPassword);
            panel2.Controls.Add(textBoxEmail);
            panel2.Controls.Add(lblAvailability);
            panel2.Controls.Add(recentActivitiesTxt);
            panel2.Location = new Point(405, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 507);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vivaldi", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 313);
            label1.Name = "label1";
            label1.Size = new Size(379, 64);
            label1.TabIndex = 2;
            label1.Text = "Lighting Up Creativity, \r\n                  One Lens at a Time.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(29, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 354);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // recentActivitiesTxt
            // 
            recentActivitiesTxt.AutoSize = true;
            recentActivitiesTxt.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            recentActivitiesTxt.ForeColor = Color.Black;
            recentActivitiesTxt.Location = new Point(36, 29);
            recentActivitiesTxt.Name = "recentActivitiesTxt";
            recentActivitiesTxt.Size = new Size(131, 50);
            recentActivitiesTxt.TabIndex = 8;
            recentActivitiesTxt.Text = "Log In";
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvailability.ForeColor = Color.Black;
            lblAvailability.Location = new Point(36, 106);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(57, 21);
            lblAvailability.TabIndex = 12;
            lblAvailability.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(36, 129);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(337, 23);
            textBoxEmail.TabIndex = 19;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(36, 183);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(337, 23);
            textBoxPassword.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(36, 160);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 21;
            label2.Text = "Password:";
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(37, 211);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(108, 19);
            checkBoxShowPassword.TabIndex = 22;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 506);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label recentActivitiesTxt;
        private ComboBox ddlCondition;
        private ComboBox ddlStatus;
        private ComboBox ddlCategory;
        private Label lblCondition;
        private Label lblAvailability;
        private Label lblCategory;
        private Label lblDescription;
        private Label lblName;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private CheckBox checkBoxShowPassword;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
    }
}