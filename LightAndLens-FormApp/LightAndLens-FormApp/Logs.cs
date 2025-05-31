using LightAndLensCL.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();

        }

        

        private void Logs_Load(object sender, EventArgs e)
        {
            using (var context = new LightAndLensDBContext())
            {
                var logs = context.Logs
                    .Include(l => l.User)
                    .OrderByDescending(l => l.Timestamp)
                    .Select(l => new LogEntryView
                    {
                        UserName = l.User != null ? l.User.FullName : "Unknown",
                        Action = l.Action,
                        Timestamp = l.Timestamp
                    })
                    .ToList();

                dgvLogs.DataSource = logs;
            }
        }

        
        public class LogEntryView
        {
            public string UserName { get; set; }
            public string Action { get; set; }
            public DateTime Timestamp { get; set; }
        }

















        private void EquipmentUnderMaintenancetxt_Click(object sender, EventArgs e)
        {

        }

    }
}
