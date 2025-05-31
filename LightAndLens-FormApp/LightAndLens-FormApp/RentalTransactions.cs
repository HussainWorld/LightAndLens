using Microsoft.EntityFrameworkCore;
using LightAndLensCL.Models;
using System.Windows.Forms;


namespace LightAndLens_FormApp
{
    public partial class RentalTransactions : Form
    {
        private readonly LightAndLensDBContext _context;
        public RentalTransactions()
        {
            InitializeComponent();
            _context = new LightAndLensDBContext();
            HighlightActiveButton(rentalTransactionsBtn);
        }

        private void RentalTransactions_Load(object sender, EventArgs e)
        {
            LoadTransactions();
            LoadFilters();
            labelUserName.Text = Session.CurrentUser.UserName;
        }

        private void LoadTransactions()
        {
            var transactions = (from t in _context.RentalTransactions
                                join r in _context.RentalRequests on t.RequestId equals r.RequestId
                                join u in _context.Users on r.UserId equals u.UserId
                                join e in _context.Equipment on r.EquipmentId equals e.EquipmentId
                                select new
                                {
                                    ID = t.RentalId,
                                    Equipment = e.EquipmentName,
                                    Customer = u.FullName,
                                    Start = t.StartDate,
                                    End = t.EndDate,
                                    Fee = t.RentalFee,
                                    Deposit = t.DepositPaid,
                                    Status = t.EndDate < DateTime.Now ? "Overdue" : "Ongoing"
                                }).ToList();

            rentalTransactionsdgv.DataSource = transactions;

            if (!rentalTransactionsdgv.Columns.Contains("MarkForReturn"))
            {
                var btnColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Mark for Return",
                    Name = "MarkForReturn",
                    Text = "Mark for Return",
                    UseColumnTextForButtonValue = true
                };
                rentalTransactionsdgv.Columns.Add(btnColumn);
            }
        }

        private void LoadFilters()
        {
            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.Add("All");
            cmbStatusFilter.Items.Add("Ongoing");
            cmbStatusFilter.Items.Add("Overdue");
            cmbStatusFilter.SelectedIndex = 0;     // Default to "All"

        }

        private void ApplyFilters()
        {
            string searchText = txtSearchCustOrEq.Text.Trim().ToLower();
            string selectedStatus = cmbStatusFilter.SelectedItem?.ToString();
            DateTime? startDate = dateTimePickerFrom.Value.Date;
            DateTime? endDate = dateTimePickerTo.Value.Date;

            var filtered = (from t in _context.RentalTransactions
                            join r in _context.RentalRequests on t.RequestId equals r.RequestId
                            join u in _context.Users on r.UserId equals u.UserId
                            join e in _context.Equipment on r.EquipmentId equals e.EquipmentId
                            select new
                            {
                                ID = t.RentalId,
                                Equipment = e.EquipmentName,
                                Customer = u.FullName,
                                Start = t.StartDate,
                                End = t.EndDate,
                                Fee = t.RentalFee,
                                Deposit = t.DepositPaid,
                                Status = t.EndDate < DateTime.Now ? "Overdue" : "Ongoing"
                            }).ToList();

            // Search Filter
            if (!string.IsNullOrEmpty(searchText))
            {
                filtered = filtered.Where(x =>
                    x.Equipment.ToLower().Contains(searchText) ||
                    x.Customer.ToLower().Contains(searchText)).ToList();
            }

            // Status Filter
            if (selectedStatus != "All")
            {
                filtered = filtered.Where(x => x.Status == selectedStatus).ToList();
            }

            // Date Filter
            if (startDate.HasValue && endDate.HasValue)
            {
                filtered = filtered.Where(x =>
                    x.Start >= startDate.Value && x.End <= endDate.Value).ToList();
            }

            rentalTransactionsdgv.DataSource = filtered;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchCustOrEq.Text = "";
            cmbStatusFilter.SelectedIndex = 0;
            dateTimePickerFrom.Value = DateTime.Today;
            dateTimePickerTo.Value = DateTime.Today;

            LoadTransactions(); // Reset to full list
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

        private void returnsBtn_Click(object sender, EventArgs e)
        {
            var returnsForm = new Returns();
            returnsForm.Show();
            this.Hide();
        }

        private void analyticsBtn_Click(object sender, EventArgs e)
        {
            var analyticsForm = new Analytics();
            analyticsForm.Show();
            this.Hide();
        }

        private void RentalTransactions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rentalTransactionsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure click is on a valid row and on the "MarkForReturn" button column
            if (e.RowIndex >= 0 && rentalTransactionsdgv.Columns[e.ColumnIndex].Name == "MarkForReturn")
            {
                // Get RentalId from the current row
                int rentalId = Convert.ToInt32(rentalTransactionsdgv.Rows[e.RowIndex].Cells["ID"].Value);

                try
                {
                    
                    var returnRecord = _context.ReturnRecords.FirstOrDefault(r => r.RentalId == rentalId);

                    if (returnRecord != null)
                    {
                        // Update the condition status to "Pending"
                        returnRecord.ConditionStatus = "Pending";

                        // Save changes to the database
                        _context.SaveChanges();

                        // Inform the user
                        MessageBox.Show("Order marked as pending return.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload data to refresh grid
                        LoadTransactions();
                    }
                    else
                    {
                        MessageBox.Show("Return record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
