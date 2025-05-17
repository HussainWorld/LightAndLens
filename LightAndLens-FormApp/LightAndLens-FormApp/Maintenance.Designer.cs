namespace LightAndLens_FormApp
{
    partial class Maintenance
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
            EquipmentUnderMaintenancetxt = new Label();
            btnApplyChanges = new Button();
            dgvMaintenance = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenance).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 41, 55);
            panel1.Controls.Add(EquipmentUnderMaintenancetxt);
            panel1.Controls.Add(btnApplyChanges);
            panel1.Controls.Add(dgvMaintenance);
            panel1.Location = new Point(23, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 581);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // EquipmentUnderMaintenancetxt
            // 
            EquipmentUnderMaintenancetxt.AutoSize = true;
            EquipmentUnderMaintenancetxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            EquipmentUnderMaintenancetxt.ForeColor = Color.LightGray;
            EquipmentUnderMaintenancetxt.Location = new Point(19, 16);
            EquipmentUnderMaintenancetxt.Name = "EquipmentUnderMaintenancetxt";
            EquipmentUnderMaintenancetxt.Size = new Size(319, 30);
            EquipmentUnderMaintenancetxt.TabIndex = 15;
            EquipmentUnderMaintenancetxt.Text = "Equipment Under Maintenance";
            EquipmentUnderMaintenancetxt.Click += recentActivitiesTxt_Click;
            // 
            // btnApplyChanges
            // 
            btnApplyChanges.BackColor = SystemColors.HotTrack;
            btnApplyChanges.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnApplyChanges.ForeColor = Color.White;
            btnApplyChanges.Location = new Point(204, 509);
            btnApplyChanges.Name = "btnApplyChanges";
            btnApplyChanges.Size = new Size(180, 34);
            btnApplyChanges.TabIndex = 13;
            btnApplyChanges.Text = "Apply Changes";
            btnApplyChanges.UseVisualStyleBackColor = false;
            btnApplyChanges.Click += btnApplyChanges_Click;
            // 
            // dgvMaintenance
            // 
            dgvMaintenance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaintenance.Location = new Point(19, 61);
            dgvMaintenance.Name = "dgvMaintenance";
            dgvMaintenance.RowTemplate.Height = 25;
            dgvMaintenance.Size = new Size(564, 432);
            dgvMaintenance.TabIndex = 0;
            // 
            // Maintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(639, 628);
            Controls.Add(panel1);
            Name = "Maintenance";
            Text = "Maintenance";
            Load += Maintenance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvMaintenance;
        private Button btnApplyChanges;
        private Label label1;
        private Label EquipmentUnderMaintenancetxt;
    }
}