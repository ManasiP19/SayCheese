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
            

            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Cheese c = new Cheese();
            //Customer c3 = new Customer();

            Application.Run();


        }
    }
}