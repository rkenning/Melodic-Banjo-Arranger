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
using AlphaTab.Importer;
using AlphaTab.Model;


namespace MelodicBanjoArranger
{
    public partial class Main_Form : Form
    {
        List<note_node> DTData_result = new List<note_node>();

        private void update_DTResults(List<note_node> DTData_Display)
        {
            // NEW DataGrid Stuff
            note_node temp_node;
            int index;

            this.dataDTResults.DataSource = null;
            this.dataDTResults.Refresh();

            DataTable table = new DataTable("DTResults");
            List<String> Result_list = new List<string>();
            table.Columns.Add("Index");
            table.Columns.Add("Results");
            for (int i = 0; i < DTData_Display.Count; i++)
            //foreach (note_node temp_node in DTData_result)
            {
                temp_node = DTData_Display[i];
                index = i;
                table.Rows.Add(index, temp_node.ToString());
            }

            this.dataDTResults.DataSource = table;
        }


        public Main_Form()
        {
            InitializeComponent();
        }


        private void Main_Form_Load(object sender, EventArgs e)
        {
            //Testing Calls to work through the setup of DT, Arrangements etc..
            update_arrangement();
            cmdBuildDT_Click(sender , e);
            cmdCosts_Click(sender, e);
            cmdCreateArrangemenets_Click(sender, e);
           

        }

        private void update_arrangement()
        {

            //Open Status dlg screen
            Logging.Open_Dlg();



            txtNoteMatch.Clear();
            txtNotes.Clear();

            txtNoteMatch.Text = null;
            txtNotes.Text = null;
            

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


            //TODO All the stuff below is rubbish - General re-wite required for this + move out to a class
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
          
            Logging.Open_Dlg();

            //Create a new Decision Tree Object
            DTData_result.Clear();
            DTData_result = DTController.Process_Route_Notes(MatchNotes.matchingresults);

            lblMatchingNotes.Text = MatchNotes.get_matching_note_count().ToString();

            // Write out the DT Results
            Logging.Update_Status("Writing " + DTData_result.Count + " to form");
            Logging.Update_Status("Finished DT Build, Updating Screen");

            //Call local method to update the forms DataGrid with the latest DT Results
            update_DTResults(DTData_result);
            
            Logging.Update_Status("DT calculation complete & form updated");
        }
       private void cmdCreateDTGraph_Click(object sender, EventArgs e)
        {
            DataVisulisation.Create_Graph(DTData_result);
        }

        private void cmdCosts_Click(object sender, EventArgs e)
        {
            //Create a new Decision Tree Object

            List<note_node> DTData_Costs = new List<note_node>();

            DTData_Costs = CostCalculator.Calculate_DT_Costs(DTData_result, this);
            DTData_result = DTData_Costs;


            //Call local method to update the forms DataGrid with the latest DT Results
            update_DTResults(DTData_result);

            Logging.Update_Status("DT cost calculation complete & form updated");
        }

        private void cmdCheckTree_Click(object sender, EventArgs e)
        {

        }

        private void cmdCreateArrangemenets_Click(object sender, EventArgs e)
        {
            Arrangemenet_engine.create_arrangemnets(DecisionTree.get_all_nodes());
            String tempStr = "";

            txtArrange.Text = null;
            txtArrange.Text = tempStr;

            dGridArrangements.DataSource = null;
           
            dGridArrangements.DataSource = Arrangemenet_engine.get_arrangemenets_sortable();



        }

        private void cmdCreateScore_Click(object sender, EventArgs e)
        {
            //Return selected arrangement from Data Grid
            try
            {
                
                int SelectArrangement = Convert.ToInt32(this.dGridArrangements.SelectedRows[0].Cells[0].Value);
                
                txtSelectedArrangement.Text = SelectArrangement.ToString();

                Arrangement temp_arr = Arrangemenets.get_Arrangement(SelectArrangement);

                txtArrange.Text = temp_arr.ToString();

                //Copy the new AlphaText markup to the text box
                //TODO Remove txtbox and add direct to Byte array

                txtAlphaMarkup.Text = AlphaTabController.Build_AlphaText(temp_arr);
                //txtAlphaMarkup.Text = AlphaTabController.Example_Text;


          


               
            }
            catch
            {

                //Error if no line is selected
                MessageBox.Show("You need to select a line");
            }
        }

        //Alpha TAB Stuff Below
        //=========================
        //TO DO This all needs to be moved to somewhere better than in the main form code

        private Score _score;
        private int _currentTrackIndex;

        #region Score Data

        public Score Score
        {
            get { return _score; }
            set
            {
                _score = value;
    //            showScoreInfo.Enabled = value != null;
                Text = "AlphaTab - " + (value == null ? "No File Opened" : value.Title);
                CurrentTrackIndex = 0;
            }
        }

        public int CurrentTrackIndex
        {
            get { return _currentTrackIndex; }
            set
            {
                _currentTrackIndex = value;
             
                var track = CurrentTrack;
                if (track != null)
                {
                    alphaTabControl1.Track = track;
                }
            }
        }

        public Track CurrentTrack
        {
            get
            {
                if (Score == null || CurrentTrackIndex < 0 || CurrentTrackIndex >= _score.Tracks.Count) return null;
                return _score.Tracks[_currentTrackIndex];
            }
        }

        #endregion

        #region Score Loading

        private void InternalOpenFile(byte[] data)
        {
            try
            {
                // load the score from the filesystem
                Score = ScoreLoader.LoadScoreFromBytes(data);
            }

            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "An error during opening the file occured", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }




        #endregion

        private void cmdRenderAlphaTab_Click(object sender, EventArgs e)
        {
            byte[] array = Encoding.ASCII.GetBytes(this.txtAlphaMarkup.Text);
            InternalOpenFile(array);
        }
    }
}



