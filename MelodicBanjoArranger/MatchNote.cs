using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace MelodicBanjoArranger
{



    public class MatchNote
    {
        public int notenumber { get; set; }
        public int banjoString { get; set; }
        public int fret { get; set; }
        public long position { get; set; }
        public string notename { get; set; }
        public bool last_note { get; set; }

        public MatchNote(int notenumber_, int banjostring_, int fret_, long position_, string notename_, bool last_note_)
        {
            notenumber = notenumber_;
            banjoString = banjostring_;
            fret = fret_;
            position = position_;
            notename = notename_;
            last_note = last_note_;


        }

        public override string ToString()
        {
            StringBuilder Temp_string = new StringBuilder();
            Temp_string.Append( "Note Number:" + notenumber.ToString());
            Temp_string.Append(" String:" + banjoString.ToString());
            Temp_string.Append(" Fret:" + fret.ToString());
            Temp_string.Append(" Position:" + position.ToString());
            Temp_string.Append(" NoteName:" + notename.ToString());
            Temp_string.Append(" Last Note:" + last_note.ToString()); 

            return Temp_string.ToString();

        }

        public string ToStringSmall()
        {
            StringBuilder Temp_string = new StringBuilder();
            Temp_string.Append("Pos:"+position.ToString());
            Temp_string.Append(" Num:" + notenumber.ToString());
            Temp_string.Append(" Str:" + banjoString.ToString());
            Temp_string.Append("\nFet:" + fret.ToString());
            Temp_string.Append(" Name:" + notename.ToString());

            return Temp_string.ToString();

        }

    }

    public class MatchNotes
    {


        public static long last_note_position;

        // Moved to a public static allowing results to be accessed outside of class
        public static List<MatchNote> matchingresults = new List<MatchNote>();

        public static int get_matching_note_count()
        {
            return matchingresults.Count();
        }

        public static void set_last_match()
        {
            matchingresults[matchingresults.Count - 1].last_note = true;
        }


        public static long DT_size_projection()
        {
            
            var grouped = matchingresults
                .GroupBy(i => i.position)
                .Select(i => new { temp = i.Key, count = i.Count() });

            long lastResult = 1;
            foreach (var thing in grouped)
            {
                lastResult *= thing.count;
            }
            return lastResult;
        }

        //Return the next set of matching notes options based on the recieved match object
        public static List<MatchNote> getNextMatchNotes(MatchNote CurrentMatchNote)
        {

            //TODO Rewrite all this method with better Linq queries
            try
            {
                List<MatchNote> tempMatchNotes = new List<MatchNote>();
                MatchNote NextNote = null;

                //Find the index of the recieved MatchNote parameter
                int MatchNoteIndex = MatchNotes.matchingresults.IndexOf(CurrentMatchNote);

                //First find the note details for the next note in the collection for reference to position in loop below
                //this ensure only the [next] notes from the note specificed in the pamarater are selected
                for (int i = MatchNoteIndex; i < MatchNotes.matchingresults.Count(); i++)
                {
                    if (MatchNotes.matchingresults[i].position > CurrentMatchNote.position)
                    {
                        NextNote = MatchNotes.matchingresults[i];
                        break;
                    }


                }

                //Now first [next] note index position has been found, loop through the next notes until the position
                //changes signifiying a different note
                for (int i = MatchNotes.matchingresults.IndexOf(NextNote); i < MatchNotes.matchingresults.Count(); i++)
                {

                    if (MatchNotes.matchingresults[i].position != NextNote.position)
                        break;
                    else
                        //Add 
                        tempMatchNotes.Add(MatchNotes.matchingresults[i]);
                }

                return tempMatchNotes;
            }
            catch
            {

                return null;
            }
        }




        // Populate Matching results List with all possible matching positions to play each note passed in TempAllNotes
        // Also allows for modification of notes by -/+ octive intivals
        public static List<MatchNote> Find_Matching_Notes(ICollection<MidiNotes> TempAllNotes, BanjoNotes banjotemp, int transpose, int max_frets)
        {
            Logging.Update_Status("Starting Note Matching Process");
            matchingresults.Clear(); // We need to clear any previsouly matched results
            bool note_matched_;

            foreach (MidiNotes temp1 in TempAllNotes)
            {
                note_matched_ = false;
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
                        {
                            MatchNote TempMatchNote = new MatchNote(temp1.noteNumber + (transpose), string_count, fret_count, temp1.position,
                                    note_names.get_note_name(temp1.noteNumber + (transpose)), false);
                            matchingresults.Add(TempMatchNote);
                            note_matched_ = true;
                        }


                    }
                }

                //Set the last note in the collection to true
                set_last_match();


                if (note_matched_ == false)
                {

                    Logging.Update_Status("Note :" + temp1.ToString() + " cannot be matched");
                    //return matchingresults;
                    //throw new System.ArgumentException("Some notes cannot be match with this tranposition", "original");
                }

            }
            Logging.Update_Status("End Note Matching Process");
            return matchingresults;



        }


    }
}


