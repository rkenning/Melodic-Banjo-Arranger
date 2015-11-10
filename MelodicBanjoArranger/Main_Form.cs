using System;
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
using System.Threading;


namespace MelodicBanjoArranger
{
    public partial class Main_Form : Form
    {
        List<note_node> DTData_result = new List<note_node>();

        public Main_Form()
        {
            InitializeComponent();
            //Testing calls below

            update_arrangement();
            DTData_result.Clear();
            DTData_result = DTController.Process_Route_Notes(MatchNotes.matchingresults);

        }


        private void Main_Form_Load(object sender, EventArgs e)
        {
            update_arrangement();
        }

        private void update_arrangement()
        {

            //Open Status dlg screen
            Logging.Open_Dlg();



            txtNoteMatch.Clear();
            txtNotes.Clear();

            txtNoteMatch.Text = null;
            txtNotes.Text = null;
            txtUpdate.Text = "";

            string referencepath = @"";


            String filepath1 = Path.GetFullPath(Path.Combine(referencepath, @"..\..\TestFiles\" + txtFileName.Text));

            Logging.Update_Status("Loading File : " + filepath1);

            MidiFileClass MidiControlObject = new MidiFileClass();
            ICollection<ArrangeNote> MidiObject = new List<ArrangeNote>();
            //Load the midifile into the midi object
            //MidiControlObject.ConvertFile(filepath1, 1, 2, MidiObject);

            //TODO Add process to specific select track for processing Currently track 0 is only processed
            int trackNumber;
            if (Int32.TryParse(txtTrackNumber.Text, out trackNumber))
                MidiControlObject.ConvertFile(filepath1, 1, trackNumber , MidiObject);  //Note track number 0 being used for the current file
            else
                throw new System.ArgumentException("Invalid Track Number.  Music be numeric", "Error");

            // Create the banjo object
            BanjoNotes banjoobject = new BanjoNotes();
            //Define the matches structure
            List<MatchNote> matches = new List<MatchNote>();


            //Get the last note position for arrangements
            MatchNotes.last_note_position = MidiObject.Last().position;

            int tempo = MidiControlObject.tempo;
            int timeSig1 = MidiControlObject.timesig1;
            int timeSig2 = MidiControlObject.timesig2;

            Logging.Update_Status("Starting arrangement Process");
            Logging.Update_Status("========================");
            Logging.Update_Status("Transpose Offset = " + txtTranspose.Text);
            Logging.Update_Status("Time Sig = " + timeSig1 + "/" + timeSig2);


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

        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(string text);



        private void cmdBuildDT_Click(object sender, EventArgs e)
        {
            //Create a new Decision Tree Object
            Logging.Open_Dlg();
            int index;
            string build_line = "";

            DTData_result.Clear();
            DTData_result = DTController.Process_Route_Notes(MatchNotes.matchingresults);


            String Temp_str = null;
            dataDTResults.Rows.Clear();
            // Write out the DT Results
            Logging.Update_Status("Writing " + DTData_result.Count + " to form");
            

        
            long write_count = 1;
            int last_update =0;

            Logging.Update_Status("Finished DT Build, Updating Screen");


            note_node temp_node;


            StringBuilder MyStringBuilder = new StringBuilder("");

            // NEW DataGrid Stuff
            DataTable table = new DataTable("DTResults");
            

            this.dataDTResults.Columns.Add("Results", "Results");
            this.dataDTResults.Rows.Add("Test");

            List<String> Result_list = new List<string>();

            for (int i=0; i< DTData_result.Count;i++)
            //foreach (note_node temp_node in DTData_result)
            {
                temp_node = DTData_result[i];
                index = i;
                build_line = "Current Index :" + index + " " + temp_node.ToString()+"\r\n"; ;
                Result_list.Add(build_line);
                // this.dataDTResults.Rows.Add(build_line);

            }

            SortableBindingList<String> tempList = new SortableBindingList<string>(Result_list);
            this.dataDTResults.DataSource = tempList;

            //txtDTResults.AppendText(MyStringBuilder.ToString());
            //this.lal

            Logging.Update_Status("DT calculation complete & form updated");
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

            DTData_Costs = CostCalculator.Calculate_DT_Costs(DTData_result, this);

            DTData_result = DTData_Costs;


            String Temp_str = null;
            dataDTResults.Rows.Clear();
            // Write out the DT Results
            foreach (note_node temp_node in DTData_Costs)
            {
                index = DTData_Costs.IndexOf(temp_node);
                Temp_str = Temp_str += "Current Index :" + index + " " + temp_node.ToString();
                Temp_str += "\r\n";
            }

           // txtDTResults.Text = Temp_str;
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

