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
        public Returns()
        {
            InitializeComponent();
            HighlightActiveButton(returnsBtn);
        }

        private void Returns_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HighlightActiveButton(Button activeButton)
        {
            // Reset all to default color
            dashboardBtn.BackColor = Color.FromArgb(32, 46, 82);
            EquipmentBtn.BackColor = Color.FromArgb(32, 46, 82);
            rentalRequestsBtn.BackColor = Color.FromArgb(32, 46, 82);
            returnsBtn.BackColor = Color.FromArgb(32, 46, 82);
            analyticsBtn.BackColor = Color.FromArgb(32, 46, 82);
            rentalTransactionsBtn.BackColor = Color.FromArgb(32, 46, 82);
            // Set active color
            activeButton.BackColor = Color.FromArgb(17, 80, 203);
        }





    }
}
