using System;
using System.Windows.Forms;

/// <summary>
/// Lana
/// </summary>

namespace Assignment2
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
            Application.Run(new Assignment1.MenuForm());
        }
    }
}
