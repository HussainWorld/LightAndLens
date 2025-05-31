using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using LightAndLens_FormApp.Identity; 

namespace LightAndLens_FormApp
{
    internal static class Program
    {
        // Make the IdentityDbContext available application-wide
        public static IdentityDBContext IdentityDbContextInstance;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configure the DbContext options with your connection string
            var optionsBuilder = new DbContextOptionsBuilder<IdentityDBContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LightAndLensAuth;Trusted_Connection=True;TrustServerCertificate=True;");

            IdentityDbContextInstance = new IdentityDBContext(optionsBuilder.Options);

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}
