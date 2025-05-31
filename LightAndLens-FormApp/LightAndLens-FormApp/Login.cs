using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LightAndLens_FormApp.Identity;



namespace LightAndLens_FormApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public async Task<ApplicationUser> TryLoginAsync(string email, string password)
        {
            var optionsBuilder = new DbContextOptionsBuilder<IdentityDbContext<ApplicationUser>>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LightAndLensAuth;Trusted_Connection=True;TrustServerCertificate=True;");

            using var context = new IdentityDbContext<ApplicationUser>(optionsBuilder.Options);
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(
                userStore, null, new PasswordHasher<ApplicationUser>(),
                null, null, null, null, null, null);

            var user = await userManager.FindByEmailAsync(email);
            if (user == null) return null;

            var passwordValid = await userManager.CheckPasswordAsync(user, password);
            if (!passwordValid) return null;


            return user;

        }
        private void logotxt_Click(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Don't proceed with login
            }

            btnLogin.Enabled = false;
            try
            {
                var user = await TryLoginAsync(email, password);
                if (user != null)
                {
                    // Create UserManager to check roles
                    var optionsBuilder = new DbContextOptionsBuilder<IdentityDbContext<ApplicationUser>>();
                    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LightAndLensAuth;Trusted_Connection=True;TrustServerCertificate=True;");

                    using var context = new IdentityDbContext<ApplicationUser>(optionsBuilder.Options);
                    var userStore = new UserStore<ApplicationUser>(context);
                    var userManager = new UserManager<ApplicationUser>(
                        userStore, null, new PasswordHasher<ApplicationUser>(),
                        null, null, null, null, null, null);

                    var roles = await userManager.GetRolesAsync(user);
                    if (roles.Contains("Customer"))
                    {
                        MessageBox.Show("Sorry, customers not allowed here.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Don't proceed with login
                    }

                    Session.CurrentUser = user;  // Set logged-in user in session

                    //MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    var dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }



        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = "StaffV@StaffV.com";
            textBoxPassword.Text = "Asd123";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = "AdminV@AdminV.com";
            textBoxPassword.Text = "Asd123";
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
