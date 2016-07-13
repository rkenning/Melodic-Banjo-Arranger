using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaTab.Importer;
using AlphaTab.Model;

namespace MelodicBanjoArranger
{
    static class AlphaTabController
    {
       
        public static String Build_AlphaText(Arrangement in_arrangement)
        {
            String AlphaText;
            AlphaText = @"\tuning G5 D4 G4 B4 D5. ";
            int MapAlphaString; // AlphaTab uses a different string numbering to my system to mapping required

            //Add the arranged notes to the AlphaText string
            foreach (note_node temp_note in in_arrangement.arrange_notes)
            {
                MapAlphaString = Math.Abs(temp_note.NoteDetails.banjoString - 5);
                //Fret + String + Duration
                AlphaText += temp_note.NoteDetails.fret.ToString() + "." + MapAlphaString.ToString() + "." + "16 ";
      

            };


            return AlphaText;
        }



        public static String Example_Text = @"\title Test \tuning G4 D3 G3 B3 D4 . 0.5.2 1.5.4 3.4.4 | 5.3.8 5.3.8 5.3.8 5.3.8 r.2";

  
    }
}
