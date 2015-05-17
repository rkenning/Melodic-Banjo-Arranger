using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MelodicBanjoArranger
{

    public class note_node
    {
        public int? parent_node_index { get; set; }// Accept null parent note index
        public int cost { get; set; }
        public MatchNote NoteDetails { get; set; }

        public note_node()
        { }

        public note_node(int? parent_node_index_, int cost_, MatchNote NoteDetails_)// Accept null parent note index
        {
            parent_node_index = parent_node_index_;

            cost = cost_;
            NoteDetails = NoteDetails_;
        }

        public override string ToString()
        {
            String Temp_string;
            Temp_string = "Parent Note:" + parent_node_index.ToString();
            Temp_string += " cost:" + cost.ToString();
            Temp_string += " Note:" + NoteDetails.ToString();

            return Temp_string;

        }

    }


    public class DecisionTree
    {
        // Moved to a public static allowing results to be accessed outside of class
        public static List<note_node> DTData = new List<note_node>();


        public int add_node(int? parent_node_index_, int note_from_idx_ref_, int note_to_idx_ref_, MatchNote NoteDetails_) // Accept null parent note index
        {
            note_node temp_note_node = new note_node();
            //Assign the passed attibute values to the temp object
            temp_note_node.parent_node_index = parent_node_index_;
            temp_note_node.cost = 0;
            temp_note_node.NoteDetails = NoteDetails_;

            //Add the object to the list
            DTData.Add(temp_note_node);

            //Kill the temp object
            temp_note_node = null;

            //return the index of the new newly created note node item
            return DTData.Count() - 1;

        }
    }


    public static class DTController
    {

        static DecisionTree NoteTree = new DecisionTree();
        static int matchindex = 0;


        //Accept the list of matched notes to perform analysis and create the DT
        public static List<note_node> Process_Route_Notes(List<MatchNote> matchingresults)
        {
            // get the 

            foreach (MatchNote matchresult in matchingresults)
            {

                // Read the route note and check its not the 2nd note in the file
                // If it is then exit the loop as the processing is finished

                if (matchingresults[0].position != matchingresults[matchindex].position)
                {
                    //If the route note is position is different than last route note (I.e. not the first note position then stop)
                    break;
                }

                int new_node_index;
                //Add the note as a route node to the DT
                new_node_index = NoteTree.add_node(null, 0, matchindex, matchingresults[matchindex]);

                // Note is still the same so process from this point
                Process_Note_Range(matchindex, new_node_index);

                matchindex++; // Track the index of the current matched note in the list of notes

            }
            return DecisionTree.DTData;

        }

        //Accept the parent index as a parameter to allow for recursave calls
        public static void Process_Note_Range(int last_note_index, int last_DT_index)
        {
            int new_node_index;

            /* Start the loop at the current index position and work forwards through the 
                note results untill the next note position is found
             */
            for (int i = last_note_index; i < MatchNotes.matchingresults.Count(); i++) //The last note in the  )
            {

                // Check the position value of the current index is greater than the recieved index note position
                if (MatchNotes.matchingresults[i].position > MatchNotes.matchingresults[last_note_index].position)
                {
                    // Current note note is 'next' in the position then add the current note to the DT
                    new_node_index = NoteTree.add_node(last_DT_index, last_note_index, i, MatchNotes.matchingresults[i]);

                    // Perform recursive call to generate the next tree node
                    Process_Note_Range(i, new_node_index);
                    // Finished processing of the note to break from the loop
                    if (new_node_index > 1000)
                    {
                        break;
                    }
                }

            }

        }


    }
}
