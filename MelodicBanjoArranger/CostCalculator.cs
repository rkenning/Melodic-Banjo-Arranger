using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MelodicBanjoArranger
{
    static class CostCalculator
    {
         public static  List<note_node> Calculate_DT_Costs( List<note_node> DTArray, Main_Form parentForm)
        {
            List<note_node> New_DT = new List<note_node>();
            int index;
            int intlastCount =0;
            Logging.Open_Dlg();
            Logging.Update_Status("Starting Cost calulation");
            Logging.Update_Status("Total DT Count:" + DTArray.Count.ToString());
            //foreach(note_node temp_node in DTArray)
            Parallel.ForEach(DTArray, temp_node =>
           {
               note_node temp_note = new note_node();

               temp_note = temp_node;
               index = DTArray.IndexOf(temp_node);

                // Check if the note is an open string and 
                if (temp_note.NoteDetails.fret == 0)
               {
                   temp_note.cost = -10;
               }




                // Check if it's a route node 
                if (temp_node.parent_node_index == null)
               {
                    // Currently perform no checks
                }
               else
               {
                    // Check the last note is the same string as last note
                    if (temp_node.NoteDetails.banjoString == DTArray[index - 1].NoteDetails.banjoString &&
                   temp_node.NoteDetails.notenumber != DTArray[index - 1].NoteDetails.notenumber
                       && (temp_node.NoteDetails.fret != 0 || temp_node.NoteDetails.fret != 0))
                   {
                       temp_note.cost = 10;
                   }
                    // Check distance between last note and current note
                    if (System.Math.Abs(temp_node.NoteDetails.fret - DTArray[index - 1].NoteDetails.fret) > 4 &&
                       (temp_node.NoteDetails.fret != 0 || temp_node.NoteDetails.fret != 0))
                   {
                       temp_note.cost = 5;
                   }

               }

               New_DT.Add(temp_note);

               if (New_DT.Count > intlastCount + 10000)
               {
                   intlastCount = New_DT.Count;
                   Logging.Update_Status("Current DT" + intlastCount.ToString());
               };

               

           });
            return New_DT;
        }
    }
}
