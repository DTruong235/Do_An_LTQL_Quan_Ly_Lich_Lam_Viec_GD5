using Quan_Ly_Lich_Lam_Viec.Forms;

namespace Quan_Ly_Lich_Lam_Viec
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
            Application.Run(new frmDiaDiem());
        }
    }
}