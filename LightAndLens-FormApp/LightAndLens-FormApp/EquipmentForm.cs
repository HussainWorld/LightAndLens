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
            HighlightActiveButton(EquipmentBtn);

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

            labelUserName.Text = Session.CurrentUser.UserName;
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

                    var mainImage = selectedEquipment.EquipmentImages.FirstOrDefault(i => i.IsMain == true);
                    if (mainImage != null)
                    {
                        var sharedImagePath = Path.Combine(@"..\..\..\..\SharedImages", mainImage.ImagePath);
                        if (File.Exists(sharedImagePath))
                        {
                            try
                            {
                                using (var tempImage = Image.FromFile(sharedImagePath))
                                {
                                    pictureBoxEquipment.Image = new Bitmap(tempImage);
                                }
                            }
                            catch (OutOfMemoryException)
                            {
                                MessageBox.Show("The image file exists but it is not a valid image format.", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                pictureBoxEquipment.Image = null;
                            }
                        }
                        else
                        {
                            pictureBoxEquipment.Image = null;
                        }
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

        private void HighlightActiveButton(Button activeButton)
        {
            // Put all buttons in a list for easy iteration
            var buttons = new List<Button> {
            dashboardBtn,
            EquipmentBtn,
            rentalRequestsBtn,
            returnsBtn,
            analyticsBtn,
            rentalTransactionsBtn
    };

            Color defaultBackColor = Color.FromArgb(22, 34, 68);
            Color defaultForeColor = Color.FromArgb(233, 239, 255);
            Color defaultBorderColor = Color.FromArgb(41, 58, 107);
            float fontSize = 15.75F;

            // Reset all buttons to default
            foreach (var btn in buttons)
            {
                btn.BackColor = defaultBackColor;
                btn.ForeColor = defaultForeColor;
                btn.FlatAppearance.BorderColor = defaultBorderColor;
                btn.ImageAlign = ContentAlignment.MiddleLeft;
                btn.Font = new Font(btn.Font.FontFamily, fontSize, FontStyle.Bold);

            }

            // Set the active button style
            activeButton.BackColor = Color.FromArgb(28, 44, 91);
            activeButton.ForeColor = Color.White;
            activeButton.FlatAppearance.BorderColor = Color.FromArgb(41, 58, 107);
        }

        private void EquipmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            var DashboardForm = new Dashboard();
            DashboardForm.Show();
            this.Hide();

        }

        private void EquipmentBtn_Click(object sender, EventArgs e)
        {

        }

        private void rentalRequestsBtn_Click(object sender, EventArgs e)
        {
            var requestsForm = new RentalRequests();
            requestsForm.Show();
            this.Hide();
        }

        private void rentalTransactionsBtn_Click(object sender, EventArgs e)
        {
            var RentalTransactionsForm = new RentalTransactions();
            RentalTransactionsForm.Show();
            this.Hide();
        }

        private void returnsBtn_Click(object sender, EventArgs e)
        {
            var returnsForm = new Returns();
            returnsForm.Show();
            this.Hide();
        }

        private void analyticsBtn_Click(object sender, EventArgs e)
        {
        MessageBox.Show(
        "Whoa! This is an exclusive feature for premium members only.\nUpgrade membership to unlock powerful analytics!",
        "Premium Feature",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
        }

        private void EquipmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

