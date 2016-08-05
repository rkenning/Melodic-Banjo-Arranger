using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MelodicBanjoArranger
{
    public static class DTController2

    {

       static int currentEndCount_;



        public  static List<note_node> Process_Route_Notes(List<MatchNote> matchingresults, int cost_limit, int max_end_notes, CancellationToken cts)
        {

            BestNodes.Clear();

            //First sort the list by fret & include only the root notes list into 
            List<MatchNote> Root_Notes = matchingresults
                .Where(f => f.position == MatchNotes.get_first_note_position())
                .OrderBy(f => f.fret)
                .ToList();

            // get the 
            int matchindex = 0;

            //Loop thought root notes
            foreach (MatchNote matchresult in Root_Notes)
            {

                Logging.Update_Status("Starting matching process for :" + matchresult.ToString());
                // Read the route note and check its not the 2nd note in the file
                // If it is then exit the loop as the processing is finished

                if (matchingresults[0].position != matchingresults[matchindex].position)
                {
                    //If the route note is position is different than last route note (I.e. not the first note position then stop)
                    break;
                }

                //Add the note as a route node to the DT

                note_node new_node = new note_node(0, 0, matchresult, null);
                BestNodes.add_Node(new_node); // Need to add the note node to the best nodes incase the position is currently empty


                DecisionTree.add_node(new_node);
                //Run the note through the BestNodes process



                // Note is still the same so process from this point

                if (new_node.NoteDetails.last_note == false)
                {
                    //If the note is not the last note then continue to process i's children
                    //await Task.Run(() => 
                    currentEndCount_ = 0;
                    Process_Note_Range(matchindex, new_node.tree_index, new_node, matchingresults[matchindex], 
                        cost_limit, max_end_notes, cts);
                }

                matchindex++; // Track the index of the current matched note in the list of notes




            }
            return DecisionTree.get_all_nodes();


            //    }
            // catch (Exception ex)
            // {
            //     throw new System.ArgumentException("Error processing route notes"+ex.ToString());
            //  }
        }

        //Accept the parent index as a parameter to allow for recursave calls
        public static void Process_Note_Range(int last_note_index, int? last_DT_index, 
            note_node parent_node_, MatchNote currentMatchNote, 
            int cost_limit, int max_end_notes, CancellationToken cts)
        {

            Logging.Update_note_position(parent_node_.NoteDetails.position);
            //Logging.Update_Status("Processing Notes for parent:" + parent_node_.ToString());


            /* Start the loop at the current index position and work forwards through the 
                note results untill the next note position is found
             */

            //try
            //{


            //Get ordered list

            List<MatchNote> MatchLoop = MatchNotes.getNextMatchNotes(currentMatchNote);
            if (MatchLoop == null)
            {
                //No more notes left so finish
                return;
            }

            //First pass of maatching note, calculate cost and add to the BestNodes
            foreach (MatchNote tempMatchNote in MatchLoop)
            {

                int i = 0;
                // Current note note is 'next' in the position then add the current note to the DT

                note_node new_node = new note_node(last_DT_index, last_note_index, i, tempMatchNote, parent_node_);
                new_node.cost = CostCalculator.get_note_cost2(new_node, parent_node_);


                BestNodes.add_Node(new_node);// Need to add the note node to the best nodes incase the position is currently empty
                int costcomp = BestNodes.compare_Cost(new_node);
                if (i <= cost_limit)
                {
                    DecisionTree.add_node(new_node);

                }
            }


            //Get a list of the new DT Nodes order by lowest cost first
            List<note_node> Note_Nodes_list = DecisionTree.get_Children(parent_node_)
                .OrderBy(p => p.cost)
                .ToList();

            // Next loop though the newly created DT Nodes with the parent
            foreach (note_node temp_node in Note_Nodes_list)
            {
                int i;
                //Check the cost comparison is less than or = to the current best node 
                //if yes then add to the DT & cotinue to process the notes children
                i = BestNodes.compare_Cost(temp_node);
                if (i <= cost_limit)
                {

                    //If not the last note in 
                    if (temp_node.NoteDetails.last_note == false)
                    {

                        if (cts.IsCancellationRequested || currentEndCount_ == max_end_notes)
                        {
                            return;
                        }

                        // DANGER !!!! This is a stab in the dark approach to sort the bigger problem regards 
                        // total processing time
                        if (temp_node.NoteDetails.position == MatchNotes.get_last_note_position())
                        {
                            currentEndCount_ += 1;
                            Logging.Update_Status("End note found :" + currentEndCount_.ToString());
                            return;

                        }

                        Process_Note_Range(i, temp_node.tree_index, temp_node, temp_node.NoteDetails,
                            cost_limit, max_end_notes, cts);

                    }
                }

                else
                    temp_node.Excluded = true;

            }
            
        }
    }
}
