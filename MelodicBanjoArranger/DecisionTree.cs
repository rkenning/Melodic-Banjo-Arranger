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


            if (parent_node_ != null)
            {
                //Check new note added to the DT isn't on same string and massive jump in frets
                if (temp_note_node.NoteDetails.banjoString == parent_node_.NoteDetails.banjoString &&
                        System.Math.Abs(temp_note_node.NoteDetails.fret - parent_node_.NoteDetails.fret) < 5)
                //Add the object to the list
                {

                    /*
                    TODO - Move the calculation of the cost to this section to speed up the processing of total costs
                    this will require the following :
                    - Evaluation of the cost between the current note and parent note
                    - Evaluation of the parent's parent
                    - Evaluation of the parent's parent 
                    - etc.....

    */




                    DTData.Add(temp_note_node);
                }
            }
            else
            {
                DTData.Add(temp_note_node);
            }

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



}
