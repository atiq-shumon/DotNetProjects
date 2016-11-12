using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;

namespace AH.ModuleController
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!isUKDateFormat())
            {
                MessageBox.Show("Your System DateTime is not in UK Date Format('dd/mm/yyyy')" + "\n" + "Required DateTime Format: dd/MM/yyyy" + "\n" + "Please Choose English(United Kingdom) as Format");
                System.Diagnostics.Process.Start("intl.cpl");
                return;

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainModuleController());
        }

        private static Boolean isUKDateFormat()
        {

            CultureInfo ci = CultureInfo.CurrentCulture;
            DateTimeFormatInfo dtfi = ci.DateTimeFormat;

            string[] SystemDateTimePatterns = new string[250];
            int i = 0;
            foreach (string name in dtfi.GetAllDateTimePatterns('d'))
            {
                SystemDateTimePatterns[i] = name;
                i++;
            }

            string[] myDateTimeFormat = { "dd/MM/yyyy", "dd/MM/yyyy" };
            if (myDateTimeFormat[0].Equals(SystemDateTimePatterns[0]) || myDateTimeFormat[1].Equals(SystemDateTimePatterns[0]))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
