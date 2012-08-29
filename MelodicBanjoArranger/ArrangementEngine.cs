using System;
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

        public matchref(int notenumber_, int banjostring_, int fret_, long position_)
        {
            notenumber = notenumber_;
            banjoString = banjostring_;
            fret = fret_;
            position = position_;
        }

    }

    public static class arragement
    {

        public static List<matchref> Perform_Arrangement(ICollection<ArrangeNote> TempAllNotes, BanjoNotes banjotemp, int octave_change)
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
                        // If this is a matchin note then
                        if (banjotemp.allnotes[string_count, fret_count] == temp1.noteNumber+(24*octave_change))
                            matchingresults.Add(new matchref(temp1.noteNumber + (24 * octave_change), string_count, fret_count, temp1.position));

                    }
                }



            }
            return matchingresults;


        }
    }

}


