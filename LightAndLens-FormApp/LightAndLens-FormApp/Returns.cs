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
        }

        private void Returns_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
