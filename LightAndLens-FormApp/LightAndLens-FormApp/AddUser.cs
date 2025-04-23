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
using LightAndLensCL.Models;

namespace LightAndLens_FormApp
{

    public partial class AddUser : Form
    {
        private readonly LightAndLensDBContext _context;
        public AddUser()
        {
            InitializeComponent();
            _context = new LightAndLensDBContext();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = _context.Roles.ToList();
            cmbRoles.DataSource = roles;
            cmbRoles.DisplayMember = "RoleName";
            cmbRoles.ValueMember = "RoleID";
            cmbRoles.SelectedIndex = -1;
            //MessageBox.Show("Form loaded");
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                cmbRoles.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtPhone.Text.Trim(), out int phoneNumber))
            {
                MessageBox.Show("Please enter a valid phone number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newUser = new User
            {
                FullName = txtFullName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                PhoneNumber = phoneNumber,
                RoleId = (int)cmbRoles.SelectedValue
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        */
            bool hasError = false;

            // Reset error messages
            lblFullNameError.Text = "";
            lblEmailError.Text = "";
            lblPhoneError.Text = "";
            lblRoleError.Text = "";

            // Full Name: check if it contains at least 2 words
            string fullName = txtFullName.Text.Trim();
            if (string.IsNullOrWhiteSpace(fullName))
            {
                lblFullNameError.Text = "Full name is required.";
                hasError = true;
            }
            else if (fullName.Split(' ').Length < 2)
            {
                lblFullNameError.Text = "Please enter first and last name.";
                hasError = true;
            }

            // Email: check format with simple regex
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                lblEmailError.Text = "Email is required.";
                hasError = true;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblEmailError.Text = "Enter a valid email address.";
                hasError = true;
            }

            // Phone: must be numeric
            string phone = txtPhone.Text.Trim();
            if (string.IsNullOrWhiteSpace(phone))
            {
                lblPhoneError.Text = "Phone number is required.";
                hasError = true;
            }
            else if (!phone.All(char.IsDigit))
            {
                lblPhoneError.Text = "Phone number must contain only digits.";
                hasError = true;
            }

            // Role
            if (cmbRoles.SelectedIndex == -1)
            {
                lblRoleError.Text = "Please select a role.";
                hasError = true;
            }

            if (hasError) return;

            // Save to DB
            var newUser = new User
            {
                FullName = fullName,
                Email = email,
                PhoneNumber = int.Parse(phone),
                RoleId = (int)cmbRoles.SelectedValue
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
