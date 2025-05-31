using LightAndLensCL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightAndLens_FormApp
{
    public partial class Returns : Form
    {
        private readonly LightAndLensDBContext _context = new LightAndLensDBContext();
        private int _selectedReturnId = -1;
        public Returns()
        {
            InitializeComponent();
            HighlightActiveButton(returnsBtn);
            LoadPendingReturns();
            LoadConditionDropdown();
        }

        private void Returns_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            var DashboardForm = new Dashboard();
            DashboardForm.Show();
            this.Hide();

        }

        private void EquipmentBtn_Click(object sender, EventArgs e)
        {
            var equipmentForm = new EquipmentForm();
            equipmentForm.Show();
            this.Hide();
        }

        private void rentalRequestsBtn_Click(object sender, EventArgs e)
        {
            var requestsForm = new RentalRequests();
            requestsForm.Show();
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

        private void rentalTransactionsBtn_Click(object sender, EventArgs e)
        {
            var RentalTransactionsForm = new RentalTransactions();
            RentalTransactionsForm.Show();
            this.Hide();
        }

        private void LoadPendingReturns(string search = "")
        {
            var query = _context.ReturnRecords
                .Include(r => r.Rental)
                    .ThenInclude(rt => rt.Request)
                        .ThenInclude(req => req.Equipment)
                .Include(r => r.Rental)
                    .ThenInclude(rt => rt.User)
                .Where(r => r.ConditionStatus == "Pending");

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(r => r.Rental.User.FullName.Contains(search) ||
                                         r.Rental.Request.Equipment.EquipmentName.Contains(search));
            }

            var list = query.Select(r => new
            {
                ReturnId = r.ReturnId,
                CustomerName = r.Rental.User.FullName,
                EquipmentName = r.Rental.Request.Equipment.EquipmentName,
                ReturnDate = r.ReturnDate,
                Notes = r.Notes
            }).ToList();

            dgvListReturns.DataSource = list;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPendingReturns(txtSearch.Text.Trim());
        }

        private void LoadConditionDropdown()
        {
            var conditions = _context.ConditionStatuses
                .Select(c => new { c.ConditionId, c.ConditionName })
                .ToList();

            comboBoxSelectCondition.DataSource = conditions;
            comboBoxSelectCondition.DisplayMember = "ConditionName";
            comboBoxSelectCondition.ValueMember = "ConditionId";
        }

        private void dgvListReturns_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListReturns.CurrentRow == null) return;

            int returnId = (int)dgvListReturns.CurrentRow.Cells["ReturnId"].Value;
            var record = _context.ReturnRecords
                .Include(r => r.Rental)
                    .ThenInclude(rt => rt.Request)
                .Include(r => r.Rental)
                    .ThenInclude(rt => rt.User)
                .FirstOrDefault(r => r.ReturnId == returnId);

            if (record != null)
            {
                comboBoxSelectCondition.SelectedValue = _context.ConditionStatuses
                    .FirstOrDefault(c => c.ConditionName == record.ConditionStatus)?.ConditionId ?? -1;
                textBoxReturnNotes.Text = record.Notes;
                // Save returnId in a field for later processing
                _selectedReturnId = returnId;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (_selectedReturnId == -1)
            {
                MessageBox.Show("Please select a return record first.");
                return;
            }

            var record = _context.ReturnRecords
                .Include(r => r.Rental)
                    .ThenInclude(rt => rt.Request)
                        .ThenInclude(req => req.Equipment)
                .Include(r => r.Rental)
                    .ThenInclude(rt => rt.User)
                .FirstOrDefault(r => r.ReturnId == _selectedReturnId);

            if (record == null)
            {
                MessageBox.Show("Return record not found.");
                return;
            }

            if (record.Rental == null)
            {
                MessageBox.Show("Rental info missing for this return record.");
                return;
            }

            if (record.Rental.Request == null)
            {
                MessageBox.Show("Rental request info missing for this return record.");
                return;
            }

            if (record.Rental.Request.Equipment == null)
            {
                MessageBox.Show("Equipment info missing for this return record.");
                return;
            }

            int selectedConditionId = (int)comboBoxSelectCondition.SelectedValue;
            var condition = _context.ConditionStatuses.FirstOrDefault(c => c.ConditionId == selectedConditionId);

            if (condition == null)
            {
                MessageBox.Show("Selected condition is invalid.");
                return;
            }

            // Update return record
            record.ConditionStatus = condition.ConditionName;
            record.Notes = textBoxReturnNotes.Text;
            record.ReturnDate = DateTime.Now;

            // Update equipment condition and availability
            var equipment = record.Rental.Request.Equipment;
            equipment.ConditionId = selectedConditionId;
            equipment.AvailabilityId = 1; // Assuming 1 means Available

            try
            {
                _context.SaveChanges();
                MessageBox.Show("Return processed successfully.");

                // Refresh list & clear selection
                LoadPendingReturns();
                _selectedReturnId = -1;
                comboBoxSelectCondition.SelectedIndex = -1;
                textBoxReturnNotes.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}");
            }
        }

        private void Returns_Load(object sender, EventArgs e)
        {
            labelUserName.Text = Session.CurrentUser.UserName;
        }
    }
}
