using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MelodicBanjoArranger
{
    public class Arrangement
    {
        public int Arr_index { get; set; }
        public int total_Cost { get; set; }
        public int total_variance { get; set; }
        public int total_pos { get; set; }
        public int total_neg { get; set; }
       

        List<note_node> arrange_notes { get; set; }


        public Arrangement(List<note_node> temp_notes)
        {
            arrange_notes = temp_notes;
        }

        public override string ToString()
        {
            String TempStr;
            TempStr = "Index: " + Arr_index+  " Total Cost: " + total_Cost + " Total Neg:"+total_neg +" Total Pos:" +total_pos;
            TempStr += "\r\n";
            foreach (note_node temp_node in arrange_notes)
            {
                TempStr += "    " + temp_node.ToStringSmall();
                TempStr += "\r\n";
            }
            TempStr += "\r\n";
            return TempStr;
        }

    }

    static class Arrangemenets
    {
        private static List<Arrangement> Arrange_list = new List<Arrangement>();

        //Add arrangemenet objects to arrangemenets list
        public static void add_arrangemenet(Arrangement temp_arr_)
        {
           int last_index = Arrange_list.Count();
           temp_arr_.Arr_index = last_index + 1; 
            Arrange_list.Add(temp_arr_);
        }

        //Return the list of arrangemenets
        public static List<Arrangement> get_arrangemenets()
        {
            return Arrange_list;
        }

        public static SortableBindingList<Arrangement> get_arrangemenets_sortable()
        {
            SortableBindingList<Arrangement> tempList = new SortableBindingList<Arrangement>(Arrange_list);
            return tempList;
          
        }



    }


    static class Arrangemenet_engine
    {


        public static Stack temp_note_stk;

        public static List<Arrangement> get_arrangemenets()
        {
            return Arrangemenets.get_arrangemenets();
        }


        public static SortableBindingList<Arrangement> get_arrangemenets_sortable()
        {
            return Arrangemenets.get_arrangemenets_sortable();
        }


        public static void create_arrangemnets(List<note_node> in_DT_Notes_)
        {
            temp_note_stk = new Stack();
            //find the root notes first


            foreach (note_node current_node in DecisionTree.get_top_nodes())
            {
                // Iterate through tree
                process_node(current_node);
                temp_note_stk.Pop(); // Not quite sure why I need this pop but doesn't appear to clear stack after looping to next [root] node
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
                if (temp_child_.NoteDetails.position == MatchNotes.last_note_position)
                {

                    //Push the current child to the stack to get the last note in the current tree thread
                    temp_note_stk.Push(temp_child_);

                    //Copy the current the stack snapshot to an arrangemenet
                    List<note_node> temp2;

                    //TO DO : Clean up the following as creation of temp array object not great but works for the mo
                    note_node[] tempArray = new note_node[temp_note_stk.Count];
                    temp_note_stk.ToArray().CopyTo(tempArray, 0);
                    temp2 = tempArray.ToList();
                    temp2.Reverse(); // Stack values will be the wrong way round so need to reverse

                    Arrangement tempArrange = new Arrangement(temp2);
                    
                    
                    foreach(note_node temp_node in temp2)
                    {
                        tempArrange.total_Cost += temp_node.cost;
                        if (temp_node.cost < 0)
                            tempArrange.total_neg += temp_node.cost;
                        if (temp_node.cost > 0)
                            tempArrange.total_pos += temp_node.cost;
                    
                    }


                    Arrangemenets.add_arrangemenet(tempArrange);

                    //Calculate the costs of the arrangemenet
                    


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
