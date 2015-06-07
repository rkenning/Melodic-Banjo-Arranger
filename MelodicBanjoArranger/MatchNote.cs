using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MelodicBanjoArranger
{



    public class MatchNote
    {
        public int notenumber { get; set; }
        public int banjoString { get; set; }
        public int fret { get; set; }
        public long position { get; set; }
        public string notename { get; set; }

        public MatchNote(int notenumber_, int banjostring_, int fret_, long position_, string notename_)
        {
            notenumber = notenumber_;
            banjoString = banjostring_;
            fret = fret_;
            position = position_;
            notename = notename_;
        }

        public override string ToString()
        {
            String Temp_string;
            Temp_string = "Note Number:" + notenumber.ToString();
            Temp_string += " String:" + banjoString.ToString();
            Temp_string += " Fret:" + fret.ToString();
            Temp_string += " Position:" + position.ToString();
            Temp_string += " NoteName:" + notename.ToString();

            return Temp_string;

        }

        public string ToStringSmall()
        {
            String Temp_string;
            Temp_string =  position.ToString();
            Temp_string += ":" + notenumber.ToString();
            Temp_string += ":" + banjoString.ToString();
            Temp_string += ":" + fret.ToString();
            Temp_string += ":"+ notename.ToString();

            return Temp_string;

        } 

    }




    public  class MatchNotes
    {

        // Moved to a public static allowing results to be accessed outside of class
        public static List<MatchNote> matchingresults = new List<MatchNote>();

        // Populate Matching results List with all possible matching positions to play each note passed in TempAllNotes
        // Also allows for modification of notes by -/+ octive intivals
        public static List<MatchNote> Find_Matching_Notes(ICollection<ArrangeNote> TempAllNotes, BanjoNotes banjotemp, int transpose)
        {
            matchingresults.Clear(); // We need to clear any previsouly matched results
           
            foreach (ArrangeNote temp1 in TempAllNotes)
            {
                // Review each note and map it to a banjo fret
                // perform a seach in the 5 lists for the frequence value
                for (int string_count = 0; string_count < 5; string_count++)
                {
                    for (int fret_count = banjotemp.starting_frets[string_count]; fret_count < banjotemp.max_frets + 1; fret_count++)
                    {
                        
                       /*NOTE : The searching process below is just plain rubbish (from performance perspective) however will redo when 
                         Got basics working*/
 

                        // If this is a matching note then add the note to the matching results
                        if (banjotemp.allnotes[string_count, fret_count] == temp1.noteNumber + (transpose))
                            matchingresults.Add(new MatchNote(temp1.noteNumber + (transpose), string_count, fret_count, temp1.position, note_names.get_note_name(temp1.noteNumber+(transpose))));  /* A1 */
                    
                        
                  



                    }
                }



            }
            return matchingresults;


        }
    }

}


