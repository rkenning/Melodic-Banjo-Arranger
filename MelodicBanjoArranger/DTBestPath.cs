using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodicBanjoArranger
{
    public static class BestNodes
    {
        private static Dictionary<long, note_node> DicBestNodes = new Dictionary<long, note_node>();

        public static note_node get_node(long position)
        {
            return DicBestNodes[position];
        }

        public static void add_Node(note_node temp_node)
        {
            //Check if the note exists else not add
            if (DicBestNodes.ContainsKey(temp_node.NoteDetails.position))
            {

                //Find the position in the dictioary and check the paramter note against the current note
                if (DicBestNodes[temp_node.NoteDetails.position].cost > temp_node.cost)
                {
                    DicBestNodes[temp_node.NoteDetails.position] = temp_node;
                }
            }
            else
            {
                DicBestNodes.Add(temp_node.NoteDetails.position, temp_node);
            }
        }

        public static int compare_Cost(note_node temp_node)
        {
            try
            {
                return temp_node.cost - DicBestNodes[temp_node.NoteDetails.position].cost;
            }
            catch
            {
                return 0;
            }
        }


        public static Dictionary<long, note_node> get_all_notes()
        {
            return DicBestNodes;
        }

    }
}
