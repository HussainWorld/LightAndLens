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
        }

        private void RentalTransactions_Load(object sender, EventArgs e)
        {
            LoadTransactions();
            LoadFilters();

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
    }
}
