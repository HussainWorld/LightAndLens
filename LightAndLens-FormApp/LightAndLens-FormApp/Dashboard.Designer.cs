namespace LightAndLens_FormApp
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
            panel2 = new Panel();
            label10 = new Label();
            analyticsBtn = new Button();
            returnsBtn = new Button();
            rentalRequestsBtn = new Button();
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
            accessoriesPercentageLabel = new Label();
            lightsPercentageLabel = new Label();
            lensesPercentageLabel = new Label();
            cameraPercentageLabel = new Label();
            label5 = new Label();
            accessoriesProgressBar = new ProgressBar();
            label3 = new Label();
            lightsProgressBar = new ProgressBar();
            label2 = new Label();
            lensesProgressBar = new ProgressBar();
            label1 = new Label();
            cameraProgressBar = new ProgressBar();
            equipmentInventoryTxt = new Label();
            panel1 = new Panel();
            label11 = new Label();
            panel3 = new Panel();
            label12 = new Label();
            panel4 = new Panel();
            label13 = new Label();
            sidePanel.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(31, 41, 55);
            sidePanel.Controls.Add(panel2);
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
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(label10);
            panel2.Location = new Point(230, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(41, 60);
            panel2.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(7, 17);
            label10.Name = "label10";
            label10.Size = new Size(28, 21);
            label10.TabIndex = 0;
            label10.Text = "41";
            label10.TextAlign = ContentAlignment.MiddleCenter;
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
            analyticsBtn.Click += analyticsBtn_Click;
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
            returnsBtn.Click += returnsBtn_Click;
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
            rentalRequestsBtn.Click += rentalRequestsBtn_Click;
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
            underMaintenancePanel.Size = new Size(197, 80);
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
            newRentalBtn.Location = new Point(270, 178);
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
            processReturnBtn.Location = new Point(531, 178);
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
            generateReportBtn.Location = new Point(793, 178);
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
            maintenanceBtn.Location = new Point(1055, 178);
            maintenanceBtn.Name = "maintenanceBtn";
            maintenanceBtn.Size = new Size(255, 42);
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
            recentActivitiesPanel.Location = new Point(271, 230);
            recentActivitiesPanel.Name = "recentActivitiesPanel";
            recentActivitiesPanel.Size = new Size(701, 296);
            recentActivitiesPanel.TabIndex = 13;
            recentActivitiesPanel.Paint += recentActivitiesPanel_Paint;
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
            equipmentInventoryPanel.Controls.Add(accessoriesPercentageLabel);
            equipmentInventoryPanel.Controls.Add(lightsPercentageLabel);
            equipmentInventoryPanel.Controls.Add(lensesPercentageLabel);
            equipmentInventoryPanel.Controls.Add(cameraPercentageLabel);
            equipmentInventoryPanel.Controls.Add(label5);
            equipmentInventoryPanel.Controls.Add(accessoriesProgressBar);
            equipmentInventoryPanel.Controls.Add(label3);
            equipmentInventoryPanel.Controls.Add(lightsProgressBar);
            equipmentInventoryPanel.Controls.Add(label2);
            equipmentInventoryPanel.Controls.Add(lensesProgressBar);
            equipmentInventoryPanel.Controls.Add(label1);
            equipmentInventoryPanel.Controls.Add(cameraProgressBar);
            equipmentInventoryPanel.Controls.Add(equipmentInventoryTxt);
            equipmentInventoryPanel.Location = new Point(988, 230);
            equipmentInventoryPanel.Name = "equipmentInventoryPanel";
            equipmentInventoryPanel.Size = new Size(320, 296);
            equipmentInventoryPanel.TabIndex = 14;
            // 
            // accessoriesPercentageLabel
            // 
            accessoriesPercentageLabel.AutoSize = true;
            accessoriesPercentageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            accessoriesPercentageLabel.ForeColor = Color.LightGray;
            accessoriesPercentageLabel.Location = new Point(267, 226);
            accessoriesPercentageLabel.Name = "accessoriesPercentageLabel";
            accessoriesPercentageLabel.Size = new Size(42, 21);
            accessoriesPercentageLabel.TabIndex = 19;
            accessoriesPercentageLabel.Text = "71%";
            // 
            // lightsPercentageLabel
            // 
            lightsPercentageLabel.AutoSize = true;
            lightsPercentageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lightsPercentageLabel.ForeColor = Color.LightGray;
            lightsPercentageLabel.Location = new Point(267, 175);
            lightsPercentageLabel.Name = "lightsPercentageLabel";
            lightsPercentageLabel.Size = new Size(42, 21);
            lightsPercentageLabel.TabIndex = 18;
            lightsPercentageLabel.Text = "47%";
            // 
            // lensesPercentageLabel
            // 
            lensesPercentageLabel.AutoSize = true;
            lensesPercentageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lensesPercentageLabel.ForeColor = Color.LightGray;
            lensesPercentageLabel.Location = new Point(267, 124);
            lensesPercentageLabel.Name = "lensesPercentageLabel";
            lensesPercentageLabel.Size = new Size(42, 21);
            lensesPercentageLabel.TabIndex = 17;
            lensesPercentageLabel.Text = "62%";
            // 
            // cameraPercentageLabel
            // 
            cameraPercentageLabel.AutoSize = true;
            cameraPercentageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cameraPercentageLabel.ForeColor = Color.LightGray;
            cameraPercentageLabel.Location = new Point(267, 73);
            cameraPercentageLabel.Name = "cameraPercentageLabel";
            cameraPercentageLabel.Size = new Size(42, 21);
            cameraPercentageLabel.TabIndex = 16;
            cameraPercentageLabel.Text = "85%";
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
            // accessoriesProgressBar
            // 
            accessoriesProgressBar.BackColor = Color.FromArgb(55, 65, 81);
            accessoriesProgressBar.Location = new Point(107, 230);
            accessoriesProgressBar.Name = "accessoriesProgressBar";
            accessoriesProgressBar.Size = new Size(149, 17);
            accessoriesProgressBar.TabIndex = 14;
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
            // lightsProgressBar
            // 
            lightsProgressBar.BackColor = Color.FromArgb(55, 65, 81);
            lightsProgressBar.Location = new Point(107, 179);
            lightsProgressBar.Name = "lightsProgressBar";
            lightsProgressBar.Size = new Size(149, 17);
            lightsProgressBar.TabIndex = 12;
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
            // lensesProgressBar
            // 
            lensesProgressBar.BackColor = Color.FromArgb(55, 65, 81);
            lensesProgressBar.Location = new Point(107, 128);
            lensesProgressBar.Name = "lensesProgressBar";
            lensesProgressBar.Size = new Size(149, 17);
            lensesProgressBar.TabIndex = 10;
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
            // cameraProgressBar
            // 
            cameraProgressBar.BackColor = Color.FromArgb(55, 65, 81);
            cameraProgressBar.Location = new Point(107, 77);
            cameraProgressBar.Name = "cameraProgressBar";
            cameraProgressBar.Size = new Size(149, 17);
            cameraProgressBar.TabIndex = 8;
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
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label11);
            panel1.Location = new Point(372, 644);
            panel1.Name = "panel1";
            panel1.Size = new Size(41, 60);
            panel1.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 20);
            label11.Name = "label11";
            label11.Size = new Size(37, 17);
            label11.TabIndex = 0;
            label11.Text = "41px";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Controls.Add(label12);
            panel3.Location = new Point(424, 671);
            panel3.Name = "panel3";
            panel3.Size = new Size(100, 10);
            panel3.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(31, -2);
            label12.Name = "label12";
            label12.Size = new Size(26, 12);
            label12.TabIndex = 0;
            label12.Text = "10px";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Controls.Add(label13);
            panel4.Location = new Point(537, 631);
            panel4.Name = "panel4";
            panel4.Size = new Size(15, 97);
            panel4.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(-2, 40);
            label13.Name = "label13";
            label13.Size = new Size(19, 13);
            label13.TabIndex = 0;
            label13.Text = "15";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1350, 825);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private ProgressBar cameraProgressBar;
        private Label equipmentInventoryTxt;
        private Label label1;
        private Label label5;
        private ProgressBar accessoriesProgressBar;
        private Label label3;
        private ProgressBar lightsProgressBar;
        private Label label2;
        private ProgressBar lensesProgressBar;
        private Label cameraPercentageLabel;
        private Label accessoriesPercentageLabel;
        private Label lightsPercentageLabel;
        private Label lensesPercentageLabel;
        private Button analyticsBtn;
        private Button returnsBtn;
        private Button rentalRequestsBtn;
        private Panel panel2;
        private Label label10;
        private Panel panel1;
        private Label label11;
        private Panel panel3;
        private Label label12;
        private Panel panel4;
        private Label label13;
    }
}
