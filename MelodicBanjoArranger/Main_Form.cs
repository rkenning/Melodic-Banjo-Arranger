using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using AlphaTab.Importer;
using AlphaTab.Model;
using System.Threading.Tasks;
using System.Threading;


namespace MelodicBanjoArranger
{
    public partial class Main_Form : Form
    {
        public static Main_Form Self;  // Needed for reference by the 



        CancellationTokenSource cts;
        
        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(string text);

        List<note_node> DTData_result = new List<note_node>();

        private void update_DTResults(List<note_node> DTData_Display)
        {
            //Disabled until trimming of the DTree is resolved
            // This finctionality has been disabled as the Tree view is a lot better view
            //TODO might add a tab with a breakdown of the full DT listing
            return;

            // NEW DataGrid Stuff
            note_node temp_node;
            int index;

            //this.dataDTResults.DataSource = null;
            //this.dataDTResults.Refresh();

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

            Logging.Update_Status("DT Total Table Size = " + table.Rows.Count.ToString());
            // this.dataDTResults.DataSource = table;
        }

        //Best nodes display
        private void update_BestNodes()
        {
            //Clear old values
            this.dataListBestNodes.DataSource = null;
            this.dataListBestNodes.Refresh();

            DataTable table = new DataTable("DTResults");
            List<String> Result_list = new List<string>();
            table.Columns.Add("Index");
            table.Columns.Add("Results");
            foreach (KeyValuePair<long, note_node> temp_node in BestNodes.get_all_notes())
            {
                table.Rows.Add(temp_node.Key, temp_node.Value.ToString());
            }

            Logging.Update_Status("DT Total Table Size = " + table.Rows.Count.ToString());
            this.dataListBestNodes.DataSource = table;

        }



        public Main_Form()
        {
            InitializeComponent();
            Self = this;
        }


        private void Main_Form_Load(object sender, EventArgs e)
        {
            //Testing Calls to work through the setup of DT, Arrangements etc..
            update_arrangement();
            //Set the last note in the collection to true
            MatchNotes.set_last_match();
            //cmdBuildDT_Click(sender, e);
            //cmdBuildDT2_Click(sender, e);
            //cmdCosts_Click(sender, e);
            // cmdCreateArrangemenets_Click(sender, e);
            //this.tabMain.SelectedIndex= 2;

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
            ICollection<MidiNotes> MidiObject = new List<MidiNotes>();


            int trackNumber;
            if (Int32.TryParse(txtTrackNumber.Text, out trackNumber))
                MidiControlObject.ConvertFile(filepath1, 1, trackNumber, MidiObject);  //Note track number 0 being used for the current file
            else
                throw new System.ArgumentException("Invalid Track Number.  Music be numeric", "Error");

            // Create the banjo object
            BanjoNotes banjoobject = new BanjoNotes(Convert.ToInt16(txtMaxFrets.Text));
            //Define the matches structure
            List<MatchNote> matches = new List<MatchNote>();


            //Get the last note position for arrangements
            MatchNotes.last_note_position = MidiObject.Last().position;

            int tempo = MidiControlObject.tempo;
            int timeSig1 = MidiControlObject.timesig1;
            int timeSig2 = MidiControlObject.timesig2;

            Arrangemenet_engine.original_note_count = MidiObject.Count();
            lblOriginalNotes.Text = Arrangemenet_engine.original_note_count.ToString();

            Logging.Update_Status("Starting arrangement Process");
            Logging.Update_Status("========================");
            Logging.Update_Status("Transpose Offset = " + txtTranspose.Text);
            Logging.Update_Status("Time Sig = " + timeSig1 + "/" + timeSig2);


            //Populate the matches 

            try
            {
                matches = MatchNotes.Find_Matching_Notes(MidiObject, banjoobject, Convert.ToInt16(txtTranspose.Text), Convert.ToInt16(txtMaxFrets.Text));
            }
            catch (Exception Ex)
            {
                Logging.Update_Status("Error processing matches");
                throw new System.ArgumentException("Error processing matches" + Ex.ToString());
            }

            //TODO All the stuff below is rubbish - General re-wite required for this + move out to a class
            foreach (MidiNotes temp in MidiObject)
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
            try
            {
                update_arrangement();
                Logging.Update_Status(MatchNotes.DT_size_projection().ToString());
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.ToString());
            }
        }



        private async void  cmdBuildDT_Click(object sender, EventArgs e)
        {
            Logging.Open_Dlg();
            //  try
            //  {


            //Create a new Decision Tree Object
            DTData_result.Clear();

            Logging.Update_Status("Starting DT Building Process");
            cts = new CancellationTokenSource();
            var ctoken = cts.Token;
            DTData_result = await Task.Run(() => DTController.Process_Route_Notes(MatchNotes.matchingresults, Convert.ToInt16(txtCostLimit.Text),ctoken),ctoken);
            Logging.Update_Status("Finished producing DT results");


            lblMatchingNotes.Text = MatchNotes.get_matching_note_count().ToString();

            // Write out the DT Results
            Logging.Update_Status("Writing " + DTData_result.Count + " to form");
            Logging.Update_Status("Finished DT Build, Updating Screen");

            //Call local method to update the forms DataGrid with the latest DT Results
            update_DTResults(DTData_result);

            Logging.Update_Status("DT calculation complete & form updated");

            //}
            //  catch (Exception ex)
            //  {
            //      MessageBox.Show("Error creating DT Tree:"+ex.ToString());
            // }
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
            Logging.Update_Status("Starting Arrangement");
            Arrangemenet_engine.create_arrangemnets(DecisionTree.get_all_nodes());
            Logging.Update_Status("Finished Arrangement Process");

            String tempStr = "";

            txtArrange.Text = null;
            txtArrange.Text = tempStr;

            dGridArrangements.DataSource = null;

            dGridArrangements.DataSource = Arrangemenet_engine.get_arrangemenets_sortable();



        }



