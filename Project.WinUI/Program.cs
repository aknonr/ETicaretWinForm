using Project.WinUI.Admin;
using Project.WinUI.Admin.User;
using Project.WinUI.NewFolder1;
using Project.WinUI.RegisterUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Guncelle());
        }
    }
}
