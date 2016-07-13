using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using NAudio.Utils;
using NAudio.Midi;


namespace MelodicBanjoArranger
{
    class MidiFileClass
    {

        private Dictionary<string, string> generalProperties;
        private List<IEventRule> noteRules;
        private List<IEventRule> excludeRules;
        private List<IEventRule> eventRules;
        private List<MidiEvent> insertEvents;
        public int tempo = 120;

        public int timesig1 = 4;  //Default for all MIDI files is 4/4
        public int timesig2 = 4;  //Default for all MIDI files is 4/4  

        public MidiFileClass()
        {
            generalProperties = new Dictionary<string, string>();
            eventRules = new List<IEventRule>();
            noteRules = new List<IEventRule>();
            insertEvents = new List<MidiEvent>();
            excludeRules = new List<IEventRule>();
        }

        public const string RootElementName = "MidiMappingRules";
        public const string GeneralSettingsElementName = "General";

        public List<IEventRule> NoteRules
        {
            get
            {
                return noteRules;
            }
        }

        public List<IEventRule> EventRules
        {
            get
            {
                return eventRules;
            }
        }

        public List<IEventRule> ExcludeRules
        {
            get
            {
                return excludeRules;
            }

        }

        public List<MidiEvent> InsertEvents
        {
            get
            {
                return insertEvents;
            }
        }



        public bool ConvertFile(string sourceFile, int fileType, int TrackNum, ICollection<ArrangeNote> NoteCollection)
        {
            try
            {
                //MidiFile midiFile = new MidiFile(sourceFile);
                MidiFile midiFile = new MidiFile(sourceFile);
                if (fileType == -1)
                {
                    fileType = midiFile.FileFormat;
                }
                EventRuleArgs eventRuleArgs = new EventRuleArgs(Path.GetFileNameWithoutExtension(sourceFile));

                MidiEventCollection outputFileEvents = new MidiEventCollection(fileType, midiFile.DeltaTicksPerQuarterNote);
                bool hasNotes = false;

                int track = TrackNum;

                ; IList<MidiEvent> trackEvents = midiFile.Events[track];  // Notes the use of the Track reference, if invalid track is referenced then causes big issues

                IList<MidiEvent> outputEvents;
                if (fileType == 1 || track == 0)
                {
                    outputEvents = new List<MidiEvent>();
                }
                else
                {
                    outputEvents = outputFileEvents[0];
                }
                foreach (MidiEvent midiEvent in InsertEvents)
                {
                    outputEvents.Add(midiEvent);
                }
                foreach (MidiEvent midiEvent in trackEvents)
                {

                    outputEvents.Add(midiEvent);
                    NoteOnEvent noteOnEvent = midiEvent as NoteOnEvent;
                    if (noteOnEvent != null)
                    {
                        // Add to the midi collection
                        if (!MidiEvent.IsNoteOff(noteOnEvent))
                        {
                            ArrangeNote tempnote = new ArrangeNote(noteOnEvent);
                            NoteCollection.Add(tempnote);
                        };




                        //System.Diagnostics.Debug.Assert(noteOnEvent.OffEvent != null);
                        hasNotes = true;
                        outputEvents.Add(noteOnEvent.OffEvent);
                    }
                    //}
                }

                // Get the tempo events
                foreach (MidiEvent midiEvent in trackEvents)
                {
                    //get the tempo and drop out of that track
                    if (midiEvent is TempoEvent)
                    {
                        //tempo in milliseconds
                        tempo = (midiEvent as TempoEvent).MicrosecondsPerQuarterNote / 1000;
                        break;
                    }


                    //get the tempo and drop out of that track
                    if (midiEvent is TimeSignatureEvent)
                    {
                        //Time sig
                        timesig1 = (midiEvent as TimeSignatureEvent).Numerator;
                        timesig2 = (midiEvent as TimeSignatureEvent).Denominator;
                        break;
                    }

                }



                if (fileType == 1 || track == 0)
                {
                    outputFileEvents.AddTrack(outputEvents);
                }
                //}
                if (hasNotes)
                {
                    //MidiFile.Export(destFile, outputFileEvents);
                }

                return hasNotes;
            }
            catch
            {
                MessageBox.Show("Invalid File or track number");
                return false;
            }
        }



        public bool Process(MidiEvent inEvent, EventRuleArgs args)
        {
            NoteOnEvent noteEvent = inEvent as NoteOnEvent;

            // filter note offs - they will be added by their note-on
            if (MidiEvent.IsNoteOff(inEvent))
            {
                return false;
            }

            // if it is a note event, special processing
            if (noteEvent != null)
            {


                foreach (IEventRule rule in noteRules)
                {
                    if (rule.Apply(inEvent, args))
                        return true;

                }
                // an unmatched note event
                // TODO: configure to have an option to retain these
                return false;
            }

            // now see if we need to exclude this event
            foreach (IEventRule rule in excludeRules)
            {
                if (rule.Apply(inEvent, args))
                {
                    return false;
                }
            }

            bool updatedEvent = false;
            foreach (IEventRule rule in eventRules)
            {
                updatedEvent |= rule.Apply(inEvent, args);
            }
            return true; // updatedEvent;
        }




    }

}