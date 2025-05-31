namespace LightAndLens_FormApp
{
    partial class AddEditEquipmentForm
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
            txtName = new TextBox();
            lblName = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            ddlCategory = new ComboBox();
            lblCategory = new Label();
            lblAvailability = new Label();
            lblCondition = new Label();
            ddlStatus = new ComboBox();
            ddlCondition = new ComboBox();
            numQuantity = new NumericUpDown();
            label1 = new Label();
            lblQuantity = new Label();
            numPrice = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnAddImage = new Button();
            pbPreview = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPreview).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(256, 16);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(165, 23);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(70, 18);
            lblName.Name = "lblName";
            lblName.Size = new Size(148, 21);
            lblName.TabIndex = 1;
            lblName.Text = "Equipment Name:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(256, 48);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(165, 23);
            txtDescription.TabIndex = 0;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(28, 50);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(190, 21);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Equipment Description:";
            // 
            // ddlCategory
            // 
            ddlCategory.FormattingEnabled = true;
            ddlCategory.Location = new Point(256, 80);
            ddlCategory.Margin = new Padding(3, 2, 3, 2);
            ddlCategory.Name = "ddlCategory";
            ddlCategory.Size = new Size(165, 23);
            ddlCategory.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(46, 82);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(172, 21);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Equipment Category:";
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvailability.ForeColor = Color.White;
            lblAvailability.Location = new Point(28, 115);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(190, 21);
            lblAvailability.TabIndex = 1;
            lblAvailability.Text = "Equipment Availability:";
            lblAvailability.Click += label2_Click;
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCondition.ForeColor = Color.White;
            lblCondition.Location = new Point(40, 152);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(178, 21);
            lblCondition.TabIndex = 1;
            lblCondition.Text = "Equipment Condition:";
            lblCondition.Click += label2_Click;
            // 
            // ddlStatus
            // 
            ddlStatus.FormattingEnabled = true;
            ddlStatus.Location = new Point(256, 113);
            ddlStatus.Margin = new Padding(3, 2, 3, 2);
            ddlStatus.Name = "ddlStatus";
            ddlStatus.Size = new Size(165, 23);
            ddlStatus.TabIndex = 2;
            // 
            // ddlCondition
            // 
            ddlCondition.FormattingEnabled = true;
            ddlCondition.Location = new Point(256, 147);
            ddlCondition.Margin = new Padding(3, 2, 3, 2);
            ddlCondition.Name = "ddlCondition";
            ddlCondition.Size = new Size(165, 23);
            ddlCondition.TabIndex = 2;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(293, 215);
            numQuantity.Margin = new Padding(3, 2, 3, 2);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(88, 23);
            numQuantity.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 183);
            label1.Name = "label1";
            label1.Size = new Size(168, 21);
            label1.TabIndex = 1;
            label1.Text = "Rental Price Per Day:";
            label1.Click += label2_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(137, 217);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(81, 21);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity:";
            lblQuantity.Click += label2_Click;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(256, 181);
            numPrice.Margin = new Padding(3, 2, 3, 2);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(165, 23);
            numPrice.TabIndex = 0;
            numPrice.TextChanged += txtDescription_TextChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(223, 299);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 28);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(378, 299);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(71, 28);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddImage
            // 
            btnAddImage.BackColor = Color.FromArgb(18, 80, 198);
            btnAddImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddImage.ForeColor = SystemColors.ButtonFace;
            btnAddImage.Location = new Point(517, 181);
            btnAddImage.Margin = new Padding(3, 2, 3, 2);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(104, 28);
            btnAddImage.TabIndex = 5;
            btnAddImage.Text = "Browse Image";
            btnAddImage.UseVisualStyleBackColor = false;
            btnAddImage.Click += btnUploadImage_Click;
            // 
            // pbPreview
            // 
            pbPreview.BackColor = Color.FromArgb(23, 38, 80);
            pbPreview.Location = new Point(477, 23);
            pbPreview.Margin = new Padding(3, 2, 3, 2);
            pbPreview.Name = "pbPreview";
            pbPreview.Size = new Size(178, 150);
            pbPreview.TabIndex = 6;
            pbPreview.TabStop = false;
            // 
            // AddEditEquipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 28, 58);
            ClientSize = new Size(700, 338);
            Controls.Add(pbPreview);
            Controls.Add(btnAddImage);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numQuantity);
            Controls.Add(ddlCondition);
            Controls.Add(ddlStatus);
            Controls.Add(ddlCategory);
            Controls.Add(lblQuantity);
            Controls.Add(label1);
            Controls.Add(lblCondition);
            Controls.Add(lblAvailability);
            Controls.Add(lblCategory);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(numPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddEditEquipmentForm";
            Text = "AddEditEquipmentForm";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private TextBox txtDescription;
        private Label lblDescription;
        private ComboBox ddlCategory;
        private Label lblCategory;
        private Label lblAvailability;
        private Label lblCondition;
        private ComboBox ddlStatus;
        private ComboBox ddlCondition;
        private NumericUpDown numQuantity;
        private Label label1;
        private Label lblQuantity;
        private TextBox numPrice;
        private Button btnSave;
        private Button btnCancel;
        private Button btnAddImage;
        private PictureBox pbPreview;
    }
}