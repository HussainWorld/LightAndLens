namespace LightAndLens_FormApp
{
    partial class EquipmentForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            ddlCondition = new ComboBox();
            ddlStatus = new ComboBox();
            ddlCategory = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnAddEquipment = new Button();
            btnEditEquipment = new Button();
            btnDelete = new Button();
            btnRefreshEquipment = new Button();
            dgvListEquipment = new DataGridView();
            panel4 = new Panel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtQuantity = new Label();
            txtCategory = new Label();
            txtCondition = new Label();
            equipmentDetailsTxt = new Label();
            pictureBoxEquipment = new PictureBox();
            lblEquipmentDesc = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            sidePanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListEquipment).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEquipment).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
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
            sidePanel.Size = new Size(230, 791);
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
            rentalTransactionsBtn.TabIndex = 18;
            rentalTransactionsBtn.Text = "  Transactions";
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
            analyticsBtn.Location = new Point(10, 385);
            analyticsBtn.Name = "analyticsBtn";
            analyticsBtn.Size = new Size(211, 44);
            analyticsBtn.TabIndex = 5;
            analyticsBtn.Text = "  Analytics";
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
            returnsBtn.Location = new Point(10, 325);
            returnsBtn.Name = "returnsBtn";
            returnsBtn.Size = new Size(211, 44);
            returnsBtn.TabIndex = 4;
            returnsBtn.Text = "  Returns";
            returnsBtn.UseVisualStyleBackColor = false;
            returnsBtn.Click += returnsBtn_Click;
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
            rentalRequestsBtn.Text = "  Requests";
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
            EquipmentBtn.Text = "  Equipment";
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
            dashboardBtn.Text = "  Dashboard";
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
            panel1.Controls.Add(ddlCondition);
            panel1.Controls.Add(ddlStatus);
            panel1.Controls.Add(ddlCategory);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnClear);
            panel1.Location = new Point(271, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 60);
            panel1.TabIndex = 4;
            // 
            // ddlCondition
            // 
            ddlCondition.BackColor = Color.White;
            ddlCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlCondition.FlatStyle = FlatStyle.Flat;
            ddlCondition.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ddlCondition.ForeColor = Color.Black;
            ddlCondition.FormattingEnabled = true;
            ddlCondition.Location = new Point(653, 17);
            ddlCondition.Name = "ddlCondition";
            ddlCondition.Size = new Size(140, 25);
            ddlCondition.TabIndex = 5;
            // 
            // ddlStatus
            // 
            ddlStatus.BackColor = Color.White;
            ddlStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlStatus.FlatStyle = FlatStyle.Flat;
            ddlStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ddlStatus.ForeColor = Color.Black;
            ddlStatus.FormattingEnabled = true;
            ddlStatus.Location = new Point(494, 17);
            ddlStatus.Name = "ddlStatus";
            ddlStatus.Size = new Size(140, 25);
            ddlStatus.TabIndex = 4;
            // 
            // ddlCategory
            // 
            ddlCategory.BackColor = Color.White;
            ddlCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlCategory.FlatStyle = FlatStyle.Flat;
            ddlCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ddlCategory.ForeColor = Color.Black;
            ddlCategory.FormattingEnabled = true;
            ddlCategory.Location = new Point(336, 17);
            ddlCategory.Name = "ddlCategory";
            ddlCategory.Size = new Size(140, 25);
            ddlCategory.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(15, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search equipment...";
            txtSearch.Size = new Size(280, 25);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(18, 80, 198);
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(31, 41, 55);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = Properties.Resources.Filter;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(811, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(2, 0, 0, 0);
            btnSearch.Size = new Size(105, 30);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Apply  ";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
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
            btnClear.Size = new Size(85, 30);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddEquipment
            // 
            btnAddEquipment.BackColor = Color.SeaGreen;
            btnAddEquipment.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddEquipment.ForeColor = Color.White;
            btnAddEquipment.Image = Properties.Resources.Add2;
            btnAddEquipment.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddEquipment.Location = new Point(830, 157);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Padding = new Padding(12, 0, 0, 0);
            btnAddEquipment.Size = new Size(180, 34);
            btnAddEquipment.TabIndex = 12;
            btnAddEquipment.Text = "Add Equipment       ";
            btnAddEquipment.TextAlign = ContentAlignment.MiddleRight;
            btnAddEquipment.UseVisualStyleBackColor = false;
            btnAddEquipment.Click += btnAddEquipment_Click;
            // 
            // btnEditEquipment
            // 
            btnEditEquipment.BackColor = Color.FromArgb(133, 93, 212);
            btnEditEquipment.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditEquipment.ForeColor = Color.White;
            btnEditEquipment.Image = Properties.Resources.Edit;
            btnEditEquipment.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditEquipment.Location = new Point(1025, 157);
            btnEditEquipment.Name = "btnEditEquipment";
            btnEditEquipment.Padding = new Padding(2, 0, 0, 0);
            btnEditEquipment.Size = new Size(77, 34);
            btnEditEquipment.TabIndex = 13;
            btnEditEquipment.Text = "Edit   ";
            btnEditEquipment.TextAlign = ContentAlignment.MiddleRight;
            btnEditEquipment.UseVisualStyleBackColor = false;
            btnEditEquipment.Click += btnEditEquipment_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(200, 47, 46);
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = Properties.Resources.Delete;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(1118, 157);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(1, 0, 0, 0);
            btnDelete.Size = new Size(87, 34);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete  ";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnRefreshEquipment
            // 
            btnRefreshEquipment.BackColor = Color.Gray;
            btnRefreshEquipment.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefreshEquipment.ForeColor = Color.White;
            btnRefreshEquipment.Image = Properties.Resources.Refresh;
            btnRefreshEquipment.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefreshEquipment.Location = new Point(1221, 157);
            btnRefreshEquipment.Name = "btnRefreshEquipment";
            btnRefreshEquipment.Size = new Size(87, 34);
            btnRefreshEquipment.TabIndex = 15;
            btnRefreshEquipment.Text = "Refresh ";
            btnRefreshEquipment.TextAlign = ContentAlignment.MiddleRight;
            btnRefreshEquipment.UseVisualStyleBackColor = false;
            btnRefreshEquipment.Click += btnRefreshEquipment_Click;
            // 
            // dgvListEquipment
            // 
            dgvListEquipment.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(209, 213, 219);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(18, 80, 198);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvListEquipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvListEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListEquipment.Dock = DockStyle.Fill;
            dgvListEquipment.Location = new Point(0, 0);
            dgvListEquipment.Name = "dgvListEquipment";
            dgvListEquipment.RowHeadersWidth = 51;
            dgvListEquipment.RowTemplate.Height = 25;
            dgvListEquipment.Size = new Size(760, 262);
            dgvListEquipment.TabIndex = 16;
            dgvListEquipment.SelectionChanged += dgvEquipment_SelectionChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(38, 59, 121);
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(txtQuantity);
            panel4.Controls.Add(txtCategory);
            panel4.Controls.Add(txtCondition);
            panel4.Location = new Point(25, 196);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 91);
            panel4.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(5, 8);
            label6.Name = "label6";
            label6.Size = new Size(68, 17);
            label6.TabIndex = 20;
            label6.Text = "Category:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(5, 35);
            label7.Name = "label7";
            label7.Size = new Size(73, 17);
            label7.TabIndex = 21;
            label7.Text = "Condition:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(5, 62);
            label8.Name = "label8";
            label8.Size = new Size(66, 17);
            label8.TabIndex = 22;
            label8.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.AutoSize = true;
            txtQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtQuantity.ForeColor = Color.White;
            txtQuantity.Location = new Point(105, 62);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(22, 17);
            txtQuantity.TabIndex = 25;
            txtQuantity.Text = "10";
            // 
            // txtCategory
            // 
            txtCategory.AutoSize = true;
            txtCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCategory.ForeColor = Color.White;
            txtCategory.Location = new Point(82, 8);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(75, 17);
            txtCategory.TabIndex = 23;
            txtCategory.Text = "Equipment";
            // 
            // txtCondition
            // 
            txtCondition.AutoSize = true;
            txtCondition.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCondition.ForeColor = Color.White;
            txtCondition.Location = new Point(84, 35);
            txtCondition.Name = "txtCondition";
            txtCondition.Size = new Size(63, 17);
            txtCondition.TabIndex = 24;
            txtCondition.Text = "Excellent";
            // 
            // equipmentDetailsTxt
            // 
            equipmentDetailsTxt.AutoSize = true;
            equipmentDetailsTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            equipmentDetailsTxt.ForeColor = Color.White;
            equipmentDetailsTxt.Location = new Point(24, 6);
            equipmentDetailsTxt.Name = "equipmentDetailsTxt";
            equipmentDetailsTxt.Size = new Size(173, 25);
            equipmentDetailsTxt.TabIndex = 19;
            equipmentDetailsTxt.Text = "Equipment Details";
            // 
            // pictureBoxEquipment
            // 
            pictureBoxEquipment.BackColor = SystemColors.ActiveCaption;
            pictureBoxEquipment.Location = new Point(25, 35);
            pictureBoxEquipment.Name = "pictureBoxEquipment";
            pictureBoxEquipment.Size = new Size(220, 155);
            pictureBoxEquipment.TabIndex = 0;
            pictureBoxEquipment.TabStop = false;
            // 
            // lblEquipmentDesc
            // 
            lblEquipmentDesc.AutoSize = true;
            lblEquipmentDesc.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEquipmentDesc.ForeColor = Color.White;
            lblEquipmentDesc.Location = new Point(27, 338);
            lblEquipmentDesc.Name = "lblEquipmentDesc";
            lblEquipmentDesc.Size = new Size(214, 80);
            lblEquipmentDesc.TabIndex = 28;
            lblEquipmentDesc.Text = "a very long and boring Descri\r\nption a very long and boring \r\nDescription a very long and\r\nboring Description\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 309);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 26;
            label4.Text = "Description";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 38, 80);
            panel2.Controls.Add(dgvListEquipment);
            panel2.Location = new Point(271, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 262);
            panel2.TabIndex = 30;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(23, 38, 80);
            panel5.Controls.Add(lblEquipmentDesc);
            panel5.Controls.Add(equipmentDetailsTxt);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(pictureBoxEquipment);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(1037, 197);
            panel5.Name = "panel5";
            panel5.Size = new Size(271, 572);
            panel5.TabIndex = 30;
            // 
            // EquipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 28, 58);
            ClientSize = new Size(1350, 791);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(btnRefreshEquipment);
            Controls.Add(btnDelete);
            Controls.Add(btnEditEquipment);
            Controls.Add(btnAddEquipment);
            Controls.Add(panel1);
            Controls.Add(topHeaderPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EquipmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipment";
            FormClosing += EquipmentForm_FormClosing;
            FormClosed += EquipmentForm_FormClosed;
            Load += Equipment_Load;
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListEquipment).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEquipment).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private ComboBox ddlCategory;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClear;
        private ComboBox ddlCondition;
        private ComboBox ddlStatus;
        private Button btnAddEquipment;
        private Button btnEditEquipment;
        private Button btnDelete;
        private Button btnRefreshEquipment;
        private DataGridView dgvListEquipment;
        private PictureBox pictureBoxEquipment;
        private Label equipmentDetailsTxt;
        private Label txtQuantity;
        private Label txtCondition;
        private Label txtCategory;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label lblEquipmentDesc;
        private Label label4;
        private Button rentalTransactionsBtn;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
    }
}