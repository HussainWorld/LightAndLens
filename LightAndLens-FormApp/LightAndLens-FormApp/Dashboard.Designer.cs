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
            addNewUserBtn = new Button();
            processReturnBtn = new Button();
            generateReportBtn = new Button();
            maintenanceBtn = new Button();
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
            tabRecentActivities = new TabControl();
            tabRequests = new TabPage();
            dataGridViewRequests = new DataGridView();
            tabRentals = new TabPage();
            dataGridViewRentals = new DataGridView();
            tabReturns = new TabPage();
            dataGridViewReturns = new DataGridView();
            recentActivitiesTxt = new Label();
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
            equipmentInventoryPanel.SuspendLayout();
            tabRecentActivities.SuspendLayout();
            tabRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            tabRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRentals).BeginInit();
            tabReturns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReturns).BeginInit();
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
            // addNewUserBtn
            // 
            addNewUserBtn.BackColor = Color.FromArgb(117, 147, 199);
            addNewUserBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addNewUserBtn.ForeColor = Color.White;
            addNewUserBtn.Location = new Point(270, 178);
            addNewUserBtn.Name = "addNewUserBtn";
            addNewUserBtn.Size = new Size(256, 42);
            addNewUserBtn.TabIndex = 6;
            addNewUserBtn.Text = "Add New User";
            addNewUserBtn.UseVisualStyleBackColor = false;
            addNewUserBtn.Click += newRentalBtn_Click;
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
            equipmentInventoryPanel.Location = new Point(988, 302);
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
            // tabRecentActivities
            // 
            tabRecentActivities.Controls.Add(tabRequests);
            tabRecentActivities.Controls.Add(tabRentals);
            tabRecentActivities.Controls.Add(tabReturns);
            tabRecentActivities.Location = new Point(271, 275);
            tabRecentActivities.Name = "tabRecentActivities";
            tabRecentActivities.Padding = new Point(20, 3);
            tabRecentActivities.SelectedIndex = 0;
            tabRecentActivities.Size = new Size(711, 323);
            tabRecentActivities.TabIndex = 18;
            // 
            // tabRequests
            // 
            tabRequests.BackColor = Color.FromArgb(31, 41, 55);
            tabRequests.Controls.Add(dataGridViewRequests);
            tabRequests.Location = new Point(4, 24);
            tabRequests.Name = "tabRequests";
            tabRequests.Padding = new Padding(3);
            tabRequests.Size = new Size(703, 295);
            tabRequests.TabIndex = 0;
            tabRequests.Text = "Requests";
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequests.Location = new Point(6, 6);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.RowTemplate.Height = 25;
            dataGridViewRequests.Size = new Size(691, 283);
            dataGridViewRequests.TabIndex = 4;
            // 
            // tabRentals
            // 
            tabRentals.BackColor = Color.FromArgb(31, 41, 55);
            tabRentals.Controls.Add(dataGridViewRentals);
            tabRentals.Location = new Point(4, 24);
            tabRentals.Name = "tabRentals";
            tabRentals.Padding = new Padding(3);
            tabRentals.Size = new Size(703, 295);
            tabRentals.TabIndex = 1;
            tabRentals.Text = "Rentals";
            // 
            // dataGridViewRentals
            // 
            dataGridViewRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRentals.Location = new Point(6, 6);
            dataGridViewRentals.Name = "dataGridViewRentals";
            dataGridViewRentals.RowTemplate.Height = 25;
            dataGridViewRentals.Size = new Size(691, 283);
            dataGridViewRentals.TabIndex = 19;
            // 
            // tabReturns
            // 
            tabReturns.BackColor = Color.FromArgb(31, 41, 55);
            tabReturns.Controls.Add(dataGridViewReturns);
            tabReturns.Location = new Point(4, 24);
            tabReturns.Name = "tabReturns";
            tabReturns.Padding = new Padding(3);
            tabReturns.Size = new Size(703, 295);
            tabReturns.TabIndex = 2;
            tabReturns.Text = "Returns";
            // 
            // dataGridViewReturns
            // 
            dataGridViewReturns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReturns.Location = new Point(6, 6);
            dataGridViewReturns.Name = "dataGridViewReturns";
            dataGridViewReturns.RowTemplate.Height = 25;
            dataGridViewReturns.Size = new Size(691, 283);
            dataGridViewReturns.TabIndex = 19;
            // 
            // recentActivitiesTxt
            // 
            recentActivitiesTxt.AutoSize = true;
            recentActivitiesTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            recentActivitiesTxt.ForeColor = Color.LightGray;
            recentActivitiesTxt.Location = new Point(668, 251);
            recentActivitiesTxt.Name = "recentActivitiesTxt";
            recentActivitiesTxt.Size = new Size(137, 21);
            recentActivitiesTxt.TabIndex = 6;
            recentActivitiesTxt.Text = "Recent Activities";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1350, 825);
            Controls.Add(recentActivitiesTxt);
            Controls.Add(tabRecentActivities);
            Controls.Add(equipmentInventoryPanel);
            Controls.Add(maintenanceBtn);
            Controls.Add(generateReportBtn);
            Controls.Add(processReturnBtn);
            Controls.Add(addNewUserBtn);
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
            equipmentInventoryPanel.ResumeLayout(false);
            equipmentInventoryPanel.PerformLayout();
            tabRecentActivities.ResumeLayout(false);
            tabRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
            tabRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRentals).EndInit();
            tabReturns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReturns).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button addNewUserBtn;
        private Button processReturnBtn;
        private Button generateReportBtn;
        private Button maintenanceBtn;
        private Panel equipmentInventoryPanel;
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
        private TabControl tabRecentActivities;
        private TabPage tabRentals;
        private TabPage tabReturns;
        private DataGridView dataGridViewRequests;
        private DataGridView dataGridViewRentals;
        private DataGridView dataGridViewReturns;
        private Label recentActivitiesTxt;
        private TabPage tabRequests;
    }
}
