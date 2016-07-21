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

        public note_node(int? parent_node_index_,int last_note_index, int cost_, MatchNote NoteDetails_, note_node parent_node_)// Accept null parent note index
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
            StringBuilder Temp_string = new StringBuilder();
            Temp_string.Append(NoteDetails.ToStringSmall());
            Temp_string.Append("Cost:" + cost.ToString());

            return Temp_string.ToString();

        }


    }






    public static class DecisionTree
    {
        private static List<note_node> DTData = new List<note_node>();

        public static void add_node(note_node temp_note_node) // Accept null parent note index
        {
            if (temp_note_node.parent_node != null)
            {
                DTData.Add(temp_note_node);
            }
            else
            {
                DTData.Add(temp_note_node);
            }

            //return the index of the new newly created note node item
            temp_note_node.tree_index = DTData.Count() - 1;
           

            //Cound mod 1000
            if (DTData.Count % 1000 == 0 )
            {
                Logging.Update_Status("DT Size at:" + DTData.Count.ToString());
            }

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
