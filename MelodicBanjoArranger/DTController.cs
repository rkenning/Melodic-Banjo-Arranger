using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodicBanjoArranger
{
    public static class DTController
    {

         //Accept the list of matched notes to perform analysis and create the DT
        public static List<note_node> Process_Route_Notes(List<MatchNote> matchingresults)
        {
            // get the 
            int matchindex = 0;
            note_node new_node;



            foreach (MatchNote matchresult in matchingresults)
            {

                // Read the route note and check its not the 2nd note in the file
                // If it is then exit the loop as the processing is finished

                if (matchingresults[0].position != matchingresults[matchindex].position)
                {
                    //If the route note is position is different than last route note (I.e. not the first note position then stop)
                    break;
                }


                //Add the note as a route node to the DT
                new_node = DecisionTree.add_node(null, 0, matchindex, matchingresults[matchindex], null);

                // Note is still the same so process from this point
                Process_Note_Range(matchindex, new_node.tree_index, new_node, matchingresults[matchindex]);

                matchindex++; // Track the index of the current matched note in the list of notes

            }
            return DecisionTree.get_all_nodes();

        }

        //Accept the parent index as a parameter to allow for recursave calls
        public static void Process_Note_Range(int last_note_index, int? last_DT_index, note_node parent_node_, MatchNote currentMatchNote)
        {

            note_node new_node;

            /* Start the loop at the current index position and work forwards through the 
                note results untill the next note position is found
             */


            foreach (MatchNote tempMatchNote in MatchNotes.getNextMatchNotes(currentMatchNote))
            {

                int i = 0;
                // Current note note is 'next' in the position then add the current note to the DT
                
                //Check the next note is > 5 frets from the last note on the same string
                
                new_node = DecisionTree.add_node(last_DT_index, last_note_index, i, tempMatchNote, parent_node_);

                if (new_node.NoteDetails.position < MatchNotes.last_note_position)
                {
                    // If not the last note position then perform recursive call to generate the next tree node
                    Process_Note_Range(i, new_node.tree_index, new_node, tempMatchNote);
                    // Finished processing of the note to break from the loop
                }


            }

        }


    }
}
