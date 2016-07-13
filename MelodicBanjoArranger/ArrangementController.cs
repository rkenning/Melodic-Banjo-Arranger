using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MelodicBanjoArranger
{
    static class Arrangemenet_engine
    {
        public static int original_note_count { get; set; }

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


            Logging.Update_Status("Starting the tree walking process");
            foreach (note_node current_node in DecisionTree.get_top_nodes())
            {
                // Iterate through tree
                int starting_cost_ = 0;
                process_node(current_node, starting_cost_);
                temp_note_stk.Pop(); // Not quite sure why I need this pop but doesn't appear to clear stack after looping to next [root] node

            }
            Logging.Update_Status("Finished the Arrangement Process");


            //
            temp_note_stk = null;
        }


        public static void process_node(note_node temp_node_, int current_cost_)
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


                    //Generate the Arrangement
                    Arrangement tempArrange = new Arrangement(temp2);



                    tempArrange.number_of_notes = temp2.Count();

                    //Check if the arrangement has all the required notes
                    //If yes then add the arrangment
                    if (temp2.Count() == Arrangemenet_engine.original_note_count)
                    {
                        //Calculate the total costs of the arrangemenet
                        foreach (note_node temp_node in temp2)
                        {
                            tempArrange.total_Cost += temp_node.cost;
                            if (temp_node.cost < 0)
                                tempArrange.total_neg += temp_node.cost;
                            if (temp_node.cost > 0)
                                tempArrange.total_pos += temp_node.cost;

                        };
                        Arrangemenets.add_arrangemenet(tempArrange);
                    };




                    temp_note_stk.Pop();

                }
                else
                {
                    // Call process node again for the next set of children
                    process_node(temp_child_, current_cost_);
                    // Pop the last child off the stack
                    temp_note_stk.Pop();
                }
            };
        }
    }
}
