namespace LightAndLens_FormApp
{
    partial class RentalRequests
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
            sidePanel = new Panel();
            analyticsBtn = new Button();
            returnsBtn = new Button();
            rentalRequestsBtn = new Button();
            EquipmentBtn = new Button();
            dashboardBtn = new Button();
            logotxt = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            topHeaderPanel = new Panel();
            label5 = new Label();
            panel1 = new Panel();
            dateTimePickerTo = new DateTimePicker();
            dateTimePickerFrom = new DateTimePicker();
            cmbStatusFilter = new ComboBox();
            txtSearchCustOrEq = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            label4 = new Label();
            rentalRequestsPnl = new Panel();
            dgvRentalRequests = new DataGridView();
            label2 = new Label();
            requestDetailsPnl = new Panel();
            btnReject = new Button();
            btnApprove = new Button();
            panel3 = new Panel();
            lblPurpose = new Label();
            lblRentPeriod = new Label();
            lblEqName = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBoxCust = new PictureBox();
            lblCustName = new Label();
            label3 = new Label();
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            topHeaderPanel.SuspendLayout();
            panel1.SuspendLayout();
            rentalRequestsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalRequests).BeginInit();
            requestDetailsPnl.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCust).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(31, 41, 55);
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
            sidePanel.TabIndex = 1;
            // 
            // analyticsBtn
            // 
            analyticsBtn.BackColor = Color.Transparent;
            analyticsBtn.FlatStyle = FlatStyle.Flat;
            analyticsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            analyticsBtn.ForeColor = Color.LightGray;
            analyticsBtn.Location = new Point(10, 325);
            analyticsBtn.Name = "analyticsBtn";
            analyticsBtn.Size = new Size(211, 44);
            analyticsBtn.TabIndex = 5;
            analyticsBtn.Text = "Analytics";
            analyticsBtn.UseVisualStyleBackColor = false;
            // 
            // returnsBtn
            // 
            returnsBtn.BackColor = Color.Transparent;
            returnsBtn.FlatStyle = FlatStyle.Flat;
            returnsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            returnsBtn.ForeColor = Color.LightGray;
            returnsBtn.Location = new Point(10, 265);
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
            rentalRequestsBtn.ForeColor = Color.LightGray;
            rentalRequestsBtn.Location = new Point(10, 205);
            rentalRequestsBtn.Name = "rentalRequestsBtn";
            rentalRequestsBtn.Size = new Size(211, 44);
            rentalRequestsBtn.TabIndex = 3;
            rentalRequestsBtn.Text = "Rental Requests";
            rentalRequestsBtn.UseVisualStyleBackColor = false;
            // 
            // EquipmentBtn
            // 
            EquipmentBtn.BackColor = Color.Transparent;
            EquipmentBtn.FlatStyle = FlatStyle.Flat;
            EquipmentBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EquipmentBtn.ForeColor = Color.LightGray;
            EquipmentBtn.Location = new Point(10, 145);
            EquipmentBtn.Name = "EquipmentBtn";
            EquipmentBtn.Size = new Size(211, 44);
            EquipmentBtn.TabIndex = 2;
            EquipmentBtn.Text = "Equipment";
            EquipmentBtn.UseVisualStyleBackColor = false;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = Color.Transparent;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dashboardBtn.ForeColor = Color.LightGray;
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(46, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 15);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(55, 65, 81);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(209, 213, 219);
            textBox1.Location = new Point(42, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 22);
            textBox1.TabIndex = 0;
            textBox1.Text = "       Search...";
            // 
            // topHeaderPanel
            // 
            topHeaderPanel.BackColor = Color.FromArgb(31, 41, 55);
            topHeaderPanel.Controls.Add(label5);
            topHeaderPanel.Controls.Add(pictureBox1);
            topHeaderPanel.Controls.Add(textBox1);
            topHeaderPanel.Dock = DockStyle.Top;
            topHeaderPanel.Location = new Point(230, 0);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Padding = new Padding(10);
            topHeaderPanel.Size = new Size(1120, 60);
            topHeaderPanel.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(288, 33);
            label5.Name = "label5";
            label5.Size = new Size(340, 21);
            label5.TabIndex = 9;
            label5.Text = "Filter options Already set in Item Collection";
            label5.Click += label5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 41, 55);
            panel1.Controls.Add(dateTimePickerTo);
            panel1.Controls.Add(dateTimePickerFrom);
            panel1.Controls.Add(cmbStatusFilter);
            panel1.Controls.Add(txtSearchCustOrEq);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(271, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 60);
            panel1.TabIndex = 3;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerTo.Location = new Point(636, 19);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(195, 23);
            dateTimePickerTo.TabIndex = 5;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.CalendarFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerFrom.Location = new Point(423, 19);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(188, 23);
            dateTimePickerFrom.TabIndex = 4;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.BackColor = Color.FromArgb(76, 85, 100);
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FlatStyle = FlatStyle.Flat;
            cmbStatusFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cmbStatusFilter.ForeColor = Color.LightGray;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Location = new Point(287, 17);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(118, 25);
            cmbStatusFilter.TabIndex = 3;
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged_1;
            // 
            // txtSearchCustOrEq
            // 
            txtSearchCustOrEq.BackColor = Color.FromArgb(76, 85, 100);
            txtSearchCustOrEq.BorderStyle = BorderStyle.FixedSingle;
            txtSearchCustOrEq.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchCustOrEq.ForeColor = Color.LightGray;
            txtSearchCustOrEq.Location = new Point(15, 17);
            txtSearchCustOrEq.Name = "txtSearchCustOrEq";
            txtSearchCustOrEq.Size = new Size(253, 25);
            txtSearchCustOrEq.TabIndex = 2;
            txtSearchCustOrEq.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.HotTrack;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(31, 41, 55);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(847, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 30);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
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
            btnClear.Location = new Point(944, 14);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(76, 30);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(612, 20);
            label4.Name = "label4";
            label4.Size = new Size(26, 17);
            label4.TabIndex = 6;
            label4.Text = "TO";
            // 
            // rentalRequestsPnl
            // 
            rentalRequestsPnl.BackColor = Color.FromArgb(31, 41, 55);
            rentalRequestsPnl.Controls.Add(dgvRentalRequests);
            rentalRequestsPnl.Controls.Add(label2);
            rentalRequestsPnl.Location = new Point(271, 159);
            rentalRequestsPnl.Name = "rentalRequestsPnl";
            rentalRequestsPnl.Size = new Size(669, 422);
            rentalRequestsPnl.TabIndex = 5;
            // 
            // dgvRentalRequests
            // 
            dgvRentalRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalRequests.Location = new Point(3, 45);
            dgvRentalRequests.Name = "dgvRentalRequests";
            dgvRentalRequests.RowTemplate.Height = 25;
            dgvRentalRequests.Size = new Size(663, 248);
            dgvRentalRequests.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(29, 17);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 0;
            label2.Text = "Rental Requests";
            // 
            // requestDetailsPnl
            // 
            requestDetailsPnl.BackColor = Color.FromArgb(31, 41, 55);
            requestDetailsPnl.Controls.Add(btnReject);
            requestDetailsPnl.Controls.Add(btnApprove);
            requestDetailsPnl.Controls.Add(panel3);
            requestDetailsPnl.Controls.Add(label3);
            requestDetailsPnl.Location = new Point(958, 159);
            requestDetailsPnl.Name = "requestDetailsPnl";
            requestDetailsPnl.Size = new Size(350, 422);
            requestDetailsPnl.TabIndex = 6;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(200, 47, 46);
            btnReject.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(47, 372);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(256, 39);
            btnReject.TabIndex = 8;
            btnReject.Text = "Reject Request";
            btnReject.UseVisualStyleBackColor = false;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.FromArgb(16, 139, 106);
            btnApprove.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(47, 326);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(256, 39);
            btnApprove.TabIndex = 7;
            btnApprove.Text = "Approve Request";
            btnApprove.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblPurpose);
            panel3.Controls.Add(lblRentPeriod);
            panel3.Controls.Add(lblEqName);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBoxCust);
            panel3.Controls.Add(lblCustName);
            panel3.Location = new Point(20, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(313, 254);
            panel3.TabIndex = 2;
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPurpose.ForeColor = Color.White;
            lblPurpose.Location = new Point(11, 217);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(148, 17);
            lblPurpose.TabIndex = 10;
            lblPurpose.Text = "Wedding Photography";
            // 
            // lblRentPeriod
            // 
            lblRentPeriod.AutoSize = true;
            lblRentPeriod.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRentPeriod.ForeColor = Color.White;
            lblRentPeriod.Location = new Point(11, 158);
            lblRentPeriod.Name = "lblRentPeriod";
            lblRentPeriod.Size = new Size(91, 17);
            lblRentPeriod.TabIndex = 9;
            lblRentPeriod.Text = "Rental Period";
            // 
            // lblEqName
            // 
            lblEqName.AutoSize = true;
            lblEqName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEqName.ForeColor = Color.White;
            lblEqName.Location = new Point(11, 98);
            lblEqName.Name = "lblEqName";
            lblEqName.Size = new Size(115, 17);
            lblEqName.TabIndex = 5;
            lblEqName.Text = "Equipment Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(11, 195);
            label8.Name = "label8";
            label8.Size = new Size(58, 17);
            label8.TabIndex = 4;
            label8.Text = "Purpose";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(11, 135);
            label7.Name = "label7";
            label7.Size = new Size(91, 17);
            label7.TabIndex = 3;
            label7.Text = "Rental Period";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(11, 72);
            label6.Name = "label6";
            label6.Size = new Size(75, 17);
            label6.TabIndex = 2;
            label6.Text = "Equipment";
            // 
            // pictureBoxCust
            // 
            pictureBoxCust.Location = new Point(11, 11);
            pictureBoxCust.Name = "pictureBoxCust";
            pictureBoxCust.Size = new Size(42, 38);
            pictureBoxCust.TabIndex = 1;
            pictureBoxCust.TabStop = false;
            // 
            // lblCustName
            // 
            lblCustName.AutoSize = true;
            lblCustName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustName.ForeColor = Color.LightGray;
            lblCustName.Location = new Point(61, 18);
            lblCustName.Name = "lblCustName";
            lblCustName.Size = new Size(93, 21);
            lblCustName.TabIndex = 0;
            lblCustName.Text = "Cust Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(31, 17);
            label3.Name = "label3";
            label3.Size = new Size(128, 21);
            label3.TabIndex = 1;
            label3.Text = "Request Details";
            // 
            // RentalRequests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1350, 825);
            Controls.Add(requestDetailsPnl);
            Controls.Add(rentalRequestsPnl);
            Controls.Add(panel1);
            Controls.Add(topHeaderPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RentalRequests";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RentalRequests";

            FormClosing += RentalRequests_FormClosing;

            Load += RentalRequests_Load;

            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            topHeaderPanel.ResumeLayout(false);
            topHeaderPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            rentalRequestsPnl.ResumeLayout(false);
            rentalRequestsPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalRequests).EndInit();
            requestDetailsPnl.ResumeLayout(false);
            requestDetailsPnl.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCust).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Button rentalRequestsBtn;
        private Button EquipmentBtn;
        private Button dashboardBtn;
        private Label logotxt;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Panel topHeaderPanel;
        private Button analyticsBtn;
        private Button returnsBtn;
        private Panel panel1;
        private Panel rentalRequestsPnl;
        private Panel requestDetailsPnl;
        private Label label2;
        private Label label3;
        private Button btnClear;
        private Button btnSearch;
        private TextBox txtSearchCustOrEq;
        private ComboBox cmbStatusFilter;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private Label label4;
        private Label label5;
        private DataGridView dgvRentalRequests;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private Label label6;
        private PictureBox pictureBoxCust;
        private Label lblCustName;
        private Label lblPurpose;
        private Label lblRentPeriod;
        private Label lblEqName;
        private Button btnReject;
        private Button btnApprove;
    }
}