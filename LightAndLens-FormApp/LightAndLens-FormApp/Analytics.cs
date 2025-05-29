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
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
            HighlightActiveButton(analyticsBtn);
        }

        private void Analytics_Load(object sender, EventArgs e)
        {

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


        private void Analytics_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
