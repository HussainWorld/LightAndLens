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
            activeButton.BackColor = Color.FromArgb(41, 128, 185); // Example: a nice highlight blue
        }


        private void Analytics_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
