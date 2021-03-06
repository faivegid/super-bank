using BankMS.DataAccess;
using BankMS.Model;
using System;
using System.Windows.Forms;

namespace BankMS.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IReader reader = new SQLReader();
            IWriter writer = new SQLWriter();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPage(reader, writer));
        }
    }
}