        /*
         * Arrangement Code Section
         * 
         * 
         */

        public void Select_Arrangement()
        {
            //Return selected arrangement from Data Grid
            try
            {

                int SelectArrangement = Convert.ToInt32(this.dGridArrangements.SelectedRows[0].Cells[0].Value);

                txtSelectedArrangement.Text = SelectArrangement.ToString();

                Arrangement temp_arr = Arrangemenets.get_Arrangement(SelectArrangement);

                txtArrange.Text = temp_arr.ToString();
                //Write the Alpha Text to the Form for reference
                txtAlphaMarkup.Text = AlphaTabController.Build_AlphaText(temp_arr);
                //txtAlphaMarkup.Text = AlphaTabController.Example_Text;
                byte[] array = Encoding.ASCII.GetBytes(AlphaTabController.Build_AlphaText(temp_arr));
                //call method to render the Tab Creation

                //Create a new tab view form and pass the AlphaText to the control
                TabView TabForm = new TabView();
                TabForm.InternalOpenFile(array);
                TabForm.Show();

                //TODO - Set the Other Data Grid to the NoteNode values for the select arrangemenet
                int test;

                dGridArrCost.DataSource = temp_arr.get_arrange_notes_sortable();


            }
            catch
            {

                //Error if no line is selected
                //MessageBox.Show("You need to select a line");
            }

        }


        private void dGridArrangements_SelectionChanged(object sender, EventArgs e)
        {
            Select_Arrangement();

        }

        private void cmdCreateScore_Click(object sender, EventArgs e)
        {
            Select_Arrangement();
        }

    

        private void cmdRenderAlphaTab_Click(object sender, EventArgs e)
        {
            byte[] array = Encoding.ASCII.GetBytes(this.txtAlphaMarkup.Text);

            //Create a new tab view form and pass the AlphaText to the control
            TabView TabForm = new TabView();
            TabForm.InternalOpenFile(array);
            TabForm.Show();
        }

        private void cmdDTShow_Click(object sender, EventArgs e)
        {
            update_BestNodes();
        }

        private void cmdBestArrangements_Click(object sender, EventArgs e)
        {
            Logging.Update_Status("Starting Arrangement");

            Arrangemenet_Best_engine.create_arrangemnets(DecisionTree.get_all_nodes(), 0);
            Logging.Update_Status("Finished Arrangement Process");

            String tempStr = "";

            txtArrange.Text = null;
            txtArrange.Text = tempStr;

            dGridArrangements.DataSource = null;

            dGridArrangements.DataSource = Arrangemenet_engine.get_arrangemenets_sortable();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }


        //Logging related code
        public void Update_Status(String strMessage)
        {
            if (txtUpdate.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Update_Status);
                this.Invoke(d, new object[] { strMessage });
            }
            else
            { 
                txtUpdate.Text += DateTime.Now.ToString() + " -  " + strMessage + "\r\n";
                this.Refresh();
                txtUpdate.SelectionStart = txtUpdate.Text.Length;
                txtUpdate.ScrollToCaret();
            }
            
        }

        public void Update_Note_Position(String strMessage)
        {
            if (this.txtUpdate.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Update_Note_Position);
                this.Invoke(d, new object[] { strMessage });
            }
            else
            {
                this.txtCurrentNotePosition.Text = strMessage;
                this.Refresh();
            }



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private async void cmdBuildDT2_Click(object sender, EventArgs e)
        {
            Logging.Open_Dlg();
            //  try
            //  {


            //Create a new Decision Tree Object
            DTData_result.Clear();

            Logging.Update_Status("Starting DT Building Process");
            cts = new CancellationTokenSource();
            var ctoken = cts.Token;
            DTData_result = await Task.Run(() => DTController2.Process_Route_Notes(MatchNotes.matchingresults, Convert.ToInt16(txtCostLimit.Text), ctoken), ctoken);
            Logging.Update_Status("Finished producing DT results");


            lblMatchingNotes.Text = MatchNotes.get_matching_note_count().ToString();

            // Write out the DT Results
            Logging.Update_Status("Writing " + DTData_result.Count + " to form");
            Logging.Update_Status("Finished DT Build, Updating Screen");

            //Call local method to update the forms DataGrid with the latest DT Results
            update_DTResults(DTData_result);

            Logging.Update_Status("DT calculation complete & form updated");

            //}
            //  catch (Exception ex)
            //  {
            //      MessageBox.Show("Error creating DT Tree:"+ex.ToString());
            // }
        }
    }
}



