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
            HighlightActiveButton(dashboardBtn);
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
                /*var recent = _context.RentalTransactions
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
                */

                

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


            // -- CAMERA --
            var totalCams = _context.Equipment
                .Where(e => e.Category.CategoryName == "Cameras")
                .Sum(e => e.Quantity);

            var availableCams = _context.Equipment
                .Where(e => e.Category.CategoryName == "Cameras" && e.Availability.AvailabilityStatusName == "Available")
                .Sum(e => e.Quantity);

            cameraProgressBar.Value = totalCams == 0 ? 0 : (int)((availableCams / (double)totalCams) * 100);
            cameraPercentageLabel.Text = $"{cameraProgressBar.Value}%";

            // -- LENSES --
            var totalLenses = _context.Equipment
                .Where(e => e.Category.CategoryName == "Lenses")
                .Sum(e => e.Quantity);

            var availableLenses = _context.Equipment
                .Where(e => e.Category.CategoryName == "Lenses" && e.Availability.AvailabilityStatusName == "Available")
                .Sum(e => e.Quantity);

            lensesProgressBar.Value = totalLenses == 0 ? 0 : (int)((availableLenses / (double)totalLenses) * 100);
            lensesPercentageLabel.Text = $"{lensesProgressBar.Value}%";

            // -- LIGHTS --
            var totalLights = _context.Equipment
                .Where(e => e.Category.CategoryName == "Lights")
                .Sum(e => e.Quantity);

            var availableLights = _context.Equipment
                .Where(e => e.Category.CategoryName == "Lights" && e.Availability.AvailabilityStatusName == "Available")
                .Sum(e => e.Quantity);

            lightsProgressBar.Value = totalLights == 0 ? 0 : (int)((availableLights / (double)totalLights) * 100);
            lightsPercentageLabel.Text = $"{lightsProgressBar.Value}%";

            // -- ACCESSORIES --
            var totalAccs = _context.Equipment
                .Where(e => e.Category.CategoryName == "Accessories")
                .Sum(e => e.Quantity);

            var availableAccs = _context.Equipment
                .Where(e => e.Category.CategoryName == "Accessories" && e.Availability.AvailabilityStatusName == "Available")
                .Sum(e => e.Quantity);

            accessoriesProgressBar.Value = totalAccs == 0 ? 0 : (int)((availableAccs / (double)totalAccs) * 100);
            accessoriesPercentageLabel.Text = $"{accessoriesProgressBar.Value}%";

        }

        private void ClearDashboardStats()
        {
            totalEquipmentNum.Text = "0";
            activeRentalsNum.Text = "0";
            pendingRequestsNum.Text = "0";
            overdueReturnsNum.Text = "0";
            underMaintenanceNum.Text = "0";
            //dataGridViewRecentActivities.DataSource = null;
        }

        private void HighlightActiveButton(Button activeButton)
        {
            // Reset all to default color
            dashboardBtn.BackColor = Color.FromArgb(26, 32, 40);
            EquipmentBtn.BackColor = Color.FromArgb(26, 32, 40);
            rentalRequestsBtn.BackColor = Color.FromArgb(26, 32, 40);
            returnsBtn.BackColor = Color.FromArgb(26, 32, 40);
            analyticsBtn.BackColor = Color.FromArgb(26, 32, 40);

            // Set active color
            activeButton.BackColor = Color.FromArgb(41, 128, 185);
        }



        private void dashboardBtn_Click(object sender, EventArgs e)
        {

        }

        private void EquipmentBtn_Click(object sender, EventArgs e)
        {
            var equipmentForm = new Equipment();
            equipmentForm.Show();
            this.Hide();
        }


        private void settingsBtn_Click(object sender, EventArgs e)
        {

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
            var analyticsForm = new Analytics(); // Replace with your actual Analytics form
            analyticsForm.Show();
            this.Hide();
        }

        private void recentActivitiesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
