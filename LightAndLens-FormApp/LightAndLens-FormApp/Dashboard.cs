using LightAndLensCL.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using System.Drawing;

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
            LoadRentalRequestsView();
            HighlightActiveButton(dashboardBtn);
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
                    .Count(e => e.Availability.AvailabilityStatusName == "Under Maintenance")
                    .ToString();


                // Inventory Breakdown
                LoadInventoryProgress();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}");
            }
        }



        public void RefreshKPI()
        {
            // Example logic
            int maintenanceCount = _context.Equipment.Count(e => e.AvailabilityId == 3);
            underMaintenanceNum.Text = maintenanceCount.ToString();
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


            // -- Stabilizers --
            var totalStab = _context.Equipment
                .Where(e => e.Category.CategoryName == "Stabilizers")
                .Sum(e => e.Quantity);

            var availableStab = _context.Equipment
                .Where(e => e.Category.CategoryName == "Stabilizers" && e.Availability.AvailabilityStatusName == "Available")
                .Sum(e => e.Quantity);

            stabilizersProgressBar.Value = totalStab == 0 ? 0 : (int)((availableStab / (double)totalStab) * 100);
            stabilizersPercentageLabel.Text = $"{stabilizersProgressBar.Value}%";

        }


        private void tabRecentActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabRecentActivities.SelectedTab == tabRequests)
                LoadRentalRequestsView();
            else if (tabRecentActivities.SelectedTab == tabRentals)
                LoadActiveRentalsView();
            else if (tabRecentActivities.SelectedTab == tabReturns)
                LoadReturnsView();
        }
        private void LoadRentalRequestsView()
        {
            var requests = (from r in _context.RentalRequests
                            join u in _context.Users on r.UserId equals u.UserId
                            join e in _context.Equipment on r.EquipmentId equals e.EquipmentId
                            join s in _context.RequestStatuses on r.RequestStatusId equals s.RequestStatusId
                            select new
                            {
                                ID = r.RequestId,
                                EquipmentName = e.EquipmentName,
                                RentedBy = u.FullName,
                                StartDate = r.RequestStartDate,
                                EndDate = r.RequestEndDate,
                                Status = s.StatusName
                            }).ToList();

            dataGridViewRequests.DataSource = requests;
        }

        private void LoadActiveRentalsView()
        {
            var rentals = (from t in _context.RentalTransactions
                           join r in _context.RentalRequests on t.RequestId equals r.RequestId
                           join u in _context.Users on r.UserId equals u.UserId
                           join e in _context.Equipment on r.EquipmentId equals e.EquipmentId
                           where t.Status != "Returned"
                           select new
                           {
                               ID = t.RentalId,
                               EquipmentName = e.EquipmentName,
                               RentedBy = u.FullName,
                               StartDate = t.StartDate,
                               EndDate = t.EndDate,
                               Status = t.Status
                           }).ToList();

            dataGridViewRentals.DataSource = rentals;
        }

        private void LoadReturnsView()
        {
            var returns = (from ret in _context.ReturnRecords
                           join t in _context.RentalTransactions on ret.RentalId equals t.RentalId
                           join r in _context.RentalRequests on t.RequestId equals r.RequestId
                           join u in _context.Users on r.UserId equals u.UserId
                           join e in _context.Equipment on r.EquipmentId equals e.EquipmentId
                           select new
                           {
                               ID = ret.ReturnId,
                               EquipmentName = e.EquipmentName,
                               RentedBy = u.FullName,
                               ReturnDate = ret.ReturnDate,
                               Condition = ret.ConditionStatus,
                               Notes = ret.Notes
                           }).ToList();

            dataGridViewReturns.DataSource = returns;
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

        private void recentActivitiesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var RentalTransactionsForm = new RentalTransactions();
            RentalTransactionsForm.Show();
            this.Hide();
        }

        private void maintenanceBtn_Click(object sender, EventArgs e)
        {
            var maintenanceForm = new Maintenance(this);
            maintenanceForm.ShowDialog();
        }

        private void LogsBtn_Click(object sender, EventArgs e)
        {
            var logsForm = new Logs();
            logsForm.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
