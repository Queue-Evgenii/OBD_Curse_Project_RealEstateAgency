using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateAgency.Models.db;

namespace RealEstateAgency
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RealEstateAgencyContext conn = new RealEstateAgencyContext();
            if (conn == null)
            {
                MessageBox.Show("Проблема підключення :(", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AuthorizationForm authForm = new AuthorizationForm(conn);
            Application.Run(authForm);

            if (authForm.isAuthorized)
            {
                conn = new RealEstateAgencyContext();
                App app = new App(authForm.userId, conn);
                Application.Run(app);
            }

            /*App app = new App(1, conn);
            Application.Run(app);*/
        }
    }
}
