using System;
using System.Windows.Forms;
using Worldyachts.View.Accounts.SignIn;

namespace Worldyachts
{
    static class StartCRM
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInForm());
        }
    }
}
