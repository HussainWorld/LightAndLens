﻿namespace LightAndLens_FormApp
{
    partial class Logs
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
            dgvLogs = new DataGridView();
            logslbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 41, 55);
            panel1.Controls.Add(dgvLogs);
            panel1.Location = new Point(12, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 752);
            panel1.TabIndex = 0;
            // 
            // dgvLogs
            // 
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(12, 14);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowTemplate.Height = 25;
            dgvLogs.Size = new Size(503, 728);
            dgvLogs.TabIndex = 0;
            // 
            // logslbl
            // 
            logslbl.AutoSize = true;
            logslbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            logslbl.ForeColor = Color.LightGray;
            logslbl.Location = new Point(223, 9);
            logslbl.Name = "logslbl";
            logslbl.Size = new Size(103, 50);
            logslbl.TabIndex = 16;
            logslbl.Text = "Logs";
            logslbl.Click += EquipmentUnderMaintenancetxt_Click;
            // 
            // Logs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(551, 843);
            Controls.Add(logslbl);
            Controls.Add(panel1);
            Name = "Logs";
            Text = "Logs";
            Load += Logs_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label logslbl;
        private DataGridView dgvLogs;
    }
}