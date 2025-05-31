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
            labelUserName = new Label();
            pictureBoxAvatar = new PictureBox();
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
            textBoxReturnNotes = new TextBox();
            label4 = new Label();
            comboBoxSelectCondition = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            sidePanel.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            panel1.SuspendLayout();
            panelListReturns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListReturns).BeginInit();
            panelProcessReturn.SuspendLayout();
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
            sidePanel.Margin = new Padding(3, 4, 3, 4);
            sidePanel.Name = "sidePanel";
            sidePanel.Padding = new Padding(11, 13, 11, 13);
            sidePanel.Size = new Size(263, 1055);
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
            rentalTransactionsBtn.Location = new Point(11, 353);
            rentalTransactionsBtn.Margin = new Padding(3, 4, 3, 4);
            rentalTransactionsBtn.Name = "rentalTransactionsBtn";
            rentalTransactionsBtn.Size = new Size(241, 59);
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
            analyticsBtn.Location = new Point(11, 517);
            analyticsBtn.Margin = new Padding(3, 4, 3, 4);
            analyticsBtn.Name = "analyticsBtn";
            analyticsBtn.Size = new Size(241, 59);
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
            returnsBtn.Location = new Point(11, 437);
            returnsBtn.Margin = new Padding(3, 4, 3, 4);
            returnsBtn.Name = "returnsBtn";
            returnsBtn.Size = new Size(241, 59);
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
            rentalRequestsBtn.Location = new Point(11, 273);
            rentalRequestsBtn.Margin = new Padding(3, 4, 3, 4);
            rentalRequestsBtn.Name = "rentalRequestsBtn";
            rentalRequestsBtn.Size = new Size(241, 59);
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
            EquipmentBtn.Location = new Point(11, 193);
            EquipmentBtn.Margin = new Padding(3, 4, 3, 4);
            EquipmentBtn.Name = "EquipmentBtn";
            EquipmentBtn.Size = new Size(241, 59);
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
            dashboardBtn.Location = new Point(11, 113);
            dashboardBtn.Margin = new Padding(3, 4, 3, 4);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(241, 59);
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
            logotxt.Location = new Point(10, 13);
            logotxt.Name = "logotxt";
            logotxt.Size = new Size(235, 36);
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
            topHeaderPanel.Location = new Point(263, 0);
            topHeaderPanel.Margin = new Padding(3, 4, 3, 4);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Padding = new Padding(11, 13, 11, 13);
            topHeaderPanel.Size = new Size(1280, 80);
            topHeaderPanel.TabIndex = 3;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.ForeColor = Color.White;
            labelUserName.Location = new Point(1087, 28);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(116, 28);
            labelUserName.TabIndex = 26;
            labelUserName.Text = "User Name";
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Image = Properties.Resources.Avatar;
            pictureBoxAvatar.Location = new Point(1203, 12);
            pictureBoxAvatar.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(49, 57);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 27;
            pictureBoxAvatar.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 38, 80);
            panel1.Controls.Add(comboBoxFilterConditions);
            panel1.Controls.Add(comboBoxFilterStatus);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnApply);
            panel1.Controls.Add(btnClear);
            panel1.Location = new Point(310, 113);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 80);
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
            comboBoxFilterConditions.Location = new Point(746, 23);
            comboBoxFilterConditions.Margin = new Padding(3, 4, 3, 4);
            comboBoxFilterConditions.Name = "comboBoxFilterConditions";
            comboBoxFilterConditions.Size = new Size(159, 29);
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
            comboBoxFilterStatus.Location = new Point(565, 23);
            comboBoxFilterStatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxFilterStatus.Name = "comboBoxFilterStatus";
            comboBoxFilterStatus.Size = new Size(159, 29);
            comboBoxFilterStatus.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(17, 23);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by equipment or customer name";
            txtSearch.Size = new Size(527, 29);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            btnApply.Location = new Point(935, 19);
            btnApply.Margin = new Padding(3, 4, 3, 4);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(112, 43);
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
            btnClear.Location = new Point(1065, 19);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 43);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.UseVisualStyleBackColor = false;
            // 
            // panelListReturns
            // 
            panelListReturns.BackColor = Color.FromArgb(23, 38, 80);
            panelListReturns.Controls.Add(dgvListReturns);
            panelListReturns.Location = new Point(309, 260);
            panelListReturns.Margin = new Padding(3, 4, 3, 4);
            panelListReturns.Name = "panelListReturns";
            panelListReturns.Size = new Size(798, 500);
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
            dgvListReturns.Margin = new Padding(3, 4, 3, 4);
            dgvListReturns.Name = "dgvListReturns";
            dgvListReturns.RowHeadersWidth = 51;
            dgvListReturns.RowTemplate.Height = 25;
            dgvListReturns.Size = new Size(798, 500);
            dgvListReturns.TabIndex = 0;
            dgvListReturns.SelectionChanged += dgvListReturns_SelectionChanged;
            // 
            // panelProcessReturn
            // 
            panelProcessReturn.BackColor = Color.FromArgb(23, 38, 80);
            panelProcessReturn.Controls.Add(btnReturn);
            panelProcessReturn.Controls.Add(textBoxReturnNotes);
            panelProcessReturn.Controls.Add(label4);
            panelProcessReturn.Controls.Add(comboBoxSelectCondition);
            panelProcessReturn.Controls.Add(label2);
            panelProcessReturn.Controls.Add(label3);
            panelProcessReturn.Location = new Point(1129, 260);
            panelProcessReturn.Margin = new Padding(3, 4, 3, 4);
            panelProcessReturn.Name = "panelProcessReturn";
            panelProcessReturn.Size = new Size(365, 500);
            panelProcessReturn.TabIndex = 16;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.SeaGreen;
            btnReturn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(25, 413);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(317, 52);
            btnReturn.TabIndex = 9;
            btnReturn.Text = "Mark as Returned";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // textBoxReturnNotes
            // 
            textBoxReturnNotes.Location = new Point(25, 217);
            textBoxReturnNotes.Margin = new Padding(3, 4, 3, 4);
            textBoxReturnNotes.Name = "textBoxReturnNotes";
            textBoxReturnNotes.Size = new Size(316, 27);
            textBoxReturnNotes.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 188);
            label4.Name = "label4";
            label4.Size = new Size(112, 23);
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
            comboBoxSelectCondition.Location = new Point(25, 115);
            comboBoxSelectCondition.Margin = new Padding(3, 4, 3, 4);
            comboBoxSelectCondition.Name = "comboBoxSelectCondition";
            comboBoxSelectCondition.Size = new Size(316, 29);
            comboBoxSelectCondition.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 85);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 3;
            label2.Text = "Condition";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(95, 4);
            label3.Name = "label3";
            label3.Size = new Size(207, 37);
            label3.TabIndex = 2;
            label3.Text = "Process Return";
            // 
            // Returns
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 28, 58);
            ClientSize = new Size(1543, 1055);
            Controls.Add(panelProcessReturn);
            Controls.Add(panelListReturns);
            Controls.Add(panel1);
            Controls.Add(topHeaderPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Returns";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Returns";
            FormClosing += Returns_FormClosing;
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            topHeaderPanel.ResumeLayout(false);
            topHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelListReturns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListReturns).EndInit();
            panelProcessReturn.ResumeLayout(false);
            panelProcessReturn.PerformLayout();
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
        private TextBox textBoxReturnNotes;
        private Label label4;
        private Button btnReturn;
        private Button rentalTransactionsBtn;
        private Label labelUserName;
        private PictureBox pictureBoxAvatar;
    }
}