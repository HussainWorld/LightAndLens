using LightAndLensCL.Models;
using Microsoft.EntityFrameworkCore;


namespace LightAndLens_FormApp
{
    public partial class Dashboard : Form
    {
        private readonly LightAndLensDBContext _context;
        public Dashboard()
        {
            InitializeComponent();
            _context = new LightAndLensDBContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();
        }

        private void LoadDashboardStats()
        {
            try
            {
                // Total Equipment
                totalEquipmentNum.Text = _context.Equipment.Sum(e => e.Quantity).ToString();

                // Active Rentals
                activeRentalsNum.Text = _context.RentalTransactions
                    .Count(rt => rt.Status == "Ongoing")
                    .ToString();

                // Pending Requests
                pendingRequestsNum.Text = _context.RentalRequests
                    .Count(r => r.RequestStatusId == 1) // Adjust ID as per your enum
                    .ToString();

                // Overdue Returns
                overdueReturnsNum.Text = _context.RentalTransactions
                    .Count(r => r.EndDate < DateTime.Today && r.Status != "Returned")
                    .ToString();

                // Under Maintenance
                underMaintenanceNum.Text = _context.Equipment
                    .Count(e => e.Condition.ConditionName == "Maintenance")
                    .ToString();

                // Recent Activity (dummy display for now)
                var recent = _context.RentalTransactions
                    .OrderByDescending(r => r.StartDate)
                    .Take(5)
                    .Select(r => new
                    {
                        r.RentalId,
                        r.StartDate,
                        r.EndDate,
                        r.Status
                    }).ToList();

                dataGridViewRecentActivities.DataSource = recent;

                // Inventory Breakdown
                LoadInventoryProgress();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}");
            }
        }

        private void LoadInventoryProgress()
        {
            var totalQty = _context.Equipment.Sum(e => e.Quantity);

            var cam = _context.Equipment
                .Where(e => e.Category.CategoryName == "Camera")
                .Sum(e => e.Quantity);
            var lenses = _context.Equipment
                .Where(e => e.Category.CategoryName == "Lenses")
                .Sum(e => e.Quantity);
            var lights = _context.Equipment
                .Where(e => e.Category.CategoryName == "Lights")
                .Sum(e => e.Quantity);
            var accs = _context.Equipment
                .Where(e => e.Category.CategoryName == "Accessories")
                .Sum(e => e.Quantity);

            cameraProgressBar.Value = totalQty == 0 ? 0 : (int)((cam / (double)totalQty) * 100);
            cameraPercentageLabel.Text = $"{cameraProgressBar.Value}%";

            lensesProgressBar.Value = totalQty == 0 ? 0 : (int)((lenses / (double)totalQty) * 100);
            lensesPercentageLabel.Text = $"{lensesProgressBar.Value}%";

            lightsProgressBar.Value = totalQty == 0 ? 0 : (int)((lights / (double)totalQty) * 100);
            lightsPercentageLabel.Text = $"{lightsProgressBar.Value}%";

            accessoriesProgressBar.Value = totalQty == 0 ? 0 : (int)((accs / (double)totalQty) * 100);
            accessoriesPercentageLabel.Text = $"{accessoriesProgressBar.Value}%";
        }

        private void ClearDashboardStats()
        {
            totalEquipmentNum.Text = "0";
            activeRentalsNum.Text = "0";
            pendingRequestsNum.Text = "0";
            overdueReturnsNum.Text = "0";
            underMaintenanceNum.Text = "0";
            dataGridViewRecentActivities.DataSource = null;
        }




        private void dashboardBtn_Click(object sender, EventArgs e)
        {

        }

        private void EquipmentBtn_Click(object sender, EventArgs e)
        {

        }


        private void settingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void rentalRequestsBtn_Click(object sender, EventArgs e)
        {

        }

        private void returnsBtn_Click(object sender, EventArgs e)
        {

        }

        private void analyticsBtn_Click(object sender, EventArgs e)
        {

        }

        private void recentActivitiesPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
