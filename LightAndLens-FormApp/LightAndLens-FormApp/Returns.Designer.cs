namespace LightAndLens_FormApp
{
    partial class Returns
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            sidePanel = new Panel();
            rentalTransactionsBtn = new Button();
            analyticsBtn = new Button();
            returnsBtn = new Button();
            rentalRequestsBtn = new Button();
            EquipmentBtn = new Button();
            dashboardBtn = new Button();
            logotxt = new Label();
            topHeaderPanel = new Panel();
            panel1 = new Panel();
            comboBoxFilterConditions = new ComboBox();
            comboBoxFilterStatus = new ComboBox();
            txtSearch = new TextBox();
            btnApply = new Button();
            btnClear = new Button();
            panelListReturns = new Panel();
            dgvListReturns = new DataGridView();
            panelProcessReturn = new Panel();
            btnReturn = new Button();
            checkBoxLate = new CheckBox();
            textBoxDesc = new TextBox();
            label4 = new Label();
            comboBoxSelectCondition = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            labelUserName = new Label();
            pictureBoxAvatar = new PictureBox();
            sidePanel.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            panel1.SuspendLayout();
            panelListReturns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListReturns).BeginInit();
            panelProcessReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(22, 34, 68);
            sidePanel.Controls.Add(rentalTransactionsBtn);
            sidePanel.Controls.Add(analyticsBtn);
            sidePanel.Controls.Add(returnsBtn);
            sidePanel.Controls.Add(rentalRequestsBtn);
            sidePanel.Controls.Add(EquipmentBtn);
            sidePanel.Controls.Add(dashboardBtn);
            sidePanel.Controls.Add(logotxt);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Padding = new Padding(10);
            sidePanel.Size = new Size(230, 825);
            sidePanel.TabIndex = 2;
            // 
            // rentalTransactionsBtn
            // 
            rentalTransactionsBtn.BackColor = Color.Transparent;
            rentalTransactionsBtn.FlatStyle = FlatStyle.Flat;
            rentalTransactionsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rentalTransactionsBtn.ForeColor = Color.White;
            rentalTransactionsBtn.Image = Properties.Resources.Orders;
            rentalTransactionsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            rentalTransactionsBtn.Location = new Point(10, 265);
            rentalTransactionsBtn.Name = "rentalTransactionsBtn";
            rentalTransactionsBtn.Size = new Size(211, 44);
            rentalTransactionsBtn.TabIndex = 7;
            rentalTransactionsBtn.Text = "Transactions";
            rentalTransactionsBtn.UseVisualStyleBackColor = false;
            rentalTransactionsBtn.Click += rentalTransactionsBtn_Click;
            // 
            // analyticsBtn
            // 
            analyticsBtn.BackColor = Color.Transparent;
            analyticsBtn.FlatStyle = FlatStyle.Flat;
            analyticsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            analyticsBtn.ForeColor = Color.White;
            analyticsBtn.Image = Properties.Resources.Analytics;
            analyticsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            analyticsBtn.Location = new Point(10, 388);
            analyticsBtn.Name = "analyticsBtn";
            analyticsBtn.Size = new Size(211, 44);
            analyticsBtn.TabIndex = 5;
            analyticsBtn.Text = "Analytics";
            analyticsBtn.UseVisualStyleBackColor = false;
            analyticsBtn.Click += analyticsBtn_Click;
            // 
            // returnsBtn
            // 
            returnsBtn.BackColor = Color.Transparent;
            returnsBtn.FlatStyle = FlatStyle.Flat;
            returnsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            returnsBtn.ForeColor = Color.White;
            returnsBtn.Image = Properties.Resources.Return__2_;
            returnsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            returnsBtn.Location = new Point(10, 328);
            returnsBtn.Name = "returnsBtn";
            returnsBtn.Size = new Size(211, 44);
            returnsBtn.TabIndex = 4;
            returnsBtn.Text = "Returns";
            returnsBtn.UseVisualStyleBackColor = false;
            // 
            // rentalRequestsBtn
            // 
            rentalRequestsBtn.BackColor = Color.Transparent;
            rentalRequestsBtn.FlatStyle = FlatStyle.Flat;
            rentalRequestsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rentalRequestsBtn.ForeColor = Color.White;
            rentalRequestsBtn.Image = Properties.Resources.Request;
            rentalRequestsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            rentalRequestsBtn.Location = new Point(10, 205);
            rentalRequestsBtn.Name = "rentalRequestsBtn";
            rentalRequestsBtn.Size = new Size(211, 44);
            rentalRequestsBtn.TabIndex = 3;
            rentalRequestsBtn.Text = "Requests";
            rentalRequestsBtn.UseVisualStyleBackColor = false;
            rentalRequestsBtn.Click += rentalRequestsBtn_Click;
            // 
            // EquipmentBtn
            // 
            EquipmentBtn.BackColor = Color.Transparent;
            EquipmentBtn.FlatStyle = FlatStyle.Flat;
            EquipmentBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EquipmentBtn.ForeColor = Color.White;
            EquipmentBtn.Image = Properties.Resources.Equipment2;
            EquipmentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            EquipmentBtn.Location = new Point(10, 145);
            EquipmentBtn.Name = "EquipmentBtn";
            EquipmentBtn.Size = new Size(211, 44);
            EquipmentBtn.TabIndex = 2;
            EquipmentBtn.Text = "Equipment";
            EquipmentBtn.UseVisualStyleBackColor = false;
            EquipmentBtn.Click += EquipmentBtn_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = Color.Transparent;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dashboardBtn.ForeColor = Color.White;
            dashboardBtn.Image = Properties.Resources.Dashboard;
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(10, 85);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(211, 44);
            dashboardBtn.TabIndex = 1;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = false;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // logotxt
            // 
            logotxt.AutoSize = true;
            logotxt.Font = new Font("Vivaldi", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            logotxt.ForeColor = Color.White;
            logotxt.Location = new Point(9, 10);
            logotxt.Name = "logotxt";
            logotxt.Size = new Size(189, 29);
            logotxt.TabIndex = 0;
            logotxt.Text = "Lights And Lenses";
            logotxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // topHeaderPanel
            // 
            topHeaderPanel.BackColor = Color.FromArgb(22, 34, 68);
            topHeaderPanel.Controls.Add(labelUserName);
            topHeaderPanel.Controls.Add(pictureBoxAvatar);
            topHeaderPanel.Dock = DockStyle.Top;
            topHeaderPanel.Location = new Point(230, 0);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Padding = new Padding(10);
            topHeaderPanel.Size = new Size(1120, 60);
            topHeaderPanel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 38, 80);
            panel1.Controls.Add(comboBoxFilterConditions);
            panel1.Controls.Add(comboBoxFilterStatus);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnApply);
            panel1.Controls.Add(btnClear);
            panel1.Location = new Point(271, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 60);
            panel1.TabIndex = 5;
            // 
            // comboBoxFilterConditions
            // 
            comboBoxFilterConditions.BackColor = Color.White;
            comboBoxFilterConditions.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterConditions.FlatStyle = FlatStyle.Flat;
            comboBoxFilterConditions.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxFilterConditions.ForeColor = Color.Black;
            comboBoxFilterConditions.FormattingEnabled = true;
            comboBoxFilterConditions.Items.AddRange(new object[] { "All Conditions", "Good", "Damaged", "Defective" });
            comboBoxFilterConditions.Location = new Point(653, 17);
            comboBoxFilterConditions.Name = "comboBoxFilterConditions";
            comboBoxFilterConditions.Size = new Size(140, 25);
            comboBoxFilterConditions.TabIndex = 4;
            // 
            // comboBoxFilterStatus
            // 
            comboBoxFilterStatus.BackColor = Color.White;
            comboBoxFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterStatus.FlatStyle = FlatStyle.Flat;
            comboBoxFilterStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxFilterStatus.ForeColor = Color.Black;
            comboBoxFilterStatus.FormattingEnabled = true;
            comboBoxFilterStatus.Items.AddRange(new object[] { "All Status", "Returned", "Pending", "Overdue" });
            comboBoxFilterStatus.Location = new Point(494, 17);
            comboBoxFilterStatus.Name = "comboBoxFilterStatus";
            comboBoxFilterStatus.Size = new Size(140, 25);
            comboBoxFilterStatus.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(15, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(461, 25);
            txtSearch.TabIndex = 2;
            txtSearch.Text = "        Search by customer or equipment name";
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.FromArgb(18, 80, 198);
            btnApply.FlatAppearance.BorderColor = Color.FromArgb(31, 41, 55);
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnApply.ForeColor = Color.White;
            btnApply.Image = Properties.Resources.Filter;
            btnApply.ImageAlign = ContentAlignment.MiddleLeft;
            btnApply.Location = new Point(818, 14);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(98, 32);
            btnApply.TabIndex = 1;
            btnApply.Text = "Apply";
            btnApply.TextAlign = ContentAlignment.MiddleRight;
            btnApply.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(31, 41, 55);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Image = Properties.Resources.FilterOff;
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.Location = new Point(932, 14);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 32);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.UseVisualStyleBackColor = false;
            // 
            // panelListReturns
            // 
            panelListReturns.BackColor = Color.FromArgb(23, 38, 80);
            panelListReturns.Controls.Add(dgvListReturns);
            panelListReturns.Location = new Point(270, 195);
            panelListReturns.Name = "panelListReturns";
            panelListReturns.Size = new Size(698, 375);
            panelListReturns.TabIndex = 15;
            // 
            // dgvListReturns
            // 
            dgvListReturns.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(18, 80, 198);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListReturns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListReturns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListReturns.Dock = DockStyle.Fill;
            dgvListReturns.Location = new Point(0, 0);
            dgvListReturns.Name = "dgvListReturns";
            dgvListReturns.RowTemplate.Height = 25;
            dgvListReturns.Size = new Size(698, 375);
            dgvListReturns.TabIndex = 0;
            // 
            // panelProcessReturn
            // 
            panelProcessReturn.BackColor = Color.FromArgb(23, 38, 80);
            panelProcessReturn.Controls.Add(btnReturn);
            panelProcessReturn.Controls.Add(checkBoxLate);
            panelProcessReturn.Controls.Add(textBoxDesc);
            panelProcessReturn.Controls.Add(label4);
            panelProcessReturn.Controls.Add(comboBoxSelectCondition);
            panelProcessReturn.Controls.Add(label2);
            panelProcessReturn.Controls.Add(label3);
            panelProcessReturn.Location = new Point(988, 195);
            panelProcessReturn.Name = "panelProcessReturn";
            panelProcessReturn.Size = new Size(319, 375);
            panelProcessReturn.TabIndex = 16;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.SeaGreen;
            btnReturn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(22, 310);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(277, 39);
            btnReturn.TabIndex = 9;
            btnReturn.Text = "Mark as Returned";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // checkBoxLate
            // 
            checkBoxLate.AutoSize = true;
            checkBoxLate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxLate.ForeColor = Color.White;
            checkBoxLate.Location = new Point(29, 273);
            checkBoxLate.Name = "checkBoxLate";
            checkBoxLate.Size = new Size(98, 21);
            checkBoxLate.TabIndex = 8;
            checkBoxLate.Text = "Late Return";
            checkBoxLate.UseVisualStyleBackColor = true;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(22, 163);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(277, 23);
            textBoxDesc.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 141);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 6;
            label4.Text = "Return notes";
            // 
            // comboBoxSelectCondition
            // 
            comboBoxSelectCondition.BackColor = Color.White;
            comboBoxSelectCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectCondition.FlatStyle = FlatStyle.Flat;
            comboBoxSelectCondition.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxSelectCondition.ForeColor = Color.Black;
            comboBoxSelectCondition.FormattingEnabled = true;
            comboBoxSelectCondition.Items.AddRange(new object[] { "Select Condition", "Good Condition", "Damaged", "Defective" });
            comboBoxSelectCondition.Location = new Point(22, 86);
            comboBoxSelectCondition.Name = "comboBoxSelectCondition";
            comboBoxSelectCondition.Size = new Size(277, 25);
            comboBoxSelectCondition.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 64);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 3;
            label2.Text = "Condition";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(83, 3);
            label3.Name = "label3";
            label3.Size = new Size(158, 30);
            label3.TabIndex = 2;
            label3.Text = "Process Return";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.ForeColor = Color.White;
            labelUserName.Location = new Point(951, 21);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(94, 21);
            labelUserName.TabIndex = 26;
            labelUserName.Text = "User Name";
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Image = Properties.Resources.Avatar;
            pictureBoxAvatar.Location = new Point(1053, 9);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(43, 43);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 27;
            pictureBoxAvatar.TabStop = false;
            // 
            // Returns
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 28, 58);
            ClientSize = new Size(1350, 825);
            Controls.Add(panelProcessReturn);
            Controls.Add(panelListReturns);
            Controls.Add(panel1);
            Controls.Add(topHeaderPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Returns";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Returns";
            FormClosing += Returns_FormClosing;
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            topHeaderPanel.ResumeLayout(false);
            topHeaderPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelListReturns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListReturns).EndInit();
            panelProcessReturn.ResumeLayout(false);
            panelProcessReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Button analyticsBtn;
        private Button returnsBtn;
        private Button rentalRequestsBtn;
        private Button EquipmentBtn;
        private Button dashboardBtn;
        private Label logotxt;
        private Panel topHeaderPanel;
        private Panel panel1;
        private ComboBox comboBoxFilterConditions;
        private ComboBox comboBoxFilterStatus;
        private TextBox txtSearch;
        private Button btnApply;
        private Button btnClear;
        private Panel panelListReturns;
        private DataGridView dgvListReturns;
        private Panel panelProcessReturn;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxSelectCondition;
        private TextBox textBoxDesc;
        private Label label4;
        private CheckBox checkBoxLate;
        private Button btnReturn;
        private Button rentalTransactionsBtn;
        private Label labelUserName;
        private PictureBox pictureBoxAvatar;
    }
}