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
private  bool note_Draw;

        public Main_Form()
        {
            InitializeComponent();

            note_Draw = false;

            string referencepath = @"";


            String filepath1 = Path.GetFullPath(Path.Combine(referencepath, @"..\..\TestFiles\bwv772.mid"));
            String filepath2 = Path.GetFullPath(Path.Combine(referencepath, @"..\..\TestFiles\bwv772.temp"));


            MidiFileClass test1 = new MidiFileClass();

            ArrangeNotes banjocollection = new ArrangeNotes();
            ICollection<ArrangeNote> tempall = new List<ArrangeNote>();



            test1.ConvertFile(filepath1, filepath2, 1, 2, tempall);

            foreach (ArrangeNote temp in tempall)
            {
                txtStatus.Text += temp.noteNumber + ":" + temp.noteName + ":" + temp.position + "\r\n";

            }



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




    }
}

