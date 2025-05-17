namespace LightAndLens_FormApp
{
    partial class RentalTransactions
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
            dateTimePickerTo = new DateTimePicker();
            dateTimePickerFrom = new DateTimePicker();
            cmbStatusFilter = new ComboBox();
            txtSearchCustOrEq = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            label4 = new Label();
            topHeaderPanel = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            sidePanel = new Panel();
            transactionsBtn = new Button();
            analyticsBtn = new Button();
            returnsBtn = new Button();
            rentalRequestsBtn = new Button();
            EquipmentBtn = new Button();
            dashboardBtn = new Button();
            logotxt = new Label();
            panel2 = new Panel();
            rentalTransactionsdgv = new DataGridView();
            panel1.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidePanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rentalTransactionsdgv).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 6;
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
            // topHeaderPanel
            // 
            topHeaderPanel.BackColor = Color.FromArgb(31, 41, 55);
            topHeaderPanel.Controls.Add(pictureBox1);
            topHeaderPanel.Controls.Add(textBox1);
            topHeaderPanel.Dock = DockStyle.Top;
            topHeaderPanel.Location = new Point(230, 0);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Padding = new Padding(10);
            topHeaderPanel.Size = new Size(1120, 60);
            topHeaderPanel.TabIndex = 5;
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
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(31, 41, 55);
            sidePanel.Controls.Add(transactionsBtn);
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
            sidePanel.TabIndex = 4;
            // 
            // transactionsBtn
            // 
            transactionsBtn.BackColor = Color.Transparent;
            transactionsBtn.FlatStyle = FlatStyle.Flat;
            transactionsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            transactionsBtn.ForeColor = Color.LightGray;
            transactionsBtn.Location = new Point(10, 265);
            transactionsBtn.Name = "transactionsBtn";
            transactionsBtn.Size = new Size(211, 44);
            transactionsBtn.TabIndex = 6;
            transactionsBtn.Text = "Rental Transactions";
            transactionsBtn.UseVisualStyleBackColor = false;
            // 
            // analyticsBtn
            // 
            analyticsBtn.BackColor = Color.Transparent;
            analyticsBtn.FlatStyle = FlatStyle.Flat;
            analyticsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            analyticsBtn.ForeColor = Color.LightGray;
            analyticsBtn.Location = new Point(10, 385);
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
            returnsBtn.Location = new Point(10, 325);
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
            // 
            // logotxt
            // 
            logotxt.AutoSize = true;
            logotxt.Font = new Font("Vivaldi", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            logotxt.ForeColor = Color.White;
            logotxt.Location = new Point(19, 20);
            logotxt.Name = "logotxt";
            logotxt.Size = new Size(189, 29);
            logotxt.TabIndex = 0;
            logotxt.Text = "Lights And Lenses";
            logotxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 41, 55);
            panel2.Controls.Add(rentalTransactionsdgv);
            panel2.Location = new Point(271, 182);
            panel2.Name = "panel2";
            panel2.Size = new Size(1037, 514);
            panel2.TabIndex = 7;
            // 
            // rentalTransactionsdgv
            // 
            rentalTransactionsdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentalTransactionsdgv.Location = new Point(4, 4);
            rentalTransactionsdgv.Name = "rentalTransactionsdgv";
            rentalTransactionsdgv.RowTemplate.Height = 25;
            rentalTransactionsdgv.Size = new Size(1029, 505);
            rentalTransactionsdgv.TabIndex = 0;
            // 
            // RentalTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1350, 825);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(topHeaderPanel);
            Controls.Add(sidePanel);
            Name = "RentalTransactions";
            Text = "RentalTransactions";
            Load += RentalTransactions_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            topHeaderPanel.ResumeLayout(false);
            topHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rentalTransactionsdgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private ComboBox cmbStatusFilter;
        private TextBox txtSearchCustOrEq;
        private Button btnSearch;
        private Button btnClear;
        private Label label4;
        private Panel topHeaderPanel;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Panel sidePanel;
        private Button analyticsBtn;
        private Button returnsBtn;
        private Button rentalRequestsBtn;
        private Button EquipmentBtn;
        private Button dashboardBtn;
        private Label logotxt;
        private Panel panel2;
        private DataGridView rentalTransactionsdgv;
        private Button transactionsBtn;
    }
}