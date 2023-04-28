using System.Diagnostics;

namespace FinalProj
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            Customer c1 = new Customer("1");
            Customer c2 = new Customer("2");

            Application.Run();


        }
    }
}