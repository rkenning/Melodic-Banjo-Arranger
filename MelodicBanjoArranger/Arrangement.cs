using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MelodicBanjoArranger
{
    class Arrangement
    {
        int total_Cost;
        int total_variance;
        int total_pos;
        int total_neg;

        List<MatchNote> arrange_notes;




    }

    static class Arrangemenets
    {
        private static List<Arrangement> Arrange_list;
        
        // TO DO
        //
        /* 
         * Create code to 
         * - Add Arrangemenet object to arrangemenets
         * - Get all Arrangemenets
         * - Get specific Arrangemenet
         * - Evalviate the total cost of an arrangemenet
            
         */
    



        public static void add_arrangemenet(Arrangement temp_arr_)
        {
            Arrange_list.Add(temp_arr_);
        }


        public static List<Arrangement> get_arrangemenets()
        {
            return Arrange_list;
        }




    }


    static class Arrangemenet_engine
    {
        public static long last_note_position;

        public static Stack temp_note_stk;

        public static void create_arrangemnets(List<note_node> in_DT_Notes_)
        {
            temp_note_stk = new Stack();
            //find the root notes first


            foreach (note_node current_node in DecisionTree.get_top_nodes())
            {
                // Iterate through tree
                process_node(current_node);
            }



            //
            temp_note_stk = null;
        }


        public static void process_node(note_node temp_node_)
        {

            note_node temp_node2 = temp_node_;
            //Add to the stack
            temp_note_stk.Push(temp_node_);

            //Work through the child nodes for the passed parent
            foreach (note_node temp_child_ in DecisionTree.get_Children(temp_node_))
            {
                //When at the last note in the list notes then push current stack out to an arrangemenet
                if (temp_node_.NoteDetails.position == last_note_position)
                {
              
                    //Push the current child to the stack to get the last note in the current tree thread
                    temp_note_stk.Push(temp_child_);

                    //Copy the current the stack snapshot to an arrangemenet
                    List<note_node> temp2;
                    temp2.AddRange(temp_note_stk.ToArray());
                    
                    //create_arrangemnets();
                    
                    //Pop the last note off the stack
                    temp_note_stk.Pop();

                }
                else
                {
                    // Call process node again for the next set of children
                    process_node(temp_child_);
                    // Pop the last child off the stack
                    temp_note_stk.Pop();
                }





            }




        }

    }

}
