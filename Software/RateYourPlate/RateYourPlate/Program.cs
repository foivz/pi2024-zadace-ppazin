using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;

namespace RateYourPlate
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DB.SetConfiguration("PI2324_ppazin22_DB", "PI2324_ppazin22_User", "tR$*PV>_");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrijava());
        }
    }
}
