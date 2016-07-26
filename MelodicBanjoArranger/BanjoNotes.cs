using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio.Utils;
using NAudio.Midi;

namespace MelodicBanjoArranger
{
    public static class note_names
    {

        private static readonly string[] NoteNames = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

        static public string get_note_name(int noteNumber)
        {
            int octave = noteNumber / 12;
            return (string.Format("{0}{1}", NoteNames[noteNumber % 12], octave));
        }
    }


    public class MidiNotes
    {
        public int noteNumber { get; set; }
        public String noteName { get; set; }
        public int velocity { get; set; }
        public int duration { get; set; }
        public long position { get; set; }
        public long String { get; set; }
        public long fret { get; set; }
        public bool last_map { get; set; }




        public MidiNotes(int NoteNumber_, int velocity_, int duration_, long position_)
        {
            noteNumber = NoteNumber_;
            velocity = velocity_;
            duration = duration_;
            position = position_;
        }


        public MidiNotes(NoteOnEvent noteOnEvent)
        {
            noteNumber = noteOnEvent.NoteNumber;
            velocity = noteOnEvent.Velocity;
            duration = noteOnEvent.NoteLength;
            position = noteOnEvent.AbsoluteTime;
            noteName = noteOnEvent.OffEvent.NoteName;
        }

    }



    public class BanjoNotes
    {
        //MDimen Array to hold Banjo String, Fret Number, Note Number relationship
        public int[,] allnotes = new int[5, 23];
        //Define the starting frets for each string (5 string banjo 5th string starts at the 5th fret)
        public int[] starting_frets = new int[5] { 5, 0, 0, 0, 0 };
        public int[] starting_notes = new int[5] { 67, 50, 55, 59, 62 };

        public int max_frets = 22; //Changed to reuce options

        public BanjoNotes(int max_frets_)
        {
            // Constructor

            // Populate the allnotes array with notes from standard tunings
            // ** This can be altered for other tunings **
            // ** Might event add suggested tunings in a later release **
            /*
            
             * Array Element) string	Note	MIDI Number Array
                ======	====	===========
            4)  D5 = 62
            3)  B4 = 59
            2)  G4 = 55
            1)  D4 = 50
            0)  G5 = 67  
            
            Number of frets :
              Strings 2-5 = 20 frets
              String  1 = 17 frets 

             */

            max_frets = max_frets_;
            
            // Loop through each string
            for (int string_count = 0; string_count < 5; string_count++)
            {
                for (int fret_count = starting_frets[string_count]; fret_count < max_frets + 1; fret_count++)
                {
                    if (string_count > 0)
                    {
                        allnotes[string_count, fret_count] = starting_notes[string_count] + fret_count;
                    }
                    else
                    {
                        // Due to the 5th string starting at 5th freet need to adjust off set
                        allnotes[string_count, fret_count] = starting_notes[string_count] + fret_count - 5;
                    }

                }
            }

        }





    }






}

