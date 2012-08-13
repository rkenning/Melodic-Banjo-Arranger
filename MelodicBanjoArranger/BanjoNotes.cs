using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio.Utils;
using NAudio.Midi;

namespace MelodicBanjoArranger
{
    public class BanjoNote
    {
         public int noteNumber {get; set;}
         public int velocity {get; set;}
         public int duration {get; set;}
         public long position {get; set;}
         public long String { get; set; }
         public long fret { get; set; }

         public BanjoNote(int NoteNumber_, int velocity_, int duration_, long position_)
         {
             noteNumber = NoteNumber_;
             velocity = velocity_;
             duration = duration_;
             position = position_;
         }


         public BanjoNote(NoteOnEvent noteOnEvent)
         {
             noteNumber = noteOnEvent.NoteNumber;
             velocity = noteOnEvent.Velocity;
             duration = noteOnEvent.NoteLength;
             position = noteOnEvent.AbsoluteTime  ;
         }


    }

    public class BanjoNotes
    {
        public ICollection<BanjoNote> allnotes;
    }

}
