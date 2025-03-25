namespace AP_Project_Testing2._0
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidePanel = new Panel();
            EquipmentBtn = new Button();
            dashboardBtn = new Button();
            logotxt = new Label();
            topHeaderPanel = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            totalEquipmentPanel = new Panel();
            totalEquipmentNum = new Label();
            totalEquipmentTxt = new Label();
            totalEquipmentPic = new PictureBox();
            activeRentalsPanel = new Panel();
            activeRentalsNum = new Label();
            activeRentalsTxt = new Label();
            activeRentalsPic = new PictureBox();
            pendingRequestsPanel = new Panel();
            pendingRequestsNum = new Label();
            pendingRequestsTxt = new Label();
            pendingRequestsPic = new PictureBox();
            overdueReturnsPanel = new Panel();
            overdueReturnsNum = new Label();
            overdueReturnsTxt = new Label();
            overdueReturnsPic = new PictureBox();
            underMaintenancePanel = new Panel();
            underMaintenancePic = new PictureBox();
            underMaintenanceNum = new Label();
            underMaintenanceTxt = new Label();
            newRentalBtn = new Button();
            processReturnBtn = new Button();
            generateReportBtn = new Button();
            maintenanceBtn = new Button();
            recentActivitiesPanel = new Panel();
            recentActivitiesTxt = new Label();
            label4 = new Label();
            dataGridViewRecentActivities = new DataGridView();
            equipmentInventoryPanel = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            progressBar4 = new ProgressBar();
            label3 = new Label();
            progressBar3 = new ProgressBar();
            label2 = new Label();
            progressBar2 = new ProgressBar();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            equipmentInventoryTxt = new Label();
            settingsBtn = new Button();
            analyticsBtn = new Button();
            returnsBtn = new Button();
            rentalRequestsBtn = new Button();
            sidePanel.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            totalEquipmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)totalEquipmentPic).BeginInit();
            activeRentalsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)activeRentalsPic).BeginInit();
            pendingRequestsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pendingRequestsPic).BeginInit();
            overdueReturnsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)overdueReturnsPic).BeginInit();
            underMaintenancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)underMaintenancePic).BeginInit();
            recentActivitiesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecentActivities).BeginInit();
            equipmentInventoryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(31, 41, 55);
            sidePanel.Controls.Add(settingsBtn);
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
            sidePanel.TabIndex = 0;
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
            EquipmentBtn.Click += EquipmentBtn_Click;
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
            topHeaderPanel.TabIndex = 1;
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
            // totalEquipmentPanel
            // 
            totalEquipmentPanel.BackColor = Color.FromArgb(31, 41, 55);
            totalEquipmentPanel.Controls.Add(totalEquipmentNum);
            totalEquipmentPanel.Controls.Add(totalEquipmentTxt);
            totalEquipmentPanel.Controls.Add(totalEquipmentPic);
            totalEquipmentPanel.Location = new Point(271, 85);
            totalEquipmentPanel.Name = "totalEquipmentPanel";
            totalEquipmentPanel.Size = new Size(200, 80);
            totalEquipmentPanel.TabIndex = 2;
            // 
            // totalEquipmentNum
            // 
            totalEquipmentNum.AutoSize = true;
            totalEquipmentNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            totalEquipmentNum.ForeColor = Color.LightGray;
            totalEquipmentNum.Location = new Point(15, 37);
            totalEquipmentNum.Name = "totalEquipmentNum";
            totalEquipmentNum.Size = new Size(56, 32);
            totalEquipmentNum.TabIndex = 4;
            totalEquipmentNum.Text = "300";
            // 
            // totalEquipmentTxt
            // 
            totalEquipmentTxt.AutoSize = true;
            totalEquipmentTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalEquipmentTxt.ForeColor = Color.LightGray;
            totalEquipmentTxt.Location = new Point(6, 11);
            totalEquipmentTxt.Name = "totalEquipmentTxt";
            totalEquipmentTxt.Size = new Size(136, 21);
            totalEquipmentTxt.TabIndex = 3;
            totalEquipmentTxt.Text = "Total Equipment";
            // 
            // totalEquipmentPic
            // 
            totalEquipmentPic.BackColor = Color.DimGray;
            totalEquipmentPic.Location = new Point(153, 25);
            totalEquipmentPic.Name = "totalEquipmentPic";
            totalEquipmentPic.Size = new Size(32, 29);
            totalEquipmentPic.TabIndex = 2;
            totalEquipmentPic.TabStop = false;
            // 
            // activeRentalsPanel
            // 
            activeRentalsPanel.BackColor = Color.FromArgb(31, 41, 55);
            activeRentalsPanel.Controls.Add(activeRentalsNum);
            activeRentalsPanel.Controls.Add(activeRentalsTxt);
            activeRentalsPanel.Controls.Add(activeRentalsPic);
            activeRentalsPanel.Location = new Point(481, 85);
            activeRentalsPanel.Name = "activeRentalsPanel";
            activeRentalsPanel.Size = new Size(200, 80);
            activeRentalsPanel.TabIndex = 3;
            // 
            // activeRentalsNum
            // 
            activeRentalsNum.AutoSize = true;
            activeRentalsNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            activeRentalsNum.ForeColor = Color.LightGray;
            activeRentalsNum.Location = new Point(15, 37);
            activeRentalsNum.Name = "activeRentalsNum";
            activeRentalsNum.Size = new Size(56, 32);
            activeRentalsNum.TabIndex = 4;
            activeRentalsNum.Text = "189";
            // 
            // activeRentalsTxt
            // 
            activeRentalsTxt.AutoSize = true;
            activeRentalsTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            activeRentalsTxt.ForeColor = Color.LightGray;
            activeRentalsTxt.Location = new Point(6, 11);
            activeRentalsTxt.Name = "activeRentalsTxt";
            activeRentalsTxt.Size = new Size(118, 21);
            activeRentalsTxt.TabIndex = 3;
            activeRentalsTxt.Text = "Active Rentals";
            // 
            // activeRentalsPic
            // 
            activeRentalsPic.BackColor = Color.DimGray;
            activeRentalsPic.Location = new Point(153, 25);
            activeRentalsPic.Name = "activeRentalsPic";
            activeRentalsPic.Size = new Size(32, 29);
            activeRentalsPic.TabIndex = 2;
            activeRentalsPic.TabStop = false;
            // 
            // pendingRequestsPanel
            // 
            pendingRequestsPanel.BackColor = Color.FromArgb(31, 41, 55);
            pendingRequestsPanel.Controls.Add(pendingRequestsNum);
            pendingRequestsPanel.Controls.Add(pendingRequestsTxt);
            pendingRequestsPanel.Controls.Add(pendingRequestsPic);
            pendingRequestsPanel.Location = new Point(691, 85);
            pendingRequestsPanel.Name = "pendingRequestsPanel";
            pendingRequestsPanel.Size = new Size(200, 80);
            pendingRequestsPanel.TabIndex = 5;
            // 
            // pendingRequestsNum
            // 
            pendingRequestsNum.AutoSize = true;
            pendingRequestsNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            pendingRequestsNum.ForeColor = Color.LightGray;
            pendingRequestsNum.Location = new Point(15, 37);
            pendingRequestsNum.Name = "pendingRequestsNum";
            pendingRequestsNum.Size = new Size(42, 32);
            pendingRequestsNum.TabIndex = 4;
            pendingRequestsNum.Text = "32";
            // 
            // pendingRequestsTxt
            // 
            pendingRequestsTxt.AutoSize = true;
            pendingRequestsTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pendingRequestsTxt.ForeColor = Color.LightGray;
            pendingRequestsTxt.Location = new Point(6, 11);
            pendingRequestsTxt.Name = "pendingRequestsTxt";
            pendingRequestsTxt.Size = new Size(146, 21);
            pendingRequestsTxt.TabIndex = 3;
            pendingRequestsTxt.Text = "Pending Requests";
            // 
            // pendingRequestsPic
            // 
            pendingRequestsPic.BackColor = Color.DimGray;
            pendingRequestsPic.Location = new Point(153, 25);
            pendingRequestsPic.Name = "pendingRequestsPic";
            pendingRequestsPic.Size = new Size(32, 29);
            pendingRequestsPic.TabIndex = 2;
            pendingRequestsPic.TabStop = false;
            // 
            // overdueReturnsPanel
            // 
            overdueReturnsPanel.BackColor = Color.FromArgb(31, 41, 55);
            overdueReturnsPanel.Controls.Add(overdueReturnsNum);
            overdueReturnsPanel.Controls.Add(overdueReturnsTxt);
            overdueReturnsPanel.Controls.Add(overdueReturnsPic);
            overdueReturnsPanel.Location = new Point(901, 85);
            overdueReturnsPanel.Name = "overdueReturnsPanel";
            overdueReturnsPanel.Size = new Size(200, 80);
            overdueReturnsPanel.TabIndex = 5;
            // 
            // overdueReturnsNum
            // 
            overdueReturnsNum.AutoSize = true;
            overdueReturnsNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            overdueReturnsNum.ForeColor = Color.LightGray;
            overdueReturnsNum.Location = new Point(15, 37);
            overdueReturnsNum.Name = "overdueReturnsNum";
            overdueReturnsNum.Size = new Size(42, 32);
            overdueReturnsNum.TabIndex = 4;
            overdueReturnsNum.Text = "12";
            // 
            // overdueReturnsTxt
            // 
            overdueReturnsTxt.AutoSize = true;
            overdueReturnsTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            overdueReturnsTxt.ForeColor = Color.LightGray;
            overdueReturnsTxt.Location = new Point(6, 11);
            overdueReturnsTxt.Name = "overdueReturnsTxt";
            overdueReturnsTxt.Size = new Size(137, 21);
            overdueReturnsTxt.TabIndex = 3;
            overdueReturnsTxt.Text = "Overdue Returns";
            // 
            // overdueReturnsPic
            // 
            overdueReturnsPic.BackColor = Color.DimGray;
            overdueReturnsPic.Location = new Point(153, 25);
            overdueReturnsPic.Name = "overdueReturnsPic";
            overdueReturnsPic.Size = new Size(32, 29);
            overdueReturnsPic.TabIndex = 2;
            overdueReturnsPic.TabStop = false;
            // 
            // underMaintenancePanel
            // 
            underMaintenancePanel.BackColor = Color.FromArgb(31, 41, 55);
            underMaintenancePanel.Controls.Add(underMaintenancePic);
            underMaintenancePanel.Controls.Add(underMaintenanceNum);
            underMaintenancePanel.Controls.Add(underMaintenanceTxt);
            underMaintenancePanel.Location = new Point(1111, 85);
            underMaintenancePanel.Name = "underMaintenancePanel";
            underMaintenancePanel.Size = new Size(200, 80);
            underMaintenancePanel.TabIndex = 5;
            // 
            // underMaintenancePic
            // 
            underMaintenancePic.BackColor = Color.DimGray;
            underMaintenancePic.Location = new Point(154, 35);
            underMaintenancePic.Name = "underMaintenancePic";
            underMaintenancePic.Size = new Size(32, 29);
            underMaintenancePic.TabIndex = 2;
            underMaintenancePic.TabStop = false;
            // 
            // underMaintenanceNum
            // 
            underMaintenanceNum.AutoSize = true;
            underMaintenanceNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            underMaintenanceNum.ForeColor = Color.LightGray;
            underMaintenanceNum.Location = new Point(15, 37);
            underMaintenanceNum.Name = "underMaintenanceNum";
            underMaintenanceNum.Size = new Size(28, 32);
            underMaintenanceNum.TabIndex = 4;
            underMaintenanceNum.Text = "9";
            // 
            // underMaintenanceTxt
            // 
            underMaintenanceTxt.AutoSize = true;
            underMaintenanceTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            underMaintenanceTxt.ForeColor = Color.LightGray;
            underMaintenanceTxt.Location = new Point(6, 11);
            underMaintenanceTxt.Name = "underMaintenanceTxt";
            underMaintenanceTxt.Size = new Size(161, 21);
            underMaintenanceTxt.TabIndex = 3;
            underMaintenanceTxt.Text = "Under Maintenance";
            // 
            // newRentalBtn
            // 
            newRentalBtn.BackColor = Color.FromArgb(117, 147, 199);
            newRentalBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            newRentalBtn.ForeColor = Color.White;
            newRentalBtn.Location = new Point(272, 178);
            newRentalBtn.Name = "newRentalBtn";
            newRentalBtn.Size = new Size(256, 42);
            newRentalBtn.TabIndex = 6;
            newRentalBtn.Text = "New Rental";
            newRentalBtn.UseVisualStyleBackColor = false;
            // 
            // processReturnBtn
            // 
            processReturnBtn.BackColor = Color.FromArgb(154, 183, 155);
            processReturnBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            processReturnBtn.ForeColor = Color.White;
            processReturnBtn.Location = new Point(534, 178);
            processReturnBtn.Name = "processReturnBtn";
            processReturnBtn.Size = new Size(256, 42);
            processReturnBtn.TabIndex = 10;
            processReturnBtn.Text = "Process Return";
            processReturnBtn.UseVisualStyleBackColor = false;
            // 
            // generateReportBtn
            // 
            generateReportBtn.BackColor = Color.FromArgb(140, 118, 183);
            generateReportBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            generateReportBtn.ForeColor = Color.White;
            generateReportBtn.Location = new Point(796, 178);
            generateReportBtn.Name = "generateReportBtn";
            generateReportBtn.Size = new Size(256, 42);
            generateReportBtn.TabIndex = 11;
            generateReportBtn.Text = "Generate Report";
            generateReportBtn.UseVisualStyleBackColor = false;
            // 
            // maintenanceBtn
            // 
            maintenanceBtn.BackColor = Color.FromArgb(190, 112, 72);
            maintenanceBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            maintenanceBtn.ForeColor = Color.White;
            maintenanceBtn.Location = new Point(1058, 178);
            maintenanceBtn.Name = "maintenanceBtn";
            maintenanceBtn.Size = new Size(256, 42);
            maintenanceBtn.TabIndex = 12;
            maintenanceBtn.Text = "Maintenance";
            maintenanceBtn.UseVisualStyleBackColor = false;
            // 
            // recentActivitiesPanel
            // 
            recentActivitiesPanel.BackColor = Color.FromArgb(31, 41, 55);
            recentActivitiesPanel.Controls.Add(recentActivitiesTxt);
            recentActivitiesPanel.Controls.Add(label4);
            recentActivitiesPanel.Controls.Add(dataGridViewRecentActivities);
            recentActivitiesPanel.Location = new Point(271, 234);
            recentActivitiesPanel.Name = "recentActivitiesPanel";
            recentActivitiesPanel.Size = new Size(701, 296);
            recentActivitiesPanel.TabIndex = 13;
            // 
            // recentActivitiesTxt
            // 
            recentActivitiesTxt.AutoSize = true;
            recentActivitiesTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            recentActivitiesTxt.ForeColor = Color.LightGray;
            recentActivitiesTxt.Location = new Point(29, 17);
            recentActivitiesTxt.Name = "recentActivitiesTxt";
            recentActivitiesTxt.Size = new Size(137, 21);
            recentActivitiesTxt.TabIndex = 6;
            recentActivitiesTxt.Text = "Recent Activities";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(52, 128);
            label4.Name = "label4";
            label4.Size = new Size(371, 17);
            label4.TabIndex = 5;
            label4.Text = "Populate the list using Items.Add(), including timestamps.";
            // 
            // dataGridViewRecentActivities
            // 
            dataGridViewRecentActivities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecentActivities.Location = new Point(29, 55);
            dataGridViewRecentActivities.Name = "dataGridViewRecentActivities";
            dataGridViewRecentActivities.RowTemplate.Height = 25;
            dataGridViewRecentActivities.Size = new Size(642, 217);
            dataGridViewRecentActivities.TabIndex = 4;
            // 
            // equipmentInventoryPanel
            // 
            equipmentInventoryPanel.BackColor = Color.FromArgb(31, 41, 55);
            equipmentInventoryPanel.Controls.Add(label9);
            equipmentInventoryPanel.Controls.Add(label8);
            equipmentInventoryPanel.Controls.Add(label7);
            equipmentInventoryPanel.Controls.Add(label6);
            equipmentInventoryPanel.Controls.Add(label5);
            equipmentInventoryPanel.Controls.Add(progressBar4);
            equipmentInventoryPanel.Controls.Add(label3);
            equipmentInventoryPanel.Controls.Add(progressBar3);
            equipmentInventoryPanel.Controls.Add(label2);
            equipmentInventoryPanel.Controls.Add(progressBar2);
            equipmentInventoryPanel.Controls.Add(label1);
            equipmentInventoryPanel.Controls.Add(progressBar1);
            equipmentInventoryPanel.Controls.Add(equipmentInventoryTxt);
            equipmentInventoryPanel.Location = new Point(988, 234);
            equipmentInventoryPanel.Name = "equipmentInventoryPanel";
            equipmentInventoryPanel.Size = new Size(323, 296);
            equipmentInventoryPanel.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(267, 226);
            label9.Name = "label9";
            label9.Size = new Size(42, 21);
            label9.TabIndex = 19;
            label9.Text = "71%";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(267, 175);
            label8.Name = "label8";
            label8.Size = new Size(42, 21);
            label8.TabIndex = 18;
            label8.Text = "47%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(267, 124);
            label7.Name = "label7";
            label7.Size = new Size(42, 21);
            label7.TabIndex = 17;
            label7.Text = "62%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(267, 73);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 16;
            label6.Text = "85%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(10, 227);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 15;
            label5.Text = "Accessories";
            // 
            // progressBar4
            // 
            progressBar4.BackColor = Color.FromArgb(55, 65, 81);
            progressBar4.Location = new Point(107, 230);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(149, 17);
            progressBar4.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(10, 176);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 13;
            label3.Text = "Lights";
            // 
            // progressBar3
            // 
            progressBar3.BackColor = Color.FromArgb(55, 65, 81);
            progressBar3.Location = new Point(107, 179);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(149, 17);
            progressBar3.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(10, 125);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 11;
            label2.Text = "Lenses";
            // 
            // progressBar2
            // 
            progressBar2.BackColor = Color.FromArgb(55, 65, 81);
            progressBar2.Location = new Point(107, 128);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(149, 17);
            progressBar2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(10, 73);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 9;
            label1.Text = "Cameras";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.FromArgb(55, 65, 81);
            progressBar1.Location = new Point(107, 77);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(149, 17);
            progressBar1.TabIndex = 8;
            // 
            // equipmentInventoryTxt
            // 
            equipmentInventoryTxt.AutoSize = true;
            equipmentInventoryTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            equipmentInventoryTxt.ForeColor = Color.LightGray;
            equipmentInventoryTxt.Location = new Point(21, 17);
            equipmentInventoryTxt.Name = "equipmentInventoryTxt";
            equipmentInventoryTxt.Size = new Size(173, 21);
            equipmentInventoryTxt.TabIndex = 7;
            equipmentInventoryTxt.Text = "Equipment Inventory";
            // 
            // settingsBtn
            // 
            settingsBtn.BackColor = Color.Transparent;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            settingsBtn.ForeColor = Color.LightGray;
            settingsBtn.Location = new Point(10, 385);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(211, 44);
            settingsBtn.TabIndex = 10;
            settingsBtn.Text = "Settings";
            settingsBtn.UseVisualStyleBackColor = false;
            settingsBtn.Click += this.settingsBtn_Click_1;
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
            analyticsBtn.TabIndex = 9;
            analyticsBtn.Text = "Analytics";
            analyticsBtn.UseVisualStyleBackColor = false;
            analyticsBtn.Click += this.analyticsBtn_Click;
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
            returnsBtn.TabIndex = 8;
            returnsBtn.Text = "Returns";
            returnsBtn.UseVisualStyleBackColor = false;
            returnsBtn.Click += this.returnsBtn_Click;
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
            rentalRequestsBtn.TabIndex = 7;
            rentalRequestsBtn.Text = "Rental Requests";
            rentalRequestsBtn.UseVisualStyleBackColor = false;
            rentalRequestsBtn.Click += this.rentalRequestsBtn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1350, 825);
            Controls.Add(equipmentInventoryPanel);
            Controls.Add(recentActivitiesPanel);
            Controls.Add(maintenanceBtn);
            Controls.Add(generateReportBtn);
            Controls.Add(processReturnBtn);
            Controls.Add(newRentalBtn);
            Controls.Add(underMaintenancePanel);
            Controls.Add(overdueReturnsPanel);
            Controls.Add(pendingRequestsPanel);
            Controls.Add(activeRentalsPanel);
            Controls.Add(totalEquipmentPanel);
            Controls.Add(topHeaderPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Form1_Load;
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            topHeaderPanel.ResumeLayout(false);
            topHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            totalEquipmentPanel.ResumeLayout(false);
            totalEquipmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)totalEquipmentPic).EndInit();
            activeRentalsPanel.ResumeLayout(false);
            activeRentalsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)activeRentalsPic).EndInit();
            pendingRequestsPanel.ResumeLayout(false);
            pendingRequestsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pendingRequestsPic).EndInit();
            overdueReturnsPanel.ResumeLayout(false);
            overdueReturnsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)overdueReturnsPic).EndInit();
            underMaintenancePanel.ResumeLayout(false);
            underMaintenancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)underMaintenancePic).EndInit();
            recentActivitiesPanel.ResumeLayout(false);
            recentActivitiesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecentActivities).EndInit();
            equipmentInventoryPanel.ResumeLayout(false);
            equipmentInventoryPanel.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Panel sidePanel;
        private Label logotxt;
        private Button dashboardBtn;
        private Button EquipmentBtn;
        private Panel topHeaderPanel;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Panel totalEquipmentPanel;
        private Label totalEquipmentNum;
        private Label totalEquipmentTxt;
        private PictureBox totalEquipmentPic;
        private Panel activeRentalsPanel;
        private Label activeRentalsNum;
        private Label activeRentalsTxt;
        private PictureBox activeRentalsPic;
        private Panel pendingRequestsPanel;
        private Label pendingRequestsNum;
        private Label pendingRequestsTxt;
        private PictureBox pendingRequestsPic;
        private Panel overdueReturnsPanel;
        private Label overdueReturnsNum;
        private Label overdueReturnsTxt;
        private PictureBox overdueReturnsPic;
        private Panel underMaintenancePanel;
        private Label underMaintenanceNum;
        private Label underMaintenanceTxt;
        private PictureBox underMaintenancePic;
        private Button newRentalBtn;
        private Button processReturnBtn;
        private Button generateReportBtn;
        private Button maintenanceBtn;
        private Panel recentActivitiesPanel;
        private Label label4;
        private DataGridView dataGridViewRecentActivities;
        private Panel equipmentInventoryPanel;
        private Label recentActivitiesTxt;
        private ProgressBar progressBar1;
        private Label equipmentInventoryTxt;
        private Label label1;
        private Label label5;
        private ProgressBar progressBar4;
        private Label label3;
        private ProgressBar progressBar3;
        private Label label2;
        private ProgressBar progressBar2;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button settingsBtn;
        private Button analyticsBtn;
        private Button returnsBtn;
        private Button rentalRequestsBtn;
    }
}
