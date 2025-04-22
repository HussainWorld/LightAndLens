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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentForm));
            sidePanel = new Panel();
            analyticsBtn = new Button();
            returnsBtn = new Button();
            rentalRequestsBtn = new Button();
            EquipmentBtn = new Button();
            dashboardBtn = new Button();
            logotxt = new Label();
            topHeaderPanel = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
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
            panel3 = new Panel();
            panel4 = new Panel();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            lblCustomerName = new Label();
            lblEquipmentDesc = new Label();
            label5 = new Label();
            label4 = new Label();
            txtQuantity = new Label();
            txtCondition = new Label();
            txtCategory = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            equipmentDetailsTxt = new Label();
            label3 = new Label();
            pictureBoxEquipment = new PictureBox();
            sidePanel.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListEquipment).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEquipment).BeginInit();
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
            sidePanel.Margin = new Padding(3, 4, 3, 4);
            sidePanel.Name = "sidePanel";
            sidePanel.Padding = new Padding(11, 13, 11, 13);
            sidePanel.Size = new Size(263, 1055);
            sidePanel.TabIndex = 2;
            // 
            // analyticsBtn
            // 
            analyticsBtn.BackColor = Color.Transparent;
            analyticsBtn.FlatStyle = FlatStyle.Flat;
            analyticsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            analyticsBtn.ForeColor = Color.LightGray;
            analyticsBtn.Location = new Point(11, 433);
            analyticsBtn.Margin = new Padding(3, 4, 3, 4);
            analyticsBtn.Name = "analyticsBtn";
            analyticsBtn.Size = new Size(241, 59);
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
            returnsBtn.Location = new Point(11, 353);
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
            rentalRequestsBtn.ForeColor = Color.LightGray;
            rentalRequestsBtn.Location = new Point(11, 273);
            rentalRequestsBtn.Margin = new Padding(3, 4, 3, 4);
            rentalRequestsBtn.Name = "rentalRequestsBtn";
            rentalRequestsBtn.Size = new Size(241, 59);
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
            EquipmentBtn.Location = new Point(11, 193);
            EquipmentBtn.Margin = new Padding(3, 4, 3, 4);
            EquipmentBtn.Name = "EquipmentBtn";
            EquipmentBtn.Size = new Size(241, 59);
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
            dashboardBtn.Location = new Point(11, 113);
            dashboardBtn.Margin = new Padding(3, 4, 3, 4);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(241, 59);
            dashboardBtn.TabIndex = 1;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = false;
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
            topHeaderPanel.BackColor = Color.FromArgb(31, 41, 55);
            topHeaderPanel.Controls.Add(label2);
            topHeaderPanel.Controls.Add(pictureBox1);
            topHeaderPanel.Controls.Add(textBox1);
            topHeaderPanel.Dock = DockStyle.Top;
            topHeaderPanel.Location = new Point(263, 0);
            topHeaderPanel.Margin = new Padding(3, 4, 3, 4);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Padding = new Padding(11, 13, 11, 13);
            topHeaderPanel.Size = new Size(1280, 80);
            topHeaderPanel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(448, 39);
            label2.Name = "label2";
            label2.Size = new Size(425, 28);
            label2.TabIndex = 10;
            label2.Text = "Filter options Already set in Item Collection";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(53, 25);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 20);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(55, 65, 81);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(209, 213, 219);
            textBox1.Location = new Point(48, 20);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "       Search...";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 41, 55);
            panel1.Controls.Add(ddlCondition);
            panel1.Controls.Add(ddlStatus);
            panel1.Controls.Add(ddlCategory);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnClear);
            panel1.Location = new Point(310, 113);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 80);
            panel1.TabIndex = 4;
            // 
            // ddlCondition
            // 
            ddlCondition.BackColor = Color.FromArgb(76, 85, 100);
            ddlCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlCondition.FlatStyle = FlatStyle.Flat;
            ddlCondition.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ddlCondition.ForeColor = Color.LightGray;
            ddlCondition.FormattingEnabled = true;
            ddlCondition.Location = new Point(746, 23);
            ddlCondition.Margin = new Padding(3, 4, 3, 4);
            ddlCondition.Name = "ddlCondition";
            ddlCondition.Size = new Size(159, 29);
            ddlCondition.TabIndex = 5;
            // 
            // ddlStatus
            // 
            ddlStatus.BackColor = Color.FromArgb(76, 85, 100);
            ddlStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlStatus.FlatStyle = FlatStyle.Flat;
            ddlStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ddlStatus.ForeColor = Color.LightGray;
            ddlStatus.FormattingEnabled = true;
            ddlStatus.Location = new Point(565, 23);
            ddlStatus.Margin = new Padding(3, 4, 3, 4);
            ddlStatus.Name = "ddlStatus";
            ddlStatus.Size = new Size(159, 29);
            ddlStatus.TabIndex = 4;
            // 
            // ddlCategory
            // 
            ddlCategory.BackColor = Color.FromArgb(76, 85, 100);
            ddlCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlCategory.FlatStyle = FlatStyle.Flat;
            ddlCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ddlCategory.ForeColor = Color.LightGray;
            ddlCategory.FormattingEnabled = true;
            ddlCategory.Location = new Point(384, 23);
            ddlCategory.Margin = new Padding(3, 4, 3, 4);
            ddlCategory.Name = "ddlCategory";
            ddlCategory.Size = new Size(159, 29);
            ddlCategory.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(76, 85, 100);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.LightGray;
            txtSearch.Location = new Point(17, 23);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search equipment...";
            txtSearch.Size = new Size(320, 29);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.HotTrack;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(31, 41, 55);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(927, 19);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 40);
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
            btnClear.Location = new Point(1065, 19);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 40);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddEquipment
            // 
            btnAddEquipment.BackColor = Color.FromArgb(16, 139, 106);
            btnAddEquipment.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddEquipment.ForeColor = Color.White;
            btnAddEquipment.Location = new Point(949, 209);
            btnAddEquipment.Margin = new Padding(3, 4, 3, 4);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(206, 45);
            btnAddEquipment.TabIndex = 12;
            btnAddEquipment.Text = "Add Equipment       ";
            btnAddEquipment.TextAlign = ContentAlignment.MiddleRight;
            btnAddEquipment.UseVisualStyleBackColor = false;
            btnAddEquipment.Click += btnAddEquipment_Click;
            // 
            // btnEditEquipment
            // 
            btnEditEquipment.BackColor = Color.FromArgb(123, 58, 237);
            btnEditEquipment.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditEquipment.ForeColor = Color.White;
            btnEditEquipment.Location = new Point(1171, 209);
            btnEditEquipment.Margin = new Padding(3, 4, 3, 4);
            btnEditEquipment.Name = "btnEditEquipment";
            btnEditEquipment.Size = new Size(88, 45);
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
            btnDelete.Location = new Point(1278, 209);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 45);
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
            btnRefreshEquipment.Location = new Point(1395, 209);
            btnRefreshEquipment.Margin = new Padding(3, 4, 3, 4);
            btnRefreshEquipment.Name = "btnRefreshEquipment";
            btnRefreshEquipment.Size = new Size(99, 45);
            btnRefreshEquipment.TabIndex = 15;
            btnRefreshEquipment.Text = "Refresh ";
            btnRefreshEquipment.TextAlign = ContentAlignment.MiddleRight;
            btnRefreshEquipment.UseVisualStyleBackColor = false;
            btnRefreshEquipment.Click += btnRefreshEquipment_Click;
            // 
            // dgvListEquipment
            // 
            dgvListEquipment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(32, 41, 56);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(209, 213, 219);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListEquipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListEquipment.Location = new Point(310, 271);
            dgvListEquipment.Margin = new Padding(3, 4, 3, 4);
            dgvListEquipment.Name = "dgvListEquipment";
            dgvListEquipment.RowHeadersWidth = 51;
            dgvListEquipment.RowTemplate.Height = 25;
            dgvListEquipment.Size = new Size(1185, 340);
            dgvListEquipment.TabIndex = 16;
            dgvListEquipment.SelectionChanged += dgvEquipment_SelectionChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(31, 41, 55);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lblEquipmentDesc);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(txtCondition);
            panel3.Controls.Add(txtCategory);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(equipmentDetailsTxt);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBoxEquipment);
            panel3.Location = new Point(310, 628);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1185, 397);
            panel3.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(lblCustomerName);
            panel4.Location = new Point(331, 195);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(826, 164);
            panel4.TabIndex = 29;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(192, 0, 0);
            label19.Location = new Point(698, 101);
            label19.Name = "label19";
            label19.Size = new Size(92, 28);
            label19.TabIndex = 34;
            label19.Text = "Overdue";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(16, 109);
            label18.Name = "label18";
            label18.Size = new Size(112, 23);
            label18.TabIndex = 33;
            label18.Text = "June 6, 2025";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(10, 81);
            label17.Name = "label17";
            label17.Size = new Size(115, 28);
            label17.TabIndex = 32;
            label17.Text = "Cust Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Green;
            label16.Location = new Point(698, 48);
            label16.Name = "label16";
            label16.Size = new Size(99, 28);
            label16.TabIndex = 31;
            label16.Text = "Returned";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(16, 43);
            label15.Name = "label15";
            label15.Size = new Size(112, 23);
            label15.TabIndex = 30;
            label15.Text = "June 6, 2025";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomerName.ForeColor = Color.Black;
            lblCustomerName.Location = new Point(10, 16);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(115, 28);
            lblCustomerName.TabIndex = 30;
            lblCustomerName.Text = "Cust Name";
            // 
            // lblEquipmentDesc
            // 
            lblEquipmentDesc.AutoSize = true;
            lblEquipmentDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEquipmentDesc.ForeColor = Color.LightGray;
            lblEquipmentDesc.Location = new Point(342, 92);
            lblEquipmentDesc.Name = "lblEquipmentDesc";
            lblEquipmentDesc.Size = new Size(743, 40);
            lblEquipmentDesc.TabIndex = 28;
            lblEquipmentDesc.Text = resources.GetString("lblEquipmentDesc.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(325, 151);
            label5.Name = "label5";
            label5.Size = new Size(149, 28);
            label5.TabIndex = 27;
            label5.Text = "Rental History";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(325, 47);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 26;
            label4.Text = "Description";
            // 
            // txtQuantity
            // 
            txtQuantity.AutoSize = true;
            txtQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtQuantity.ForeColor = Color.White;
            txtQuantity.Location = new Point(237, 337);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(30, 23);
            txtQuantity.TabIndex = 25;
            txtQuantity.Text = "10";
            // 
            // txtCondition
            // 
            txtCondition.AutoSize = true;
            txtCondition.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCondition.ForeColor = Color.White;
            txtCondition.Location = new Point(210, 301);
            txtCondition.Name = "txtCondition";
            txtCondition.Size = new Size(81, 23);
            txtCondition.TabIndex = 24;
            txtCondition.Text = "Excellent";
            // 
            // txtCategory
            // 
            txtCategory.AutoSize = true;
            txtCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCategory.ForeColor = Color.White;
            txtCategory.Location = new Point(210, 265);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(98, 23);
            txtCategory.TabIndex = 23;
            txtCategory.Text = "Equipment";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(29, 337);
            label8.Name = "label8";
            label8.Size = new Size(85, 23);
            label8.TabIndex = 22;
            label8.Text = "Quantity:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(29, 301);
            label7.Name = "label7";
            label7.Size = new Size(94, 23);
            label7.TabIndex = 21;
            label7.Text = "Condition:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(29, 265);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 20;
            label6.Text = "Category:";
            label6.Click += label6_Click;
            // 
            // equipmentDetailsTxt
            // 
            equipmentDetailsTxt.AutoSize = true;
            equipmentDetailsTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            equipmentDetailsTxt.ForeColor = Color.LightGray;
            equipmentDetailsTxt.Location = new Point(29, 5);
            equipmentDetailsTxt.Name = "equipmentDetailsTxt";
            equipmentDetailsTxt.Size = new Size(186, 28);
            equipmentDetailsTxt.TabIndex = 19;
            equipmentDetailsTxt.Text = "Equipment Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(80, 136);
            label3.Name = "label3";
            label3.Size = new Size(187, 28);
            label3.TabIndex = 18;
            label3.Text = "Equipment Picture";
            // 
            // pictureBoxEquipment
            // 
            pictureBoxEquipment.BackColor = SystemColors.ActiveCaption;
            pictureBoxEquipment.Location = new Point(29, 47);
            pictureBoxEquipment.Margin = new Padding(3, 4, 3, 4);
            pictureBoxEquipment.Name = "pictureBoxEquipment";
            pictureBoxEquipment.Size = new Size(277, 207);
            pictureBoxEquipment.TabIndex = 0;
            pictureBoxEquipment.TabStop = false;
            // 
            // EquipmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1543, 1055);
            Controls.Add(panel3);
            Controls.Add(dgvListEquipment);
            Controls.Add(btnRefreshEquipment);
            Controls.Add(btnDelete);
            Controls.Add(btnEditEquipment);
            Controls.Add(btnAddEquipment);
            Controls.Add(panel1);
            Controls.Add(topHeaderPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EquipmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipment";
            FormClosed += EquipmentForm_FormClosed;
            Load += Equipment_Load;
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            topHeaderPanel.ResumeLayout(false);
            topHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListEquipment).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEquipment).EndInit();
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
        private PictureBox pictureBox1;
        private TextBox textBox1;
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
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBoxEquipment;
        private Label equipmentDetailsTxt;
        private Label txtQuantity;
        private Label txtCondition;
        private Label txtCategory;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label lblEquipmentDesc;
        private Label label5;
        private Label label4;
        private Panel panel4;
        private Label label15;
        private Label lblCustomerName;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label2;
    }
}