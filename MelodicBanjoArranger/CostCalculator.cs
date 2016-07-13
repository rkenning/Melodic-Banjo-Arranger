using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MelodicBanjoArranger
{
    class CostCalculator
    {

        public static int get_note_cost2(note_node temp_node, note_node parent_node_)
        {
            note_node temp_note = new note_node();

            temp_note = temp_node;
            temp_note.cost = 0;

            // Check if the note is an open string and 
            if (temp_note.NoteDetails.fret == 0)
            {
                temp_note.cost = -2;
            }

            // Check if it's a route node 
            if (temp_node.parent_node_index == null)
            {
                // Currently perform no checks
            }
            else
            {
                // Check the last note is the same string as last note
                if (temp_node.NoteDetails.banjoString == parent_node_.NoteDetails.banjoString &&
               temp_node.NoteDetails.notenumber != parent_node_.NoteDetails.notenumber
                   && (temp_node.NoteDetails.fret != 0 || temp_node.NoteDetails.fret != 0))
                {
                    temp_note.cost = 12;
                }
                // Check distance between last note and current note
                if (System.Math.Abs(temp_node.NoteDetails.fret - parent_node_.NoteDetails.fret) > 4 &&
                   (temp_node.NoteDetails.fret != 0 || temp_node.NoteDetails.fret != 0))
                {
                    temp_note.cost = 9;
                }

                try
                {
                    // Check distance between current note and 2 notes ago
                    if (System.Math.Abs(temp_node.NoteDetails.fret - parent_node_.parent_node.NoteDetails.fret) > 4 &&
                       (temp_node.NoteDetails.fret != 0 || temp_node.NoteDetails.fret != 0))
                    {
                        temp_note.cost = 6;
                    }
                }
                catch
                {
                };
                try
                {
                    //// Check distance between current note and 3 notes ago
                    if (System.Math.Abs(temp_node.NoteDetails.fret - parent_node_.parent_node.parent_node.NoteDetails.fret) > 4 &&
                       (temp_node.NoteDetails.fret != 0 || temp_node.NoteDetails.fret != 0))
                    {
                        temp_note.cost = 3;
                    }
                }
                catch
                {
                };


            }
            return temp_note.cost;
        }
        
        private static note_node get_note_cost(note_node temp_node, List<note_node> DTArray)
        {
            note_node temp_note = new note_node();

            temp_note = temp_node;
            int index = DTArray.IndexOf(temp_node);

            // Check if the note is an open string and 
            if (temp_note.NoteDetails.fret == 0)
            {
                temp_note.cost = -2;
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
                    temp_note.cost = 12;
                }
                // Check distance between last note and current note
                if (System.Math.Abs(temp_node.NoteDetails.fret - DTArray[index - 1].NoteDetails.fret) > 4 &&
                   (temp_node.NoteDetails.fret != 0 || temp_node.NoteDetails.fret != 0))
                {
                    temp_note.cost = 9;
                }

                try
                {
                    // Check distance between current note and 2 notes ago
                    if (System.Math.Abs(temp_node.NoteDetails.fret - DTArray[index - 2].NoteDetails.fret) > 4 &&
                       (temp_node.NoteDetails.fret != 0 || temp_node.NoteDetails.fret != 0))
                    {
                        temp_note.cost = 6;
                    }
                }
                catch
                {
                };
                try
                {
                    //// Check distance between current note and 3 notes ago
                    if (System.Math.Abs(temp_node.NoteDetails.fret - DTArray[index - 3].NoteDetails.fret) > 4 &&
                       (temp_node.NoteDetails.fret != 0 || temp_node.NoteDetails.fret != 0))
                    {
                        temp_note.cost = 3;
                    }
                }
                catch
                {
                };


            }
            return temp_note;
        }

        public static async Task<List<note_node>> Calculate_DT_Costs(List<note_node> DTArray, Main_Form parentForm)
        {
            try
            {
                List<note_node> New_DT = new List<note_node>();
                int intlastCount = 0;
                //Logging.Open_Dlg();
                Logging.Update_Status("Starting Cost calulation");
                Logging.Update_Status("Total DT Count:" + DTArray.Count.ToString());
                foreach (note_node temp_node in DTArray)
                {
                   // Logging.Update_Status("Current Note" + temp_node.ToString());
                    note_node temp_note;
                    var result = Task.Run(() => get_note_cost(temp_node, DTArray));
                    temp_note = result.Result;
                    New_DT.Add(temp_note);

                    if (New_DT.Count > intlastCount + 10000)
                    {
                        intlastCount = New_DT.Count;
                        Logging.Update_Status("Current DT" + intlastCount.ToString());
                    };



                };
                return New_DT;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
    } }
}
