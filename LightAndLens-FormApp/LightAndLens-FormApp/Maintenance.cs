using LightAndLensCL.Models;
using Microsoft.EntityFrameworkCore;


namespace LightAndLens_FormApp
{

    public partial class Maintenance : Form
    {
        private readonly LightAndLensDBContext _context;
        private Dashboard _dashboardForm;
        public Maintenance(Dashboard dashboard)
        {
            InitializeComponent();
            _context = new LightAndLensDBContext();
            LoadUnderMaintenanceEquipment();
            _dashboardForm = dashboard;
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {

        }

        // This method loads the equipment that is currently under maintenance
        private void LoadUnderMaintenanceEquipment()
        {
            var items = _context.Equipment
                .Where(e => e.AvailabilityId == 3) // Under Maintenance
                .Include(e => e.Category)
                .Select(e => new
                {
                    e.EquipmentId,
                    e.EquipmentName,
                    CategoryName = e.Category.CategoryName,
                    CurrentAvailability = e.Availability.AvailabilityStatusName

                })
                .ToList();

            dgvMaintenance.DataSource = items;

            // Add a dropdown column for new availability
            if (!dgvMaintenance.Columns.Contains("NewAvailability"))
            {
                var comboCol = new DataGridViewComboBoxColumn
                {
                    HeaderText = "Change To",
                    Name = "NewAvailability",
                    DataSource = new[] {
                    new { Text = "Available", Value = 1 },
                    new { Text = "Under Maintenance", Value = 3 }
                },
                    DisplayMember = "Text",
                    ValueMember = "Value"
                };
                dgvMaintenance.Columns.Add(comboCol);
            }
        }



        // This method is called when the "Apply Changes" button is clicked
        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMaintenance.Rows)
            {
                if (row.Cells["NewAvailability"]?.Value is int newStatus)
                {
                    int id = (int)row.Cells["EquipmentId"].Value;
                    var equipment = _context.Equipment.FirstOrDefault(e => e.EquipmentId == id);
                    if (equipment != null)
                        equipment.AvailabilityId = newStatus;
                }
            }

            _context.SaveChanges();
            MessageBox.Show("Changes applied successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUnderMaintenanceEquipment(); // Refresh
            _dashboardForm.RefreshKPI();
        }

        private void recentActivitiesTxt_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
