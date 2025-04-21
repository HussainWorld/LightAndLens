namespace LightAndLens_FormApp
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
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
            comboBoxConditionFilter = new ComboBox();
            comboBoxStatusFilter = new ComboBox();
            comboBoxCategoryFilter = new ComboBox();
            searchEquipment = new TextBox();
            btnApply = new Button();
            btnClear = new Button();
            btnAddEquipment = new Button();
            btnEditEquipment = new Button();
            btnDeleteEquipment = new Button();
            btnRefreshEquipment = new Button();
            dgvListEquipment = new DataGridView();
            lblEquipmentListing = new Label();
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
            lblMDate = new Label();
            lblPDate = new Label();
            lblSerialNum = new Label();
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
            sidePanel.Name = "sidePanel";
            sidePanel.Padding = new Padding(10);
            sidePanel.Size = new Size(230, 825);
            sidePanel.TabIndex = 2;
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
            topHeaderPanel.BackColor = Color.FromArgb(31, 41, 55);
            topHeaderPanel.Controls.Add(label2);
            topHeaderPanel.Controls.Add(pictureBox1);
            topHeaderPanel.Controls.Add(textBox1);
            topHeaderPanel.Dock = DockStyle.Top;
            topHeaderPanel.Location = new Point(230, 0);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Padding = new Padding(10);
            topHeaderPanel.Size = new Size(1120, 60);
            topHeaderPanel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(392, 29);
            label2.Name = "label2";
            label2.Size = new Size(340, 21);
            label2.TabIndex = 10;
            label2.Text = "Filter options Already set in Item Collection";
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 41, 55);
            panel1.Controls.Add(comboBoxConditionFilter);
            panel1.Controls.Add(comboBoxStatusFilter);
            panel1.Controls.Add(comboBoxCategoryFilter);
            panel1.Controls.Add(searchEquipment);
            panel1.Controls.Add(btnApply);
            panel1.Controls.Add(btnClear);
            panel1.Location = new Point(271, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 60);
            panel1.TabIndex = 4;
            // 
            // comboBoxConditionFilter
            // 
            comboBoxConditionFilter.BackColor = Color.FromArgb(76, 85, 100);
            comboBoxConditionFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxConditionFilter.FlatStyle = FlatStyle.Flat;
            comboBoxConditionFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxConditionFilter.ForeColor = Color.LightGray;
            comboBoxConditionFilter.FormattingEnabled = true;
            comboBoxConditionFilter.Items.AddRange(new object[] { "All Conditions", "Good", "Damaged", "Defective" });
            comboBoxConditionFilter.Location = new Point(653, 17);
            comboBoxConditionFilter.Name = "comboBoxConditionFilter";
            comboBoxConditionFilter.Size = new Size(140, 25);
            comboBoxConditionFilter.TabIndex = 5;
            // 
            // comboBoxStatusFilter
            // 
            comboBoxStatusFilter.BackColor = Color.FromArgb(76, 85, 100);
            comboBoxStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatusFilter.FlatStyle = FlatStyle.Flat;
            comboBoxStatusFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxStatusFilter.ForeColor = Color.LightGray;
            comboBoxStatusFilter.FormattingEnabled = true;
            comboBoxStatusFilter.Items.AddRange(new object[] { "All Status", "Rented", "Returned", "Overdue" });
            comboBoxStatusFilter.Location = new Point(494, 17);
            comboBoxStatusFilter.Name = "comboBoxStatusFilter";
            comboBoxStatusFilter.Size = new Size(140, 25);
            comboBoxStatusFilter.TabIndex = 4;
            // 
            // comboBoxCategoryFilter
            // 
            comboBoxCategoryFilter.BackColor = Color.FromArgb(76, 85, 100);
            comboBoxCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoryFilter.FlatStyle = FlatStyle.Flat;
            comboBoxCategoryFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxCategoryFilter.ForeColor = Color.LightGray;
            comboBoxCategoryFilter.FormattingEnabled = true;
            comboBoxCategoryFilter.Items.AddRange(new object[] { "All Categories", "Cameras", "Lenses", "Lights", "Accessories" });
            comboBoxCategoryFilter.Location = new Point(336, 17);
            comboBoxCategoryFilter.Name = "comboBoxCategoryFilter";
            comboBoxCategoryFilter.Size = new Size(140, 25);
            comboBoxCategoryFilter.TabIndex = 3;
            // 
            // searchEquipment
            // 
            searchEquipment.BackColor = Color.FromArgb(76, 85, 100);
            searchEquipment.BorderStyle = BorderStyle.FixedSingle;
            searchEquipment.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchEquipment.ForeColor = Color.LightGray;
            searchEquipment.Location = new Point(15, 17);
            searchEquipment.Name = "searchEquipment";
            searchEquipment.Size = new Size(280, 25);
            searchEquipment.TabIndex = 2;
            searchEquipment.Text = "  Search equipment...";
            // 
            // btnApply
            // 
            btnApply.BackColor = SystemColors.HotTrack;
            btnApply.FlatAppearance.BorderColor = Color.FromArgb(31, 41, 55);
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnApply.ForeColor = Color.White;
            btnApply.Location = new Point(811, 14);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(105, 30);
            btnApply.TabIndex = 1;
            btnApply.Text = "Apply  ";
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
            btnClear.Location = new Point(932, 14);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 30);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnAddEquipment
            // 
            btnAddEquipment.BackColor = Color.FromArgb(16, 139, 106);
            btnAddEquipment.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddEquipment.ForeColor = Color.White;
            btnAddEquipment.Location = new Point(830, 157);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(180, 34);
            btnAddEquipment.TabIndex = 12;
            btnAddEquipment.Text = "Add Equipment       ";
            btnAddEquipment.TextAlign = ContentAlignment.MiddleRight;
            btnAddEquipment.UseVisualStyleBackColor = false;
            // 
            // btnEditEquipment
            // 
            btnEditEquipment.BackColor = Color.FromArgb(123, 58, 237);
            btnEditEquipment.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditEquipment.ForeColor = Color.White;
            btnEditEquipment.Location = new Point(1025, 157);
            btnEditEquipment.Name = "btnEditEquipment";
            btnEditEquipment.Size = new Size(77, 34);
            btnEditEquipment.TabIndex = 13;
            btnEditEquipment.Text = "Edit   ";
            btnEditEquipment.TextAlign = ContentAlignment.MiddleRight;
            btnEditEquipment.UseVisualStyleBackColor = false;
            // 
            // btnDeleteEquipment
            // 
            btnDeleteEquipment.BackColor = Color.FromArgb(200, 47, 46);
            btnDeleteEquipment.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteEquipment.ForeColor = Color.White;
            btnDeleteEquipment.Location = new Point(1118, 157);
            btnDeleteEquipment.Name = "btnDeleteEquipment";
            btnDeleteEquipment.Size = new Size(87, 34);
            btnDeleteEquipment.TabIndex = 14;
            btnDeleteEquipment.Text = "Delete  ";
            btnDeleteEquipment.TextAlign = ContentAlignment.MiddleRight;
            btnDeleteEquipment.UseVisualStyleBackColor = false;
            // 
            // btnRefreshEquipment
            // 
            btnRefreshEquipment.BackColor = Color.Gray;
            btnRefreshEquipment.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefreshEquipment.ForeColor = Color.White;
            btnRefreshEquipment.Location = new Point(1221, 157);
            btnRefreshEquipment.Name = "btnRefreshEquipment";
            btnRefreshEquipment.Size = new Size(87, 34);
            btnRefreshEquipment.TabIndex = 15;
            btnRefreshEquipment.Text = "Refresh ";
            btnRefreshEquipment.TextAlign = ContentAlignment.MiddleRight;
            btnRefreshEquipment.UseVisualStyleBackColor = false;
            // 
            // dgvListEquipment
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(32, 41, 56);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(209, 213, 219);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListEquipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListEquipment.Location = new Point(271, 203);
            dgvListEquipment.Name = "dgvListEquipment";
            dgvListEquipment.RowTemplate.Height = 25;
            dgvListEquipment.Size = new Size(1037, 255);
            dgvListEquipment.TabIndex = 16;
            // 
            // lblEquipmentListing
            // 
            lblEquipmentListing.AutoSize = true;
            lblEquipmentListing.BackColor = SystemColors.ControlDark;
            lblEquipmentListing.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEquipmentListing.Location = new Point(647, 309);
            lblEquipmentListing.Name = "lblEquipmentListing";
            lblEquipmentListing.Size = new Size(194, 21);
            lblEquipmentListing.TabIndex = 17;
            lblEquipmentListing.Text = "Equipment Listing Table";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(31, 41, 55);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lblEquipmentDesc);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblMDate);
            panel3.Controls.Add(lblPDate);
            panel3.Controls.Add(lblSerialNum);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(equipmentDetailsTxt);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBoxEquipment);
            panel3.Location = new Point(271, 471);
            panel3.Name = "panel3";
            panel3.Size = new Size(1037, 298);
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
            panel4.Location = new Point(290, 146);
            panel4.Name = "panel4";
            panel4.Size = new Size(723, 123);
            panel4.TabIndex = 29;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(192, 0, 0);
            label19.Location = new Point(611, 76);
            label19.Name = "label19";
            label19.Size = new Size(75, 21);
            label19.TabIndex = 34;
            label19.Text = "Overdue";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(14, 82);
            label18.Name = "label18";
            label18.Size = new Size(84, 17);
            label18.TabIndex = 33;
            label18.Text = "June 6, 2025";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(9, 61);
            label17.Name = "label17";
            label17.Size = new Size(93, 21);
            label17.TabIndex = 32;
            label17.Text = "Cust Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Green;
            label16.Location = new Point(611, 36);
            label16.Name = "label16";
            label16.Size = new Size(80, 21);
            label16.TabIndex = 31;
            label16.Text = "Returned";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(14, 32);
            label15.Name = "label15";
            label15.Size = new Size(84, 17);
            label15.TabIndex = 30;
            label15.Text = "June 6, 2025";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomerName.ForeColor = Color.Black;
            lblCustomerName.Location = new Point(9, 12);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(93, 21);
            lblCustomerName.TabIndex = 30;
            lblCustomerName.Text = "Cust Name";
            // 
            // lblEquipmentDesc
            // 
            lblEquipmentDesc.AutoSize = true;
            lblEquipmentDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEquipmentDesc.ForeColor = Color.LightGray;
            lblEquipmentDesc.Location = new Point(299, 69);
            lblEquipmentDesc.Name = "lblEquipmentDesc";
            lblEquipmentDesc.Size = new Size(583, 30);
            lblEquipmentDesc.TabIndex = 28;
            lblEquipmentDesc.Text = resources.GetString("lblEquipmentDesc.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(284, 113);
            label5.Name = "label5";
            label5.Size = new Size(119, 21);
            label5.TabIndex = 27;
            label5.Text = "Rental History";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(284, 35);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 26;
            label4.Text = "Description";
            // 
            // lblMDate
            // 
            lblMDate.AutoSize = true;
            lblMDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMDate.ForeColor = Color.White;
            lblMDate.Location = new Point(183, 253);
            lblMDate.Name = "lblMDate";
            lblMDate.Size = new Size(84, 17);
            lblMDate.TabIndex = 25;
            lblMDate.Text = "June 6, 2025";
            // 
            // lblPDate
            // 
            lblPDate.AutoSize = true;
            lblPDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPDate.ForeColor = Color.White;
            lblPDate.Location = new Point(184, 226);
            lblPDate.Name = "lblPDate";
            lblPDate.Size = new Size(83, 17);
            lblPDate.TabIndex = 24;
            lblPDate.Text = "Jan 15, 2025";
            // 
            // lblSerialNum
            // 
            lblSerialNum.AutoSize = true;
            lblSerialNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSerialNum.ForeColor = Color.White;
            lblSerialNum.Location = new Point(184, 199);
            lblSerialNum.Name = "lblSerialNum";
            lblSerialNum.Size = new Size(83, 17);
            lblSerialNum.TabIndex = 23;
            lblSerialNum.Text = "CR5-2025-01";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(25, 253);
            label8.Name = "label8";
            label8.Size = new Size(120, 17);
            label8.TabIndex = 22;
            label8.Text = "Last Maintenance:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(25, 226);
            label7.Name = "label7";
            label7.Size = new Size(100, 17);
            label7.TabIndex = 21;
            label7.Text = "Purchase Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(25, 199);
            label6.Name = "label6";
            label6.Size = new Size(101, 17);
            label6.TabIndex = 20;
            label6.Text = "Serial Number:";
            // 
            // equipmentDetailsTxt
            // 
            equipmentDetailsTxt.AutoSize = true;
            equipmentDetailsTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            equipmentDetailsTxt.ForeColor = Color.LightGray;
            equipmentDetailsTxt.Location = new Point(25, 4);
            equipmentDetailsTxt.Name = "equipmentDetailsTxt";
            equipmentDetailsTxt.Size = new Size(151, 21);
            equipmentDetailsTxt.TabIndex = 19;
            equipmentDetailsTxt.Text = "Equipment Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(70, 102);
            label3.Name = "label3";
            label3.Size = new Size(152, 21);
            label3.TabIndex = 18;
            label3.Text = "Equipment Picture";
            // 
            // pictureBoxEquipment
            // 
            pictureBoxEquipment.BackColor = SystemColors.ActiveCaption;
            pictureBoxEquipment.Location = new Point(25, 35);
            pictureBoxEquipment.Name = "pictureBoxEquipment";
            pictureBoxEquipment.Size = new Size(242, 155);
            pictureBoxEquipment.TabIndex = 0;
            pictureBoxEquipment.TabStop = false;
            // 
            // Equipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1350, 825);
            Controls.Add(panel3);
            Controls.Add(lblEquipmentListing);
            Controls.Add(dgvListEquipment);
            Controls.Add(btnRefreshEquipment);
            Controls.Add(btnDeleteEquipment);
            Controls.Add(btnEditEquipment);
            Controls.Add(btnAddEquipment);
            Controls.Add(panel1);
            Controls.Add(topHeaderPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Equipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipment";
            FormClosing += Equipment_FormClosing;
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
            PerformLayout();
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
        private ComboBox comboBoxCategoryFilter;
        private TextBox searchEquipment;
        private Button btnApply;
        private Button btnClear;
        private ComboBox comboBoxConditionFilter;
        private ComboBox comboBoxStatusFilter;
        private Button btnAddEquipment;
        private Button btnEditEquipment;
        private Button btnDeleteEquipment;
        private Button btnRefreshEquipment;
        private DataGridView dgvListEquipment;
        private Label lblEquipmentListing;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBoxEquipment;
        private Label equipmentDetailsTxt;
        private Label lblMDate;
        private Label lblPDate;
        private Label lblSerialNum;
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