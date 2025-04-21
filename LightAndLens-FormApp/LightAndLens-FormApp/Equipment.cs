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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }

        private void Equipment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
