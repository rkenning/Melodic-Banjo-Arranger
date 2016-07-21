using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MelodicBanjoArranger
{
    static class Logging
    {

        private static Processing_dlg updateDlg = new Processing_dlg();

        public static void Open_Dlg()
        {
            //Rectangle workingArea = Screen.GetWorkingArea(updateDlg);
            //updateDlg.Location = new Point(workingArea.Right - updateDlg.Size.Width,
 //                                     workingArea.Bottom - updateDlg.Size.Height);

   //         updateDlg.Show();
     //       updateDlg.BringToFront();

        }

        internal static void Update_Status(string statusText)
        {
            Main_Form.Self.Update_Status(statusText);
        }
        internal static void Update_note_position(long position)
        {
            Main_Form.Self.Update_Note_Position(position.ToString());
        }


        //Check 


    }
}
