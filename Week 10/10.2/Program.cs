using Microsoft.EntityFrameworkCore;
using Mod7CodeFirstdemo.Data;

namespace Mod7CodeFirstdemo
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
            Records.employeeContext = new EmployeeContext();
            //initialize that database for the first time
            //which means the static variable that we had created in that records that is getting instantiated in the main method

            Records.employeeContext.Database.EnsureCreated();
            //use that on configuring and on model creating both of those methods to configure and create the mod

            Records.employeeContext.Departments.Load();
            Records.employeeContext.Employees.Load();


            Application.Run(new Form1());
        }
    }
}