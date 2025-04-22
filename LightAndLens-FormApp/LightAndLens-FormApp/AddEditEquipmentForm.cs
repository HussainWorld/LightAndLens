using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightAndLensCL;
using LightAndLensCL.Models;

namespace LightAndLens_FormApp
{

    public partial class AddEditEquipmentForm : Form
    {
        private readonly Equipment _equipment;
        private readonly bool _isEditMode;
        private readonly LightAndLensDBContext _context;
        LightAndLensDBContext LightAndLensDBContext;
        public AddEditEquipmentForm(LightAndLensDBContext context, Equipment equipment = null)
        {
            InitializeComponent();
            _context = context;
            _equipment = equipment;
            _isEditMode = equipment != null;

            LoadDropdowns();

            if (_isEditMode)
                LoadData();
        }

        private void LoadDropdowns()
        {
            ddlCategory.DataSource = _context.Categories.ToList();
            ddlCategory.DisplayMember = "CategoryName";
            ddlCategory.ValueMember = "CategoryId";

            ddlCondition.DataSource = _context.ConditionStatuses.ToList();
            ddlCondition.DisplayMember = "ConditionName";
            ddlCondition.ValueMember = "ConditionId";

            ddlStatus.DataSource = _context.AvailabilityStatuses.ToList();
            ddlStatus.DisplayMember = "AvailabilityStatusName";
            ddlStatus.ValueMember = "AvailabilityId";
        }

        private void LoadData()
        {
            txtName.Text = _equipment.EquipmentName;
            txtDescription.Text = _equipment.Description;
            ddlCategory.SelectedValue = _equipment.CategoryId;
            ddlCondition.SelectedValue = _equipment.ConditionId;
            ddlStatus.SelectedValue = _equipment.AvailabilityId ?? -1;
            numQuantity.Value = _equipment.Quantity;
            numPrice.Text = _equipment.RentalPricePerDay.ToString("0.00");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(numPrice.Text.Trim(), out double price))
            {
                MessageBox.Show("Please enter a valid rental price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_isEditMode)
            {
                _equipment.EquipmentName = txtName.Text.Trim();
                _equipment.Description = txtDescription.Text.Trim();
                _equipment.CategoryId = (int)ddlCategory.SelectedValue;
                _equipment.ConditionId = (int)ddlCondition.SelectedValue;
                _equipment.AvailabilityId = (int)ddlStatus.SelectedValue;
                _equipment.Quantity = (int)numQuantity.Value;
                _equipment.RentalPricePerDay = (decimal)price;

                _context.Equipment.Update(_equipment);
            }
            else
            {
                var newEquipment = new Equipment
                {
                    EquipmentName = txtName.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    CategoryId = (int)ddlCategory.SelectedValue,
                    ConditionId = (int)ddlCondition.SelectedValue,
                    AvailabilityId = (int)ddlStatus.SelectedValue,
                    Quantity = (int)numQuantity.Value,
                    RentalPricePerDay = (decimal)price
                };

                _context.Equipment.Add(newEquipment);
            }

            _context.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
