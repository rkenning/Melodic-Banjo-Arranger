using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MelodicBanjoArranger
{

    public class note_node
    {
        public int parent_node_index { get; set; }
        public int note_from_idx_ref { get; set; }
        public int note_to_idx_ref { get; set; }
        public int cost { get; set; }

        public note_node()
        { }

        public note_node(int parent_node_index_, int note_from_idx_ref_, int note_to_idx_ref_, int cost_)
        {
            parent_node_index = parent_node_index_;
            note_from_idx_ref = note_from_idx_ref_;
            note_to_idx_ref = note_to_idx_ref_;
            cost = cost_;
        }
    }


    public class DecisionTree
    {
        // Moved to a public static allowing results to be accessed outside of class
        public static List<note_node> DTData = new List<note_node>();


        public void add_node(int parent_node_index_, int note_from_idx_ref_, int note_to_idx_ref_)
        {
            note_node temp_note_node = new note_node();
            //Assign the passed attibute values to the temp object
            temp_note_node.parent_node_index = parent_node_index_;
            temp_note_node.note_to_idx_ref = note_to_idx_ref_;
            temp_note_node.note_from_idx_ref = note_from_idx_ref_;
            temp_note_node.cost = 0;

            //Add the object to the list
            DTData.Add(temp_note_node);

            //Kill the object
            temp_note_node = null;

        }
    }


    public static class DTController
    {

        static DecisionTree NoteTree = new DecisionTree();
        static int matchindex = 0;


        //Accept the list of matched notes to perform analysis and create the DT
        public static void Process_Route_Notes(List<MatchNote> matchingresults)
        {
            foreach (MatchNote matchresult in matchingresults)
            {
                // Read the route note and check its not the 2nd note in the file
                // If it is then exit the loop as the processing is finished

                if (matchresult.position != matchingresults[matchindex].position)
                {
                    //If the route note is position is different than last route note (I.e. not the first note position then stop)
                    break;
                }

                //Add the note as a route node to the DT
                NoteTree.add_node(0, 0, matchindex);

                // Note is still the same so process from this point
                Process_Note_Range(matchindex);


                matchindex++; // Track the index of the current matched note in the list of notes

            }

        }

        //Accept the parent index as a parameter to allow for recursave calls
        public static void Process_Note_Range(int parent_index)
        {
            /* Start the loop at the current index position and work forwards through the 
                note results untill the next note position is found
             */
            for (int i = parent_index; i < MatchNotes.matchingresults.Count(); i++) //The last note in the  )
            {

                // Check the position value of the current index is greater than the recieved index note position
                if (MatchNotes.matchingresults[i].position > MatchNotes.matchingresults[parent_index].position)
                {
                    // Current note note is 'next' in the position then add the current note to the DT
                    NoteTree.add_node(parent_index, parent_index, i);
                    // Perform recursive call to generate the next tree node
                    Process_Note_Range(i);
                }

            }

        }


    }
}
