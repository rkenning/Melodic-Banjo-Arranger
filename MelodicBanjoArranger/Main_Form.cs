﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NAudio.Midi;
using System.IO;
using System.Diagnostics;
using System.Linq;


namespace MelodicBanjoArranger
{
    public partial class Main_Form : Form
    {
        private bool note_Draw = true;

        List<note_node> DTData_result = new List<note_node>();

        public Main_Form()
        {
            InitializeComponent();
            //Testing calls below

            update_arrangement();
            DTData_result.Clear();
            DTData_result = DTController.Process_Route_Notes(MatchNotes.matchingresults);

        }





        private void musicPanel_Paint(object sender, PaintEventArgs e)
        {

            /*   if (note_Draw == true)
               {
                   int _staffHght = 10;
                   Pen _notePen = new Pen(Color.Black, 2);
                   Brush _noteBrush = Brushes.Black;

                   Graphics g = e.Graphics;
                   g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                   this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));


                   // Draw six staffs of 5 lines down the page
                   for (int staffs = 0; staffs < 6; staffs++)
                   {
                       // draw some staff lines
                       for (int i = 1 + (staffs * 6 + 1); i < 6 + (staffs * 6 + 1); i++)
                           g.DrawLine(Pens.Black, 0, i * _staffHght, musicPanel.Width, i * _staffHght);
                   }


                   ICollection<ArrangeNote> tempall = new List<ArrangeNote>();
                   //Loop though the midi events and write the note and fret position
                   foreach (ArrangeNote temp in tempall)
                   {
                       //txtStatus.Text += temp.noteNumber + ":" + temp.position + "\r\n";

                   }



               }*/
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {


            update_arrangement();

        }

        private void update_arrangement()
        {

            txtNoteMatch.Clear();
            txtNotes.Clear();

            txtNoteMatch.Text = null;
            txtNotes.Text = null;
            txtUpdate.Text = "";

            string referencepath = @"";


            String filepath1 = Path.GetFullPath(Path.Combine(referencepath, @"..\..\TestFiles\" + txtFileName.Text));
            //String filepath1 = Path.GetFullPath(Path.Combine(referencepath, @"..\..\TestFiles\Take5Score.mid"));

            Update_Status("Loading File : " + filepath1);

            MidiFileClass MidiControlObject = new MidiFileClass();
            ICollection<ArrangeNote> MidiObject = new List<ArrangeNote>();
            //Load the midifile into the midi object
            //MidiControlObject.ConvertFile(filepath1, 1, 2, MidiObject);

            //TODO Add process to specific select track for processing Currently track 0 is only processed
            MidiControlObject.ConvertFile(filepath1, 1, 0, MidiObject);  //Note track number 0 being used for the current file


            // Create the banjo object
            BanjoNotes banjoobject = new BanjoNotes();
            //Define the matches structure
            List<MatchNote> matches = new List<MatchNote>();


            //Get the last note position for arrangements
            MatchNotes.last_note_position = MidiObject.Last().position;



            int tempo = MidiControlObject.tempo;
            int timeSig1 = MidiControlObject.timesig1;
            int timeSig2 = MidiControlObject.timesig2;



            Update_Status("Starting arrangement Process");
            Update_Status("========================");
            Update_Status("Transpose Offset = " + txtTranspose.Text);
            Update_Status("Time Sig = " + timeSig1 + "/" + timeSig2);


            //Populate the matches 

            matches = MatchNotes.Find_Matching_Notes(MidiObject, banjoobject, Convert.ToInt16(txtTranspose.Text));

            foreach (ArrangeNote temp in MidiObject)
            {

                // Pass the current note numbe to the arrangenote object to match


                txtNotes.Text += "Note Number : " + temp.noteNumber + " Note name:" + temp.noteName + " Note Postion:" + temp.position + "\r\n";

            };

            int index;
            foreach (MatchNote temp in matches)
            {

                index = matches.IndexOf(temp);
                // Write the matched note position to the screen
                txtNoteMatch.Text += "Current Index : " + index + " Position " + temp.position.ToString() + ":" + "Note Number : " + temp.notenumber + ": String Number "
                    + temp.banjoString + ":" + "Fret Number " + temp.fret + " Note name:" + temp.notename + "\r\n";

            };
        }





        private void cmdArrange_Click(object sender, EventArgs e)
        {
            update_arrangement();
        }



        public void Update_Status(String strMessage)
        {
            txtUpdate.Text += strMessage + "\r\n";

        }

        private void cmdBuildDT_Click(object sender, EventArgs e)
        {
            //Create a new Decision Tree Object

            int index;


            DTData_result.Clear();
            DTData_result = DTController.Process_Route_Notes(MatchNotes.matchingresults);


            String Temp_str = null;
            txtDTResults.Text = null;
            // Write out the DT Results
            foreach (note_node temp_node in DTData_result)
            {
                index = DTData_result.IndexOf(temp_node);
                Temp_str = Temp_str += "Current Index :" + index + " " + temp_node.ToString();
                Temp_str += "\r\n";
            }

            txtDTResults.Text = Temp_str;

        }



        public void writeDT(String Text_Log)
        {
            txtDTResults.Text += Text_Log;
        }

        private void cmdCreateDTGraph_Click(object sender, EventArgs e)
        {
            DataVisulisation.Create_Graph(DTData_result);
        }

        private void cmdCosts_Click(object sender, EventArgs e)
        {
            //Create a new Decision Tree Object

            int index;

            List<note_node> DTData_Costs = new List<note_node>();

            DTData_Costs = CostCalculator.Calculate_DT_Costs(DTData_result);

            DTData_result = DTData_Costs;


            String Temp_str = null;
            txtDTResults.Text = null;
            // Write out the DT Results
            foreach (note_node temp_node in DTData_Costs)
            {
                index = DTData_Costs.IndexOf(temp_node);
                Temp_str = Temp_str += "Current Index :" + index + " " + temp_node.ToString();
                Temp_str += "\r\n";
            }

            txtDTResults.Text = Temp_str;
        }

        private void cmdCheckTree_Click(object sender, EventArgs e)
        {

        }

        private void cmdCreateArrangemenets_Click(object sender, EventArgs e)
        {
            Arrangemenet_engine.create_arrangemnets(DecisionTree.get_all_nodes());
            String tempStr = "";

            foreach (Arrangement tempArr in Arrangemenet_engine.get_arrangemenets())
            {
                tempStr += tempArr.ToString();
            }

            txtArrange.Text = null;
            txtArrange.Text = tempStr;

            /* Bind the arrangemenet collection to the Grid Form control
             */

            // Copy returned list object to temp sortable binding list


            dGridArrangements.DataSource = Arrangemenet_engine.get_arrangemenets_sortable();



        }



    }

}

