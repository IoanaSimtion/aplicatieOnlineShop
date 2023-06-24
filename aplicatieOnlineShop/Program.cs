using aplicatieOnlineShop.forms;
using Application.user.service;
using System.Diagnostics;

namespace aplicatieOnlineShop
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
            //Application.Run(new Form1());
            Application.Run(new LoginPage());
            //Application.Run(new MainPage());


            //UserService userService = new UserService();

            //userService.afisare();

            //Debug.WriteLine(userService.saveUsers());

            //userService.save();

        }
    }
}