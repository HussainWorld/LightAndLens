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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            sidePanel = new Panel();
            rentalTransactionsBtn = new Button();
            panel2 = new Panel();
            label10 = new Label();
            analyticsBtn = new Button();
            returnsBtn = new Button();
            rentalRequestsBtn = new Button();
            EquipmentBtn = new Button();
            dashboardBtn = new Button();
            logotxt = new Label();
            topHeaderPanel = new Panel();
            totalEquipmentPanel = new Panel();
            pictureBox1 = new PictureBox();
            totalEquipmentNum = new Label();
            totalEquipmentTxt = new Label();
            activeRentalsPanel = new Panel();
            pictureBox2 = new PictureBox();
            activeRentalsNum = new Label();
            activeRentalsTxt = new Label();
            pendingRequestsPanel = new Panel();
            pictureBox3 = new PictureBox();
            pendingRequestsNum = new Label();
            pendingRequestsTxt = new Label();
            overdueReturnsPanel = new Panel();
            pictureBox4 = new PictureBox();
            overdueReturnsNum = new Label();
            overdueReturnsTxt = new Label();
            underMaintenancePanel = new Panel();
            pictureBox5 = new PictureBox();
            underMaintenanceNum = new Label();
            underMaintenanceTxt = new Label();
            newRentalBtn = new Button();
            processReturnBtn = new Button();
            LogsBtn = new Button();
            maintenanceBtn = new Button();
            equipmentInventoryPanel = new Panel();
            stabilizersPercentageLabel = new Label();
            label6 = new Label();
            stabilizersProgressBar = new ProgressBar();
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
            pictureBoxAvatar = new PictureBox();
            labelUserName = new Label();
            sidePanel.SuspendLayout();
            panel2.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            totalEquipmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            activeRentalsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pendingRequestsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            overdueReturnsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            underMaintenancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            equipmentInventoryPanel.SuspendLayout();
            tabRecentActivities.SuspendLayout();
            tabRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            tabRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRentals).BeginInit();
            tabReturns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReturns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(22, 34, 68);
            sidePanel.Controls.Add(rentalTransactionsBtn);
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
            // rentalTransactionsBtn
            // 
            rentalTransactionsBtn.BackColor = Color.FromArgb(22, 34, 68);
            rentalTransactionsBtn.FlatAppearance.BorderColor = Color.FromArgb(41, 58, 107);
            rentalTransactionsBtn.FlatStyle = FlatStyle.Flat;
            rentalTransactionsBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            rentalTransactionsBtn.ForeColor = Color.FromArgb(233, 239, 255);
            rentalTransactionsBtn.Image = Properties.Resources.Orders;
            rentalTransactionsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            rentalTransactionsBtn.Location = new Point(10, 267);
            rentalTransactionsBtn.Name = "rentalTransactionsBtn";
            rentalTransactionsBtn.Size = new Size(211, 44);
            rentalTransactionsBtn.TabIndex = 17;
            rentalTransactionsBtn.Text = "  Transactions";
            rentalTransactionsBtn.UseVisualStyleBackColor = false;
            rentalTransactionsBtn.Click += button1_Click_1;
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
            analyticsBtn.BackColor = Color.FromArgb(22, 34, 68);
            analyticsBtn.FlatAppearance.BorderColor = Color.FromArgb(41, 58, 107);
            analyticsBtn.FlatStyle = FlatStyle.Flat;
            analyticsBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            analyticsBtn.ForeColor = Color.FromArgb(233, 239, 255);
            analyticsBtn.Image = Properties.Resources.Analytics;
            analyticsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            analyticsBtn.Location = new Point(10, 389);
            analyticsBtn.Name = "analyticsBtn";
            analyticsBtn.Size = new Size(211, 44);
            analyticsBtn.TabIndex = 9;
            analyticsBtn.Text = "  Analytics";
            analyticsBtn.UseVisualStyleBackColor = false;
            analyticsBtn.Click += analyticsBtn_Click;
            // 
            // returnsBtn
            // 
            returnsBtn.BackColor = Color.FromArgb(22, 34, 68);
            returnsBtn.FlatAppearance.BorderColor = Color.FromArgb(41, 58, 107);
            returnsBtn.FlatStyle = FlatStyle.Flat;
            returnsBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            returnsBtn.ForeColor = Color.FromArgb(233, 239, 255);
            returnsBtn.Image = Properties.Resources.Return__2_;
            returnsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            returnsBtn.Location = new Point(10, 329);
            returnsBtn.Name = "returnsBtn";
            returnsBtn.Size = new Size(211, 44);
            returnsBtn.TabIndex = 8;
            returnsBtn.Text = "  Returns";
            returnsBtn.UseVisualStyleBackColor = false;
            returnsBtn.Click += returnsBtn_Click;
            // 
            // rentalRequestsBtn
            // 
            rentalRequestsBtn.BackColor = Color.FromArgb(22, 34, 68);
            rentalRequestsBtn.FlatAppearance.BorderColor = Color.FromArgb(41, 58, 107);
            rentalRequestsBtn.FlatStyle = FlatStyle.Flat;
            rentalRequestsBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            rentalRequestsBtn.ForeColor = Color.FromArgb(233, 239, 255);
            rentalRequestsBtn.Image = Properties.Resources.Request;
            rentalRequestsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            rentalRequestsBtn.Location = new Point(10, 205);
            rentalRequestsBtn.Name = "rentalRequestsBtn";
            rentalRequestsBtn.Size = new Size(211, 44);
            rentalRequestsBtn.TabIndex = 7;
            rentalRequestsBtn.Text = "  Requests";
            rentalRequestsBtn.UseVisualStyleBackColor = false;
            rentalRequestsBtn.Click += rentalRequestsBtn_Click;
            // 
            // EquipmentBtn
            // 
            EquipmentBtn.BackColor = Color.FromArgb(22, 34, 68);
            EquipmentBtn.FlatAppearance.BorderColor = Color.FromArgb(41, 58, 107);
            EquipmentBtn.FlatStyle = FlatStyle.Flat;
            EquipmentBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            EquipmentBtn.ForeColor = Color.FromArgb(233, 239, 255);
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
            dashboardBtn.BackColor = Color.FromArgb(28, 44, 91);
            dashboardBtn.FlatAppearance.BorderColor = Color.FromArgb(41, 58, 107);
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dashboardBtn.ForeColor = Color.FromArgb(233, 239, 255);
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
            logotxt.Font = new Font("Vivaldi", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            logotxt.ForeColor = Color.White;
            logotxt.Location = new Point(8, 14);
            logotxt.Name = "logotxt";
            logotxt.Size = new Size(214, 32);
            logotxt.TabIndex = 0;
            logotxt.Text = "Lights And Lenses";
            logotxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // topHeaderPanel
            // 
            topHeaderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topHeaderPanel.BackColor = Color.FromArgb(22, 34, 68);
            topHeaderPanel.Controls.Add(labelUserName);
            topHeaderPanel.Controls.Add(pictureBoxAvatar);
            topHeaderPanel.Location = new Point(230, 0);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Padding = new Padding(10);
            topHeaderPanel.Size = new Size(1120, 60);
            topHeaderPanel.TabIndex = 1;
            // 
            // totalEquipmentPanel
            // 
            totalEquipmentPanel.Anchor = AnchorStyles.Top;
            totalEquipmentPanel.AutoSize = true;
            totalEquipmentPanel.BackColor = Color.FromArgb(23, 38, 80);
            totalEquipmentPanel.Controls.Add(pictureBox1);
            totalEquipmentPanel.Controls.Add(totalEquipmentNum);
            totalEquipmentPanel.Controls.Add(totalEquipmentTxt);
            totalEquipmentPanel.Location = new Point(271, 85);
            totalEquipmentPanel.Name = "totalEquipmentPanel";
            totalEquipmentPanel.Size = new Size(200, 80);
            totalEquipmentPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Camera;
            pictureBox1.Location = new Point(137, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // totalEquipmentNum
            // 
            totalEquipmentNum.AutoSize = true;
            totalEquipmentNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            totalEquipmentNum.ForeColor = Color.White;
            totalEquipmentNum.Location = new Point(29, 35);
            totalEquipmentNum.Name = "totalEquipmentNum";
            totalEquipmentNum.Size = new Size(56, 32);
            totalEquipmentNum.TabIndex = 4;
            totalEquipmentNum.Text = "300";
            // 
            // totalEquipmentTxt
            // 
            totalEquipmentTxt.AutoSize = true;
            totalEquipmentTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalEquipmentTxt.ForeColor = Color.White;
            totalEquipmentTxt.Location = new Point(11, 6);
            totalEquipmentTxt.Name = "totalEquipmentTxt";
            totalEquipmentTxt.Size = new Size(136, 21);
            totalEquipmentTxt.TabIndex = 3;
            totalEquipmentTxt.Text = "Total Equipment";
            // 
            // activeRentalsPanel
            // 
            activeRentalsPanel.Anchor = AnchorStyles.Top;
            activeRentalsPanel.AutoSize = true;
            activeRentalsPanel.BackColor = Color.FromArgb(23, 38, 80);
            activeRentalsPanel.Controls.Add(pictureBox2);
            activeRentalsPanel.Controls.Add(activeRentalsNum);
            activeRentalsPanel.Controls.Add(activeRentalsTxt);
            activeRentalsPanel.Location = new Point(481, 85);
            activeRentalsPanel.Name = "activeRentalsPanel";
            activeRentalsPanel.Size = new Size(200, 80);
            activeRentalsPanel.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Active;
            pictureBox2.Location = new Point(145, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // activeRentalsNum
            // 
            activeRentalsNum.AutoSize = true;
            activeRentalsNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            activeRentalsNum.ForeColor = Color.White;
            activeRentalsNum.Location = new Point(29, 35);
            activeRentalsNum.Name = "activeRentalsNum";
            activeRentalsNum.Size = new Size(56, 32);
            activeRentalsNum.TabIndex = 4;
            activeRentalsNum.Text = "189";
            // 
            // activeRentalsTxt
            // 
            activeRentalsTxt.AutoSize = true;
            activeRentalsTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            activeRentalsTxt.ForeColor = Color.White;
            activeRentalsTxt.Location = new Point(15, 6);
            activeRentalsTxt.Name = "activeRentalsTxt";
            activeRentalsTxt.Size = new Size(118, 21);
            activeRentalsTxt.TabIndex = 3;
            activeRentalsTxt.Text = "Active Rentals";
            // 
            // pendingRequestsPanel
            // 
            pendingRequestsPanel.Anchor = AnchorStyles.Top;
            pendingRequestsPanel.AutoSize = true;
            pendingRequestsPanel.BackColor = Color.FromArgb(23, 38, 80);
            pendingRequestsPanel.Controls.Add(pictureBox3);
            pendingRequestsPanel.Controls.Add(pendingRequestsNum);
            pendingRequestsPanel.Controls.Add(pendingRequestsTxt);
            pendingRequestsPanel.Location = new Point(691, 85);
            pendingRequestsPanel.Name = "pendingRequestsPanel";
            pendingRequestsPanel.Size = new Size(200, 80);
            pendingRequestsPanel.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Clock;
            pictureBox3.Location = new Point(145, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pendingRequestsNum
            // 
            pendingRequestsNum.AutoSize = true;
            pendingRequestsNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            pendingRequestsNum.ForeColor = Color.White;
            pendingRequestsNum.Location = new Point(40, 35);
            pendingRequestsNum.Name = "pendingRequestsNum";
            pendingRequestsNum.Size = new Size(42, 32);
            pendingRequestsNum.TabIndex = 4;
            pendingRequestsNum.Text = "32";
            // 
            // pendingRequestsTxt
            // 
            pendingRequestsTxt.AutoSize = true;
            pendingRequestsTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pendingRequestsTxt.ForeColor = Color.White;
            pendingRequestsTxt.Location = new Point(15, 6);
            pendingRequestsTxt.Name = "pendingRequestsTxt";
            pendingRequestsTxt.Size = new Size(146, 21);
            pendingRequestsTxt.TabIndex = 3;
            pendingRequestsTxt.Text = "Pending Requests";
            // 
            // overdueReturnsPanel
            // 
            overdueReturnsPanel.Anchor = AnchorStyles.Top;
            overdueReturnsPanel.AutoSize = true;
            overdueReturnsPanel.BackColor = Color.FromArgb(23, 38, 80);
            overdueReturnsPanel.Controls.Add(pictureBox4);
            overdueReturnsPanel.Controls.Add(overdueReturnsNum);
            overdueReturnsPanel.Controls.Add(overdueReturnsTxt);
            overdueReturnsPanel.Location = new Point(901, 85);
            overdueReturnsPanel.Name = "overdueReturnsPanel";
            overdueReturnsPanel.Size = new Size(200, 80);
            overdueReturnsPanel.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Overdue;
            pictureBox4.Location = new Point(147, 27);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // overdueReturnsNum
            // 
            overdueReturnsNum.AutoSize = true;
            overdueReturnsNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            overdueReturnsNum.ForeColor = Color.White;
            overdueReturnsNum.Location = new Point(40, 35);
            overdueReturnsNum.Name = "overdueReturnsNum";
            overdueReturnsNum.Size = new Size(42, 32);
            overdueReturnsNum.TabIndex = 4;
            overdueReturnsNum.Text = "12";
            // 
            // overdueReturnsTxt
            // 
            overdueReturnsTxt.AutoSize = true;
            overdueReturnsTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            overdueReturnsTxt.ForeColor = Color.White;
            overdueReturnsTxt.Location = new Point(15, 6);
            overdueReturnsTxt.Name = "overdueReturnsTxt";
            overdueReturnsTxt.Size = new Size(137, 21);
            overdueReturnsTxt.TabIndex = 3;
            overdueReturnsTxt.Text = "Overdue Returns";
            // 
            // underMaintenancePanel
            // 
            underMaintenancePanel.Anchor = AnchorStyles.Top;
            underMaintenancePanel.AutoSize = true;
            underMaintenancePanel.BackColor = Color.FromArgb(23, 38, 80);
            underMaintenancePanel.Controls.Add(pictureBox5);
            underMaintenancePanel.Controls.Add(underMaintenanceNum);
            underMaintenancePanel.Controls.Add(underMaintenanceTxt);
            underMaintenancePanel.Location = new Point(1111, 85);
            underMaintenancePanel.Name = "underMaintenancePanel";
            underMaintenancePanel.Size = new Size(197, 80);
            underMaintenancePanel.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Maintenance2;
            pictureBox5.Location = new Point(124, 28);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // underMaintenanceNum
            // 
            underMaintenanceNum.AutoSize = true;
            underMaintenanceNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            underMaintenanceNum.ForeColor = Color.White;
            underMaintenanceNum.Location = new Point(43, 35);
            underMaintenanceNum.Name = "underMaintenanceNum";
            underMaintenanceNum.Size = new Size(28, 32);
            underMaintenanceNum.TabIndex = 4;
            underMaintenanceNum.Text = "9";
            // 
            // underMaintenanceTxt
            // 
            underMaintenanceTxt.AutoSize = true;
            underMaintenanceTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            underMaintenanceTxt.ForeColor = Color.White;
            underMaintenanceTxt.Location = new Point(15, 6);
            underMaintenanceTxt.Name = "underMaintenanceTxt";
            underMaintenanceTxt.Size = new Size(161, 21);
            underMaintenanceTxt.TabIndex = 3;
            underMaintenanceTxt.Text = "Under Maintenance";
            // 
            // newRentalBtn
            // 
            newRentalBtn.Anchor = AnchorStyles.Top;
            newRentalBtn.BackColor = Color.FromArgb(18, 80, 198);
            newRentalBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newRentalBtn.ForeColor = Color.White;
            newRentalBtn.Image = Properties.Resources.NewRental;
            newRentalBtn.ImageAlign = ContentAlignment.MiddleLeft;
            newRentalBtn.Location = new Point(270, 178);
            newRentalBtn.Name = "newRentalBtn";
            newRentalBtn.Padding = new Padding(20, 0, 0, 0);
            newRentalBtn.Size = new Size(256, 42);
            newRentalBtn.TabIndex = 6;
            newRentalBtn.Text = "            New Rental";
            newRentalBtn.TextAlign = ContentAlignment.MiddleLeft;
            newRentalBtn.UseVisualStyleBackColor = false;
            // 
            // processReturnBtn
            // 
            processReturnBtn.Anchor = AnchorStyles.Top;
            processReturnBtn.BackColor = Color.FromArgb(107, 175, 109);
            processReturnBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            processReturnBtn.ForeColor = Color.White;
            processReturnBtn.Image = Properties.Resources.Return;
            processReturnBtn.ImageAlign = ContentAlignment.MiddleLeft;
            processReturnBtn.Location = new Point(531, 178);
            processReturnBtn.Name = "processReturnBtn";
            processReturnBtn.Padding = new Padding(20, 0, 0, 0);
            processReturnBtn.Size = new Size(256, 42);
            processReturnBtn.TabIndex = 10;
            processReturnBtn.Text = "          Process Return";
            processReturnBtn.TextAlign = ContentAlignment.MiddleLeft;
            processReturnBtn.UseVisualStyleBackColor = false;
            // 
            // LogsBtn
            // 
            LogsBtn.Anchor = AnchorStyles.Top;
            LogsBtn.BackColor = Color.FromArgb(133, 93, 212);
            LogsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LogsBtn.ForeColor = Color.White;
            LogsBtn.Image = Properties.Resources.Logs;
            LogsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LogsBtn.Location = new Point(1055, 178);
            LogsBtn.Name = "LogsBtn";
            LogsBtn.Padding = new Padding(20, 0, 0, 0);
            LogsBtn.Size = new Size(256, 42);
            LogsBtn.TabIndex = 11;
            LogsBtn.Text = "               View Logs";
            LogsBtn.TextAlign = ContentAlignment.MiddleLeft;
            LogsBtn.UseVisualStyleBackColor = false;
            LogsBtn.Click += LogsBtn_Click;
            // 
            // maintenanceBtn
            // 
            maintenanceBtn.Anchor = AnchorStyles.Top;
            maintenanceBtn.BackColor = Color.FromArgb(223, 121, 68);
            maintenanceBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            maintenanceBtn.ForeColor = Color.White;
            maintenanceBtn.Image = Properties.Resources.Maintenance;
            maintenanceBtn.ImageAlign = ContentAlignment.MiddleLeft;
            maintenanceBtn.Location = new Point(794, 178);
            maintenanceBtn.Name = "maintenanceBtn";
            maintenanceBtn.Padding = new Padding(20, 0, 0, 0);
            maintenanceBtn.Size = new Size(255, 42);
            maintenanceBtn.TabIndex = 12;
            maintenanceBtn.Text = "            Maintenance";
            maintenanceBtn.TextAlign = ContentAlignment.MiddleLeft;
            maintenanceBtn.UseVisualStyleBackColor = false;
            maintenanceBtn.Click += maintenanceBtn_Click;
            // 
            // equipmentInventoryPanel
            // 
            equipmentInventoryPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            equipmentInventoryPanel.BackColor = Color.FromArgb(23, 38, 80);
            equipmentInventoryPanel.Controls.Add(stabilizersPercentageLabel);
            equipmentInventoryPanel.Controls.Add(label6);
            equipmentInventoryPanel.Controls.Add(stabilizersProgressBar);
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
            equipmentInventoryPanel.Location = new Point(964, 309);
            equipmentInventoryPanel.Name = "equipmentInventoryPanel";
            equipmentInventoryPanel.Size = new Size(344, 296);
            equipmentInventoryPanel.TabIndex = 14;
            // 
            // stabilizersPercentageLabel
            // 
            stabilizersPercentageLabel.AutoSize = true;
            stabilizersPercentageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            stabilizersPercentageLabel.ForeColor = Color.White;
            stabilizersPercentageLabel.Location = new Point(282, 231);
            stabilizersPercentageLabel.Name = "stabilizersPercentageLabel";
            stabilizersPercentageLabel.Size = new Size(42, 21);
            stabilizersPercentageLabel.TabIndex = 22;
            stabilizersPercentageLabel.Text = "71%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(4, 232);
            label6.Name = "label6";
            label6.Size = new Size(89, 21);
            label6.TabIndex = 21;
            label6.Text = "Stabilizers";
            // 
            // stabilizersProgressBar
            // 
            stabilizersProgressBar.BackColor = Color.FromArgb(55, 65, 81);
            stabilizersProgressBar.Location = new Point(110, 235);
            stabilizersProgressBar.Name = "stabilizersProgressBar";
            stabilizersProgressBar.Size = new Size(149, 17);
            stabilizersProgressBar.TabIndex = 20;
            // 
            // accessoriesPercentageLabel
            // 
            accessoriesPercentageLabel.AutoSize = true;
            accessoriesPercentageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            accessoriesPercentageLabel.ForeColor = Color.White;
            accessoriesPercentageLabel.Location = new Point(282, 192);
            accessoriesPercentageLabel.Name = "accessoriesPercentageLabel";
            accessoriesPercentageLabel.Size = new Size(42, 21);
            accessoriesPercentageLabel.TabIndex = 19;
            accessoriesPercentageLabel.Text = "71%";
            // 
            // lightsPercentageLabel
            // 
            lightsPercentageLabel.AutoSize = true;
            lightsPercentageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lightsPercentageLabel.ForeColor = Color.White;
            lightsPercentageLabel.Location = new Point(282, 149);
            lightsPercentageLabel.Name = "lightsPercentageLabel";
            lightsPercentageLabel.Size = new Size(42, 21);
            lightsPercentageLabel.TabIndex = 18;
            lightsPercentageLabel.Text = "47%";
            // 
            // lensesPercentageLabel
            // 
            lensesPercentageLabel.AutoSize = true;
            lensesPercentageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lensesPercentageLabel.ForeColor = Color.White;
            lensesPercentageLabel.Location = new Point(282, 106);
            lensesPercentageLabel.Name = "lensesPercentageLabel";
            lensesPercentageLabel.Size = new Size(42, 21);
            lensesPercentageLabel.TabIndex = 17;
            lensesPercentageLabel.Text = "62%";
            // 
            // cameraPercentageLabel
            // 
            cameraPercentageLabel.AutoSize = true;
            cameraPercentageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cameraPercentageLabel.ForeColor = Color.White;
            cameraPercentageLabel.Location = new Point(282, 65);
            cameraPercentageLabel.Name = "cameraPercentageLabel";
            cameraPercentageLabel.Size = new Size(42, 21);
            cameraPercentageLabel.TabIndex = 16;
            cameraPercentageLabel.Text = "85%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(4, 193);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 15;
            label5.Text = "Accessories";
            // 
            // accessoriesProgressBar
            // 
            accessoriesProgressBar.BackColor = Color.FromArgb(55, 65, 81);
            accessoriesProgressBar.Location = new Point(110, 196);
            accessoriesProgressBar.Name = "accessoriesProgressBar";
            accessoriesProgressBar.Size = new Size(149, 17);
            accessoriesProgressBar.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 150);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 13;
            label3.Text = "Lights";
            // 
            // lightsProgressBar
            // 
            lightsProgressBar.BackColor = Color.FromArgb(55, 65, 81);
            lightsProgressBar.Location = new Point(110, 153);
            lightsProgressBar.Name = "lightsProgressBar";
            lightsProgressBar.Size = new Size(149, 17);
            lightsProgressBar.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 107);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 11;
            label2.Text = "Lenses";
            // 
            // lensesProgressBar
            // 
            lensesProgressBar.BackColor = Color.FromArgb(55, 65, 81);
            lensesProgressBar.Location = new Point(110, 110);
            lensesProgressBar.Name = "lensesProgressBar";
            lensesProgressBar.Size = new Size(149, 17);
            lensesProgressBar.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 65);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 9;
            label1.Text = "Cameras";
            // 
            // cameraProgressBar
            // 
            cameraProgressBar.BackColor = Color.FromArgb(55, 65, 81);
            cameraProgressBar.Location = new Point(110, 69);
            cameraProgressBar.Name = "cameraProgressBar";
            cameraProgressBar.Size = new Size(149, 17);
            cameraProgressBar.TabIndex = 8;
            // 
            // equipmentInventoryTxt
            // 
            equipmentInventoryTxt.AutoSize = true;
            equipmentInventoryTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            equipmentInventoryTxt.ForeColor = Color.White;
            equipmentInventoryTxt.Location = new Point(6, 3);
            equipmentInventoryTxt.Name = "equipmentInventoryTxt";
            equipmentInventoryTxt.Size = new Size(222, 30);
            equipmentInventoryTxt.TabIndex = 7;
            equipmentInventoryTxt.Text = "Equipment Inventory";
            // 
            // tabRecentActivities
            // 
            tabRecentActivities.Controls.Add(tabRequests);
            tabRecentActivities.Controls.Add(tabRentals);
            tabRecentActivities.Controls.Add(tabReturns);
            tabRecentActivities.Location = new Point(271, 285);
            tabRecentActivities.Name = "tabRecentActivities";
            tabRecentActivities.SelectedIndex = 0;
            tabRecentActivities.Size = new Size(671, 323);
            tabRecentActivities.TabIndex = 18;
            tabRecentActivities.SelectedIndexChanged += tabRecentActivities_SelectedIndexChanged;
            // 
            // tabRequests
            // 
            tabRequests.BackColor = Color.FromArgb(31, 41, 55);
            tabRequests.Controls.Add(dataGridViewRequests);
            tabRequests.Location = new Point(4, 24);
            tabRequests.Name = "tabRequests";
            tabRequests.Padding = new Padding(3);
            tabRequests.Size = new Size(663, 295);
            tabRequests.TabIndex = 0;
            tabRequests.Text = "Requests";
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataGridViewRequests.BackgroundColor = Color.White;
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(18, 80, 198);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridViewRequests.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewRequests.Location = new Point(3, 3);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.RowTemplate.Height = 25;
            dataGridViewRequests.Size = new Size(657, 289);
            dataGridViewRequests.TabIndex = 4;
            // 
            // tabRentals
            // 
            tabRentals.BackColor = Color.FromArgb(31, 41, 55);
            tabRentals.Controls.Add(dataGridViewRentals);
            tabRentals.Location = new Point(4, 24);
            tabRentals.Name = "tabRentals";
            tabRentals.Padding = new Padding(3);
            tabRentals.Size = new Size(663, 295);
            tabRentals.TabIndex = 1;
            tabRentals.Text = "Rentals";
            // 
            // dataGridViewRentals
            // 
            dataGridViewRentals.BackgroundColor = Color.White;
            dataGridViewRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(18, 80, 198);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridViewRentals.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewRentals.Dock = DockStyle.Fill;
            dataGridViewRentals.Location = new Point(3, 3);
            dataGridViewRentals.Name = "dataGridViewRentals";
            dataGridViewRentals.RowTemplate.Height = 25;
            dataGridViewRentals.Size = new Size(657, 289);
            dataGridViewRentals.TabIndex = 19;
            // 
            // tabReturns
            // 
            tabReturns.BackColor = Color.FromArgb(31, 41, 55);
            tabReturns.Controls.Add(dataGridViewReturns);
            tabReturns.Location = new Point(4, 24);
            tabReturns.Name = "tabReturns";
            tabReturns.Padding = new Padding(3);
            tabReturns.Size = new Size(663, 295);
            tabReturns.TabIndex = 2;
            tabReturns.Text = "Returns";
            // 
            // dataGridViewReturns
            // 
            dataGridViewReturns.BackgroundColor = Color.White;
            dataGridViewReturns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(18, 80, 198);
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridViewReturns.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewReturns.Dock = DockStyle.Fill;
            dataGridViewReturns.Location = new Point(3, 3);
            dataGridViewReturns.Name = "dataGridViewReturns";
            dataGridViewReturns.RowTemplate.Height = 25;
            dataGridViewReturns.Size = new Size(657, 289);
            dataGridViewReturns.TabIndex = 19;
            // 
            // recentActivitiesTxt
            // 
            recentActivitiesTxt.AutoSize = true;
            recentActivitiesTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            recentActivitiesTxt.ForeColor = Color.White;
            recentActivitiesTxt.Location = new Point(270, 246);
            recentActivitiesTxt.Name = "recentActivitiesTxt";
            recentActivitiesTxt.Size = new Size(175, 30);
            recentActivitiesTxt.TabIndex = 6;
            recentActivitiesTxt.Text = "Recent Activities";
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Image = Properties.Resources.Avatar;
            pictureBoxAvatar.Location = new Point(1053, 9);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(43, 43);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 21;
            pictureBoxAvatar.TabStop = false;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.ForeColor = Color.White;
            labelUserName.Location = new Point(951, 21);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(94, 21);
            labelUserName.TabIndex = 21;
            labelUserName.Text = "User Name";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(18, 28, 58);
            ClientSize = new Size(1350, 825);
            Controls.Add(recentActivitiesTxt);
            Controls.Add(tabRecentActivities);
            Controls.Add(equipmentInventoryPanel);
            Controls.Add(maintenanceBtn);
            Controls.Add(LogsBtn);
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
            Text = " ";
            Load += Form1_Load;
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            topHeaderPanel.ResumeLayout(false);
            topHeaderPanel.PerformLayout();
            totalEquipmentPanel.ResumeLayout(false);
            totalEquipmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            activeRentalsPanel.ResumeLayout(false);
            activeRentalsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pendingRequestsPanel.ResumeLayout(false);
            pendingRequestsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            overdueReturnsPanel.ResumeLayout(false);
            overdueReturnsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            underMaintenancePanel.ResumeLayout(false);
            underMaintenancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            equipmentInventoryPanel.ResumeLayout(false);
            equipmentInventoryPanel.PerformLayout();
            tabRecentActivities.ResumeLayout(false);
            tabRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
            tabRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRentals).EndInit();
            tabReturns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReturns).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Panel sidePanel;
        private Label logotxt;
        private Button dashboardBtn;
        private Button EquipmentBtn;
        private Panel topHeaderPanel;
        private Panel totalEquipmentPanel;
        private Label totalEquipmentNum;
        private Label totalEquipmentTxt;
        private Panel activeRentalsPanel;
        private Label activeRentalsNum;
        private Label activeRentalsTxt;
        private Panel pendingRequestsPanel;
        private Label pendingRequestsNum;
        private Label pendingRequestsTxt;
        private Panel overdueReturnsPanel;
        private Label overdueReturnsNum;
        private Label overdueReturnsTxt;
        private Panel underMaintenancePanel;
        private Label underMaintenanceNum;
        private Label underMaintenanceTxt;
        private Button newRentalBtn;
        private Button processReturnBtn;
        private Button LogsBtn;
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
        private TabPage tabRequests;
        private TabPage tabRentals;
        private TabPage tabReturns;
        private DataGridView dataGridViewRequests;
        private DataGridView dataGridViewRentals;
        private DataGridView dataGridViewReturns;
        private Label recentActivitiesTxt;
        private Label stabilizersPercentageLabel;
        private Label label6;
        private ProgressBar stabilizersProgressBar;
        private Button rentalTransactionsBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private Label labelUserName;
        private PictureBox pictureBoxAvatar;
    }
}
