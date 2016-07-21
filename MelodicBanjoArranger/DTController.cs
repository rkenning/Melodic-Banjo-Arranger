using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MelodicBanjoArranger
{
    public static class DTController
    {

        //Accept the list of matched notes to perform analysis and create the DT
        public  static List<note_node> Process_Route_Notes(List<MatchNote> matchingresults, int cost_limit, CancellationToken cts)
        {
            // get the 
            int matchindex = 0;

            //  try
            //  {

           
            foreach (MatchNote matchresult in matchingresults)
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
                    Process_Note_Range(matchindex, new_node.tree_index, new_node, matchingresults[matchindex], cost_limit, cts);
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
        public static void Process_Note_Range(int last_note_index, int? last_DT_index, note_node parent_node_, MatchNote currentMatchNote, int cost_limit, CancellationToken cts)
        {

            Logging.Update_note_position(parent_node_.NoteDetails.position);
            //Logging.Update_Status("Processing Notes for parent:" + parent_node_.ToString());


            /* Start the loop at the current index position and work forwards through the 
                note results untill the next note position is found
             */

            //try
            //{
            if (parent_node_.NoteDetails.last_note == true)
            {
                //Logging.Update_Status("End note found!");
                return;
            }
            List<MatchNote> MatchLoop = MatchNotes.getNextMatchNotes(currentMatchNote);
            if (MatchLoop == null)
            {
                //No more notes left
                return;
            }

            foreach (MatchNote tempMatchNote in MatchLoop)
            {

                int i = 0;
                // Current note note is 'next' in the position then add the current note to the DT

                //TODO Extract Add note from Decision tree to allow cost evaluation before tree has
                // an added value
                note_node new_node = new note_node(last_DT_index, last_note_index, i, tempMatchNote, parent_node_);
                new_node.cost = CostCalculator.get_note_cost2(new_node, parent_node_);

                 
                i = BestNodes.compare_Cost(new_node);
                BestNodes.add_Node(new_node);// Need to add the note node to the best nodes incase the position is currently empty
                
                //Check the cost comparison is less than or = to the current best node 
                //if yes then add to the DT & cotinue to process the notes children
                if (i <= cost_limit)
                {
                    
                    DecisionTree.add_node(new_node);

                    //If not the last note in 
                    if (tempMatchNote.last_note == false)
                    {
                        
                        if (cts.IsCancellationRequested)
                        {
                            return;
                        }

                        // If not the last note position then perform recursive call to generate the next tree node
                        //await Task.Run(() => Process_Note_Range(i, new_node.tree_index, new_node, tempMatchNote, cost_limit, cts), cts);
                        Process_Note_Range(i, new_node.tree_index, new_node, tempMatchNote, cost_limit, cts);
                        // Finished processing of the note to break from the loop
                    }
                }

            }

            //            }
            //          catch (Exception Ex)
            //        {
            //          throw new System.ArgumentException("Some notes cannot be match with this tranposition, Error : " +Ex.ToString());
            //    }

        }
    }
}
