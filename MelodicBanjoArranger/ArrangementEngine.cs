﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MelodicBanjoArranger
{

    public class matchref
    {
        public int notenumber { get; set; }
        public int banjoString { get; set; }
        public int fret { get; set; }
        public long position { get; set; }
        public string notename { get; set; }

        public matchref(int notenumber_, int banjostring_, int fret_, long position_ ,string notename_)
        {
            notenumber = notenumber_;
            banjoString = banjostring_;
            fret = fret_;
            position = position_;
            notename = notename_;
        }

        /* 
         * TO DO
         * ======
         * Create the data type to support the Decision Tree structure
         * - Point to index of list returned from the function Find_Matching_Notes
         * - Base cost of from and to note postions
         * 
         *  (May need to move things around and create a static list for Find_Matching_Notes)
         *  
         * 
         * 
         * ALSO  need find or create a  general class to return any note e.g. D7 based on a note number  (See point A1 below)
         */





    }

    public static class arragement
    {

        // Populate Matching results List with all possible matching positions to play each note passed in TempAllNotes
        // Also allows for modification of notes by -/+ octive intivals
        public static List<matchref> Find_Matching_Notes(ICollection<ArrangeNote> TempAllNotes, BanjoNotes banjotemp, int transpose)
        {

            List<matchref> matchingresults = new List<matchref>();

            foreach (ArrangeNote temp1 in TempAllNotes)
            {

                // Review each note and map it to a banjo fret
                // perform a seach in the 5 lists for the frequence value
                for (int string_count = 0; string_count < 5; string_count++)
                {
                    for (int fret_count = banjotemp.starting_frets[string_count]; fret_count < banjotemp.max_frets + 1; fret_count++)
                    {
                        // If this is a matching note then add the note to the matching results
                        if (banjotemp.allnotes[string_count, fret_count] == temp1.noteNumber+(transpose))
                            matchingresults.Add(new matchref(temp1.noteNumber + (transpose), string_count, fret_count, temp1.position, "test" ));  /* A1 */

                    }
                }



            }
            return matchingresults;


        }
    }

}


