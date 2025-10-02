using kiosko_ssms.Data;
using kiosko_ssms.Forms;
using SQLitePCL;
using System;
using System.Windows.Forms;

namespace kiosko_ssms
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Batteries_V2.Init();
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
