using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NAudio.Midi;
using System.IO;

namespace MelodicBanjoArranger
{
    public partial class Main_Form : Form
    {
        private bool note_Draw = true;

        public Main_Form()
        {
            InitializeComponent();




        }




        private void musicPanel_Paint(object sender, PaintEventArgs e)
        {

            if (note_Draw == true)
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







                g.DrawString("9", Font, _noteBrush, 10, 10);
                g.DrawString("9", Font, _noteBrush, 20, 30);
                g.DrawString("9", Font, _noteBrush, 10, 40);


                // draw four semi-random full and quarter notes
                /*g.DrawEllipse(_notePen, 10, 2 * _staffHght, _noteWdth, _noteHght);
                g.DrawEllipse(_notePen, 50, 4 * _staffHght, _noteWdth, _noteHght);

                g.FillEllipse(_noteBrush, 100, 2 * _staffHght, _noteWdth, _noteHght);
                g.FillEllipse(_noteBrush, 150, 4 * _staffHght, _noteWdth, _noteHght); */

                //g.DrawString("9",Font,  _noteBrush, 2 * _staffHght, _noteWdth, _noteHght);

            }
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


            String filepath1 = Path.GetFullPath(Path.Combine(referencepath, @"..\..\TestFiles\bwv772.mid"));
            //String filepath1 = Path.GetFullPath(Path.Combine(referencepath, @"..\..\TestFiles\Take5Score.mid"));


            MidiFileClass MidiControlObject = new MidiFileClass();
            ICollection<ArrangeNote> MidiObject = new List<ArrangeNote>();
            //Load the midifile into the midi object
            MidiControlObject.ConvertFile(filepath1, 1, 2, MidiObject);

            // Create the banjo object
            BanjoNotes banjoobject = new BanjoNotes();
            //Define the matches structure
            List<MatchNote> matches = new List<MatchNote>();




            int tempo = MidiControlObject.tempo;
            int timeSig1 = MidiControlObject.timesig1;
            int timeSig2 = MidiControlObject.timesig2;



            txtUpdate.Text += "Starting arrangement Process" + "\r\n";
            txtUpdate.Text += "========================" + "\r\n";
            txtUpdate.Text += "Transpose Offset = " + txtTranspose.Text + "\r\n";

            txtUpdate.Text += "Time Sig = " + timeSig1 + "/" + timeSig2 + "\r\n";


            //Populate the matches 

            matches = MatchNotes.Find_Matching_Notes(MidiObject, banjoobject, Convert.ToInt16(txtTranspose.Text));

            foreach (ArrangeNote temp in MidiObject)
            {

                // Pass the current note numbe to the arrangenote object to match


                txtNotes.Text += "Note Number : " + temp.noteNumber + " Note name:" + temp.noteName + " Note Postion:" + temp.position + "\r\n";

            };


            foreach (MatchNote temp in matches)
            {
                // Write the matched note position to the screen
                txtNoteMatch.Text += "Position " + temp.position.ToString() + ":" + "Note Number : " + temp.notenumber + ": String Number "
                    + temp.banjoString + ":" + "Fret Number " + temp.fret + " Note name:" + temp.notename + "\r\n";

            };
        }





        private void cmdArrange_Click(object sender, EventArgs e)
        {
            update_arrangement();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }










    }

}

