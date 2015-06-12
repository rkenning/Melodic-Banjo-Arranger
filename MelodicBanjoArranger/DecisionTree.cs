using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MelodicBanjoArranger
{

    public class note_node
    {
        public int? parent_node_index { get; set; }// Accept null parent note index
        public note_node parent_node { get; set; }
        public int cost { get; set; }
        public MatchNote NoteDetails { get; set; }
        public int? tree_index { get; set; }

        public note_node()
        { }

        public note_node(int? parent_node_index_, int cost_, MatchNote NoteDetails_, note_node parent_node_)// Accept null parent note index
        {
            parent_node_index = parent_node_index_;
            parent_node = parent_node_;
            cost = cost_;
            NoteDetails = NoteDetails_;
        }

        public override string ToString()
        {
            String Temp_string;
            Temp_string = "Parent Note:" + parent_node_index.ToString();
            Temp_string += " cost:" + cost.ToString();
            Temp_string += " Note:" + NoteDetails.ToString();
            if (parent_node != null)
                Temp_string += "  -- P:" + parent_node.NoteDetails.ToString();

            return Temp_string;

        }

        public string ToStringSmall()
        {
            String Temp_string;
            Temp_string = "Cost:" + cost.ToString();
            Temp_string += ":" + NoteDetails.ToStringSmall();
           

            return Temp_string;

        }


    }






    public static class DecisionTree
    {
        // Moved to a public static allowing results to be accessed outside of class
        private static List<note_node> DTData = new List<note_node>();


        public static note_node add_node(int? parent_node_index_, int note_from_idx_ref_, int note_to_idx_ref_, MatchNote NoteDetails_, note_node parent_node_) // Accept null parent note index
        {
            note_node temp_note_node = new note_node();
            //Assign the passed attibute values to the temp object
            temp_note_node.parent_node_index = parent_node_index_;
            temp_note_node.parent_node = parent_node_;
            temp_note_node.cost = 0;
            temp_note_node.NoteDetails = NoteDetails_;

            //Add the object to the list
            DTData.Add(temp_note_node);



            //return the index of the new newly created note node item
            temp_note_node.tree_index = DTData.Count() - 1;
            return temp_note_node;



        }

        public static List<note_node> get_Children(note_node parent_node_)
        {
            List<note_node> childrenNodes = new List<note_node>();

            childrenNodes = DTData.FindAll(obj => obj.parent_node == parent_node_);

            //Return the identified children
            return childrenNodes;
        }

        public static List<note_node> get_top_nodes()
        {
            List<note_node> tempNodes = new List<note_node>();

            tempNodes = DTData.FindAll(obj => obj.parent_node == null);
            //Return the identified children
            return tempNodes;

        }

        public static List<note_node> get_all_nodes()
        {
            List<note_node> tempNodes = new List<note_node>();

            tempNodes = DTData;
            //Return the identified children
            return tempNodes;

        }


    }


    public static class DTController
    {

        //static DecisionTree NoteTree = new DecisionTree();



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
