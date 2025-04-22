using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightAndLensCL;
using LightAndLensCL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LightAndLens_FormApp
{
    public partial class EquipmentForm : Form
    {
        LightAndLensDBContext LightAndLensDBContext;
        public EquipmentForm()
        {
            InitializeComponent();
            LightAndLensDBContext = new LightAndLensDBContext();
            LoadFilters();

        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            var equipmentList = LightAndLensDBContext.Equipment
            .Include(e => e.Category)
            .Include(e => e.Condition)
            .Select(e => new
            {
                e.EquipmentId,
                e.EquipmentName,
                e.Description,
                Category = e.Category.CategoryName,
                Condition = e.Condition.ConditionName,
                e.RentalPricePerDay,
                e.Quantity
            })
            .ToList();

            dgvListEquipment.DataSource = equipmentList;


        }


        private void dgvEquipment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListEquipment.SelectedCells.Count > 0)
            {
                DataGridViewRow currentRow = dgvListEquipment.SelectedCells[0].OwningRow;

                int selectedId = Convert.ToInt32(currentRow.Cells["EquipmentId"].Value);

                var selectedEquipment = LightAndLensDBContext.Equipment
                    .Include(e => e.Category)
                    .Include(e => e.Condition)
                    .Include(e => e.EquipmentImages)
                    .FirstOrDefault(e => e.EquipmentId == selectedId);

                if (selectedEquipment != null)
                {
                    equipmentDetailsTxt.Text = selectedEquipment.EquipmentName;
                    lblEquipmentDesc.Text = selectedEquipment.Description;
                    txtCategory.Text = selectedEquipment.Category?.CategoryName ?? "N/A";
                    txtCondition.Text = selectedEquipment.Condition?.ConditionName ?? "N/A";
                    txtQuantity.Text = selectedEquipment.Quantity.ToString();

                    var mainImage = selectedEquipment.EquipmentImages.FirstOrDefault();
                    if (mainImage != null && File.Exists(mainImage.ImagePath))
                    {
                        pictureBoxEquipment.Image = Image.FromFile(mainImage.ImagePath);
                    }
                    else
                    {
                        pictureBoxEquipment.Image = null;
                    }
                }
            }
        }

        private void LoadFilters()
        {
            // Category
            ddlCategory.DataSource = null;
            ddlCategory.Items.Clear();
            var categories = LightAndLensDBContext.Categories.ToList();
            ddlCategory.DisplayMember = "CategoryName";
            ddlCategory.ValueMember = "CategoryId";
            ddlCategory.DataSource = categories;
            ddlCategory.SelectedIndex = -1;

            // Status
            ddlStatus.DataSource = null;
            ddlStatus.Items.Clear();
            var statuses = LightAndLensDBContext.AvailabilityStatuses.ToList();

            ddlStatus.DisplayMember = "AvailabilityStatusName";
            ddlStatus.ValueMember = "AvailabilityId";
            ddlStatus.DataSource = statuses;
            ddlStatus.SelectedIndex = -1;

            // Condition
            ddlCondition.DataSource = null;
            ddlCondition.Items.Clear();
            var conditions = LightAndLensDBContext.ConditionStatuses.ToList();
            ddlCondition.DisplayMember = "ConditionName";
            ddlCondition.ValueMember = "ConditionId";
            ddlCondition.SelectedIndex = -1;
            ddlCondition.DataSource = conditions;


        }




        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.ToLower();

            int categoryId = ddlCategory.SelectedIndex != -1 ? Convert.ToInt32(ddlCategory.SelectedValue) : 0;
            int statusId = ddlStatus.SelectedIndex != -1 ? Convert.ToInt32(ddlStatus.SelectedValue) : 0;
            int conditionId = ddlCondition.SelectedIndex != -1 ? Convert.ToInt32(ddlCondition.SelectedValue) : 0;

            var filteredQuery = LightAndLensDBContext.Equipment
                .Include(x => x.Category)
                .Include(x => x.Condition)
                .Include(x => x.Availability)
                .AsQueryable();


            if (!string.IsNullOrWhiteSpace(searchKeyword))
            {
                filteredQuery = filteredQuery.Where(x => x.EquipmentName.ToLower().Contains(searchKeyword));

            }


            if (categoryId != 0)
            {
                filteredQuery = filteredQuery.Where(x => x.CategoryId == categoryId);
            }


            if (conditionId != 0)
            {
                filteredQuery = filteredQuery.Where(x => x.ConditionId == conditionId);
            }


            if (statusId != 0)
            {
                filteredQuery = filteredQuery.Where(x => x.AvailabilityId == statusId);
            }


            var filtered = filteredQuery
                .Select(x => new
                {
                    x.EquipmentId,
                    x.EquipmentName,
                    x.Description,
                    Category = x.Category.CategoryName,
                    Condition = x.Condition.ConditionName,
                    Status = x.Availability.AvailabilityStatusName,
                    x.RentalPricePerDay,
                    x.Quantity
                })
                .ToList();

            dgvListEquipment.DataSource = filtered;
        }




        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void RefreshDgv()
        {
            var equipmentList = LightAndLensDBContext.Equipment
                .Include(e => e.Category)
                .Include(e => e.Condition)
                .Include(e => e.Availability)
                .Select(e => new
                {
                    e.EquipmentId,
                    e.EquipmentName,
                    e.Description,
                    Category = e.Category.CategoryName,
                    Condition = e.Condition.ConditionName,
                    Status = e.Availability.AvailabilityStatusName,
                    e.RentalPricePerDay,
                    e.Quantity
                })
                .ToList();

            dgvListEquipment.DataSource = equipmentList;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 1. Clear filters
            txtSearch.Text = "";
            ddlCategory.SelectedIndex = -1;
            ddlStatus.SelectedIndex = -1;
            ddlCondition.SelectedIndex = -1;

            // 2. Reload all equipment
            var equipmentList = LightAndLensDBContext.Equipment
                .Include(e => e.Category)
                .Include(e => e.Condition)
                .Include(e => e.Availability)
                .Select(e => new
                {
                    e.EquipmentId,
                    e.EquipmentName,
                    e.Description,
                    Category = e.Category.CategoryName,
                    Condition = e.Condition.ConditionName,
                    Status = e.Availability.AvailabilityStatusName,
                    e.RentalPricePerDay,
                    e.Quantity
                })
                .ToList();

            dgvListEquipment.DataSource = equipmentList;
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            var form = new AddEditEquipmentForm(LightAndLensDBContext);
            if (form.ShowDialog() == DialogResult.OK)
                RefreshDgv();
        }

        private void btnEditEquipment_Click(object sender, EventArgs e)
        {
            if (dgvListEquipment.SelectedCells.Count > 0)
            {
                var selectedRow = dgvListEquipment.SelectedCells[0].OwningRow;
                int equipmentId = Convert.ToInt32(selectedRow.Cells["EquipmentId"].Value);

                var equipment = LightAndLensDBContext.Equipment.Find(equipmentId);
                var form = new AddEditEquipmentForm(LightAndLensDBContext, equipment);

                if (form.ShowDialog() == DialogResult.OK)
                    RefreshDgv();
            }
        }

        private void btnRefreshEquipment_Click(object sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListEquipment.SelectedCells.Count > 0)
            {
                var selectedRow = dgvListEquipment.SelectedCells[0].OwningRow;
                int equipmentId = Convert.ToInt32(selectedRow.Cells["EquipmentId"].Value);
                string equipmentName = selectedRow.Cells["EquipmentName"].Value.ToString();

                var confirm = MessageBox.Show(
                    $"Are you sure you want to delete '{equipmentName}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    var equipmentToDelete = LightAndLensDBContext.Equipment
                        .FirstOrDefault(e => e.EquipmentId == equipmentId);

                    if (equipmentToDelete != null)
                    {
                        LightAndLensDBContext.Equipment.Remove(equipmentToDelete);
                        LightAndLensDBContext.SaveChanges();
                        MessageBox.Show($"'{equipmentName}' was deleted successfully.");
                        RefreshDgv();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an equipment row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvListEquipment.SelectedCells.Count > 0)
            {
                var selectedRow = dgvListEquipment.SelectedCells[0].OwningRow;
                int equipmentId = Convert.ToInt32(selectedRow.Cells["EquipmentId"].Value);
                string equipmentName = selectedRow.Cells["EquipmentName"].Value.ToString();

                var confirm = MessageBox.Show(
                    $"Are you sure you want to delete '{equipmentName}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    var equipmentToDelete = LightAndLensDBContext.Equipment
                        .FirstOrDefault(e => e.EquipmentId == equipmentId);

                    if (equipmentToDelete != null)
                    {
                        LightAndLensDBContext.Equipment.Remove(equipmentToDelete);
                        LightAndLensDBContext.SaveChanges();
                        MessageBox.Show($"'{equipmentName}' was deleted successfully.");
                        RefreshDgv();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an equipment row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EquipmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

