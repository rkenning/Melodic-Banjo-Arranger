using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NAudio.Midi;

namespace MelodicBanjoArranger
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();





            String filepath1 = @"Test Files\bwv772.mid";
            String filepath2 = @"Test Files\bwv772.temp";

            MidiFileClass test1 = new MidiFileClass();

            BanjoNotes banjocollection = new BanjoNotes();
            ICollection<BanjoNote> tempall = new List<BanjoNote>();
    
            
            
            test1.ConvertFile(filepath1,filepath2,1, 2, tempall);

            foreach (BanjoNote temp in tempall)
            {
                txtStatus.Text +=  temp.noteNumber + "\r\n";

            }

        }
    }
}
