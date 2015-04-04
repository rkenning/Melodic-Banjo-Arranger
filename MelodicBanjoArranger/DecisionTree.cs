﻿using System;
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
        public static List<note_node> matchingresults = new List<note_node>();
        note_node temp_note_node = new note_node();

        public void add_node(int parent_node_index_, int note_from_idx_ref_, int note_to_idx_ref)
        {
            //Assign the passed attibute values to the temp object
            temp_note_node.parent_node_index = parent_node_index_;
            temp_note_node.note_to_idx_ref = parent_node_index_;
            temp_note_node.note_from_idx_ref = note_from_idx_ref_;
            temp_note_node.cost = 0;

            //Add the object to the list
            matchingresults.Add(temp_note_node);
        }
    }


    public class DTController
    {

        DecisionTree NoteTree;
        int matchindex = 0;

        public DTController()
        {
            //Create the blank decision tree
            NoteTree = new DecisionTree();
        }


        //Accept the list of matched notes to perform analysis and create the DT
        public void Process_Route_Notes(List<MatchNote> matchingresults)
        {
            foreach (MatchNote matchresult in matchingresults)
            {
                // Read the route note and check its not the 2nd note in the file
                // If it is then exit the loop as the processing is finished

                if (matchresult.position != matchingresults[matchindex].position)
                {
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
        public void Process_Note_Range(int parent_index)
        {
            
            

            
            // Add this note to the DT
            NoteTree.add_node(parent_index,parent_index,)
            
            
            //First find the next note after specified parent
            // (Check the timeframe value not note as the same note may be played x2)




        }





    }



    // TODO: Point to index of list returned from the function Find_Matching_Notes
    // TODO: Base cost of from and to note postions

    // TODO: (May need to move things around and create a static list for Find_Matching_Notes)


}
