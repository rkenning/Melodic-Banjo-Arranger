using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MelodicBanjoArranger
{
    public class Arrangement
    {
        public int Arr_index { get; set; }
        public int total_Cost { get; set; }
        public int total_variance { get; set; }
        public int total_pos { get; set; }
        public int total_neg { get; set; }
        public int number_of_notes { get; set; }



        public List<note_node> arrange_notes { get; set; }


        public Arrangement(List<note_node> temp_notes)
        {
            arrange_notes = temp_notes;
        }

        public SortableBindingList<note_node> get_arrange_notes_sortable()
        {

            SortableBindingList<note_node> sortableDetails = new SortableBindingList<note_node>(arrange_notes);
           
            return sortableDetails ;
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
           int last_index = Arrange_list.Count()-1;
           temp_arr_.Arr_index = last_index + 1; 
            Arrange_list.Add(temp_arr_);
        }

        public static Arrangement get_Arrangement(int ArrIndex)
        {

            Arrangement Temp_Arr = Arrange_list.Find(obj => obj.Arr_index == ArrIndex);
            return Temp_Arr;
        }

        public static int get_max_cost()
        {
            var item = Arrange_list.OrderByDescending(i => i.total_Cost).FirstOrDefault();
            return item.total_Cost;
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


   

}
