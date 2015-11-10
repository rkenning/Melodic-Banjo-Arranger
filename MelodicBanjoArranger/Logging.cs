using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MelodicBanjoArranger
{
    static class Logging
    {

        private static Processing_dlg updateDlg = new Processing_dlg();

        public static void Open_Dlg()
        {
            updateDlg.Show();
            updateDlg.BringToFront();

        }

        internal static void Update_Status(string statusText)
        {
            updateDlg.Update_Status(statusText);
        }


        //Check 


    }
}
