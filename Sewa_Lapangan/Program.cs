using Sewa_Lapangan.Views;
using Sewa_Lapangan.Views.Admin;
using Sewa_Lapangan.Views.User;

namespace Sewa_Lapangan
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}