using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio.Utils;
using NAudio.Midi;

namespace MelodicBanjoArranger
{
    public class ArrangeNote
    {
        public int noteNumber { get; set; }
        public String noteName { get; set; }
        public int velocity { get; set; }
        public int duration { get; set; }
        public long position { get; set; }
        public long String { get; set; }
        public long fret { get; set; }


        private static readonly string[] NoteNames = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        
        public string get_note_name(int noteNumber)
        {
            int octave = noteNumber / 12;
            return (string.Format("{0}{1}", NoteNames[noteNumber % 12], octave));
        }


        public ArrangeNote(int NoteNumber_, int velocity_, int duration_, long position_)
        {
            noteNumber = NoteNumber_;
            velocity = velocity_;
            duration = duration_;
            position = position_;
        }


        public ArrangeNote(NoteOnEvent noteOnEvent)
        {
            noteNumber = noteOnEvent.NoteNumber;
            velocity = noteOnEvent.Velocity;
            duration = noteOnEvent.NoteLength;
            position = noteOnEvent.AbsoluteTime;
            noteName = noteOnEvent.OffEvent.NoteName;
        }


        public bool Perform_Arrangement()
        {
            try
            {
                ICollection<ArrangeNote> tempall = new List<ArrangeNote>();
                foreach (ArrangeNote temp in tempall)
                {

                    // Review each note and map it to a banjo fret
                    // perform a seach in the 5 lists for the frequence value

                    //To do
                    /* -Create 5 sting list sctructors (Note to fret)
                     * -Add a search across the scturers from each note
                     * - 
                     * 
                     */



                }
                return true;
            }
            catch { return false; };

        }


    }

    public class ArrangeNotes
    {
        public ICollection<ArrangeNote> allnotes;
    }


    public class BanjoNote
    {


    }




    
    public class BanjoNotes
    {
        //MDimen Array to hold Banjo String, Fret Number, Note Number relationship
        public int[,] allnotes = new int[5,24];

        public BanjoNotes
            (
            // Constructor

            // Populate the allnotes array with notes from standard tunings
            // ** This can be altered for other tunings **
            // ** Might event add suggested tunings in a later release **

            /*
            string	Note	MIDI Number
            ======	====	===========
            5 - 	D5 	- 74
            4 - 	B4 	- 71
            3 - 	G4 	- 67
            2 - 	C3 	- 48
            1 - 	G5 	- 79
            
            Number of frets :
              22 Strings 2-5 
              String 1 = 17 frets 

             */
           // for (int i= 

            );


        public static string return_next_note(string last_note)
        {
            String Note_part = last_note.Substring(1, 1);
            String Octave_part = last_note.Substring(2, 1);

            return Note_part + Octave_part;
        }


    }






}
