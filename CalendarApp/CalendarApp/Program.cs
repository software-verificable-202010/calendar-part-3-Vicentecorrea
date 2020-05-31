using CalendarApp.Views;
using System;
using System.Windows.Forms;

namespace CalendarApp
{
    static class Program
    {
        #region Methods
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
        #endregion
    }
}
