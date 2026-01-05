using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS2
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

            // Show the Login Form first
            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();

            Application.Run(new LoginForm());

            //Application.Run(new Dashboard());
        }
    }
}
