using System;
using System.Windows.Forms;

namespace MelodicBanjoArranger
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtNoteMatch = new System.Windows.Forms.TextBox();
            this.cmdArrange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTranspose = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdCreateDTGraph = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdCheckTree = new System.Windows.Forms.Button();
            this.cmdCreateArrangemenets = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkAutoTrans = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEndNodePerStart = new System.Windows.Forms.TextBox();
            this.cmdBuildDT2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCurrentNotePosition = new System.Windows.Forms.TextBox();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.cmdStopDT = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaxFrets = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCostLimit = new System.Windows.Forms.TextBox();
            this.cmdBestArrangements = new System.Windows.Forms.Button();
            this.lblOriginalNotes = new System.Windows.Forms.Label();
            this.lblMatchingNotes = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTrackNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dGridArrCost = new System.Windows.Forms.DataGridView();
            this.cmdRenderAlphaTab = new System.Windows.Forms.Button();
            this.txtAlphaMarkup = new System.Windows.Forms.TextBox();
            this.txtSelectedArrangement = new System.Windows.Forms.TextBox();
            this.cmdCreateScore = new System.Windows.Forms.Button();
            this.txtArrange = new System.Windows.Forms.TextBox();
            this.dGridArrangements = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataListBestNodes = new System.Windows.Forms.DataGridView();
            this.cmdListBest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridArrCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridArrangements)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListBestNodes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(42, 74);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(7);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(1080, 662);
            this.txtNotes.TabIndex = 0;
            // 
            // txtNoteMatch
            // 
            this.txtNoteMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteMatch.Location = new System.Drawing.Point(42, 758);
            this.txtNoteMatch.Margin = new System.Windows.Forms.Padding(7);
            this.txtNoteMatch.Multiline = true;
            this.txtNoteMatch.Name = "txtNoteMatch";
            this.txtNoteMatch.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNoteMatch.Size = new System.Drawing.Size(1227, 559);
            this.txtNoteMatch.TabIndex = 2;
            // 
            // cmdArrange
            // 
            this.cmdArrange.Location = new System.Drawing.Point(1489, 870);
            this.cmdArrange.Margin = new System.Windows.Forms.Padding(7);
            this.cmdArrange.Name = "cmdArrange";
            this.cmdArrange.Size = new System.Drawing.Size(292, 51);
            this.cmdArrange.TabIndex = 4;
            this.cmdArrange.Text = "Re-Arrange";
            this.cmdArrange.UseVisualStyleBackColor = true;
            this.cmdArrange.Click += new System.EventHandler(this.cmdArrange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Original Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mappings";
            // 
            // txtTranspose
            // 
            this.txtTranspose.Location = new System.Drawing.Point(1792, 1171);
            this.txtTranspose.Margin = new System.Windows.Forms.Padding(7);
            this.txtTranspose.Name = "txtTranspose";
            this.txtTranspose.Size = new System.Drawing.Size(228, 35);
            this.txtTranspose.TabIndex = 9;
            this.txtTranspose.Text = "-12";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(92, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 549);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(629, 256);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Banjo Tuning Notes\r\n\r\n4)  D4 = 62\r\n3)  B3 = 59\r\n2)  G3 = 55\r\n1)  C3 = 48\r\n0)  G4 " +
    "= 67 ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2058, 424);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1484, 1171);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Semitones Transposed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1188, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Process Log";
            // 
            // cmdCreateDTGraph
            // 
            this.cmdCreateDTGraph.Location = new System.Drawing.Point(2014, 781);
            this.cmdCreateDTGraph.Margin = new System.Windows.Forms.Padding(7);
            this.cmdCreateDTGraph.Name = "cmdCreateDTGraph";
            this.cmdCreateDTGraph.Size = new System.Drawing.Size(278, 51);
            this.cmdCreateDTGraph.TabIndex = 18;
            this.cmdCreateDTGraph.Text = "Create DT Graph";
            this.cmdCreateDTGraph.UseVisualStyleBackColor = true;
            this.cmdCreateDTGraph.Click += new System.EventHandler(this.cmdCreateDTGraph_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(1792, 1229);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(7);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(753, 35);
            this.txtFileName.TabIndex = 20;
            this.txtFileName.Text = "bwv772.mid";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmdCheckTree
            // 
            this.cmdCheckTree.Location = new System.Drawing.Point(2329, 781);
            this.cmdCheckTree.Margin = new System.Windows.Forms.Padding(7);
            this.cmdCheckTree.Name = "cmdCheckTree";
            this.cmdCheckTree.Size = new System.Drawing.Size(343, 51);
            this.cmdCheckTree.TabIndex = 21;
            this.cmdCheckTree.Text = "Check Tree";
            this.cmdCheckTree.UseVisualStyleBackColor = true;
            this.cmdCheckTree.Click += new System.EventHandler(this.cmdCheckTree_Click);
            // 
            // cmdCreateArrangemenets
            // 
            this.cmdCreateArrangemenets.Location = new System.Drawing.Point(1492, 1000);
            this.cmdCreateArrangemenets.Margin = new System.Windows.Forms.Padding(7);
            this.cmdCreateArrangemenets.Name = "cmdCreateArrangemenets";
            this.cmdCreateArrangemenets.Size = new System.Drawing.Size(289, 51);
            this.cmdCreateArrangemenets.TabIndex = 22;
            this.cmdCreateArrangemenets.Text = "Create Arrangemenets";
            this.cmdCreateArrangemenets.UseVisualStyleBackColor = true;
            this.cmdCreateArrangemenets.Click += new System.EventHandler(this.cmdCreateArrangemenets_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Controls.Add(this.tabPage4);
            this.tabMain.Location = new System.Drawing.Point(28, 7);
            this.tabMain.Margin = new System.Windows.Forms.Padding(7);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(3085, 2260);
            this.tabMain.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkAutoTrans);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtEndNodePerStart);
            this.tabPage1.Controls.Add(this.cmdBuildDT2);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtCurrentNotePosition);
            this.tabPage1.Controls.Add(this.txtUpdate);
            this.tabPage1.Controls.Add(this.cmdStopDT);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtMaxFrets);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtCostLimit);
            this.tabPage1.Controls.Add(this.cmdBestArrangements);
            this.tabPage1.Controls.Add(this.lblOriginalNotes);
            this.tabPage1.Controls.Add(this.lblMatchingNotes);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtTrackNumber);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtNotes);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtFileName);
            this.tabPage1.Controls.Add(this.cmdCheckTree);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmdCreateArrangemenets);
            this.tabPage1.Controls.Add(this.txtTranspose);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNoteMatch);
            this.tabPage1.Controls.Add(this.cmdCreateDTGraph);
            this.tabPage1.Controls.Add(this.cmdArrange);
            this.tabPage1.Location = new System.Drawing.Point(10, 47);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(7);
            this.tabPage1.Size = new System.Drawing.Size(3065, 2203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Initial Stuff";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // chkAutoTrans
            // 
            this.chkAutoTrans.AutoSize = true;
            this.chkAutoTrans.Checked = true;
            this.chkAutoTrans.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoTrans.Location = new System.Drawing.Point(1489, 810);
            this.chkAutoTrans.Name = "chkAutoTrans";
            this.chkAutoTrans.Size = new System.Drawing.Size(353, 33);
            this.chkAutoTrans.TabIndex = 45;
            this.chkAutoTrans.Text = "Auto Transpose Out of range";
            this.chkAutoTrans.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1876, 1041);
            this.label14.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(416, 29);
            this.label14.TabIndex = 44;
            this.label14.Text = "Num of Finished nodes per start node";
            // 
            // txtEndNodePerStart
            // 
            this.txtEndNodePerStart.Location = new System.Drawing.Point(2317, 1035);
            this.txtEndNodePerStart.Margin = new System.Windows.Forms.Padding(7);
            this.txtEndNodePerStart.Name = "txtEndNodePerStart";
            this.txtEndNodePerStart.Size = new System.Drawing.Size(228, 35);
            this.txtEndNodePerStart.TabIndex = 43;
            this.txtEndNodePerStart.Text = "10";
            // 
            // cmdBuildDT2
            // 
            this.cmdBuildDT2.Location = new System.Drawing.Point(1489, 935);
            this.cmdBuildDT2.Margin = new System.Windows.Forms.Padding(7);
            this.cmdBuildDT2.Name = "cmdBuildDT2";
            this.cmdBuildDT2.Size = new System.Drawing.Size(205, 51);
            this.cmdBuildDT2.TabIndex = 42;
            this.cmdBuildDT2.Text = "Build DT v2";
            this.cmdBuildDT2.UseVisualStyleBackColor = true;
            this.cmdBuildDT2.Click += new System.EventHandler(this.cmdBuildDT2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1449, 1379);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 29);
            this.label13.TabIndex = 41;
            this.label13.Text = "Processing Details:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1449, 1434);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 29);
            this.label12.TabIndex = 40;
            this.label12.Text = "Note Position";
            // 
            // txtCurrentNotePosition
            // 
            this.txtCurrentNotePosition.Location = new System.Drawing.Point(1792, 1434);
            this.txtCurrentNotePosition.Margin = new System.Windows.Forms.Padding(7);
            this.txtCurrentNotePosition.Name = "txtCurrentNotePosition";
            this.txtCurrentNotePosition.Size = new System.Drawing.Size(513, 35);
            this.txtCurrentNotePosition.TabIndex = 39;
            // 
            // txtUpdate
            // 
            this.txtUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdate.Location = new System.Drawing.Point(1181, 78);
            this.txtUpdate.Margin = new System.Windows.Forms.Padding(7);
            this.txtUpdate.Multiline = true;
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUpdate.Size = new System.Drawing.Size(1486, 662);
            this.txtUpdate.TabIndex = 38;
            // 
            // cmdStopDT
            // 
            this.cmdStopDT.Location = new System.Drawing.Point(2317, 1084);
            this.cmdStopDT.Margin = new System.Windows.Forms.Padding(7);
            this.cmdStopDT.Name = "cmdStopDT";
            this.cmdStopDT.Size = new System.Drawing.Size(175, 83);
            this.cmdStopDT.TabIndex = 37;
            this.cmdStopDT.Text = "Stop Processing";
            this.cmdStopDT.UseVisualStyleBackColor = true;
            this.cmdStopDT.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2014, 930);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 29);
            this.label11.TabIndex = 36;
            this.label11.Text = "Max fret";
            // 
            // txtMaxFrets
            // 
            this.txtMaxFrets.Location = new System.Drawing.Point(2317, 924);
            this.txtMaxFrets.Margin = new System.Windows.Forms.Padding(7);
            this.txtMaxFrets.Name = "txtMaxFrets";
            this.txtMaxFrets.Size = new System.Drawing.Size(228, 35);
            this.txtMaxFrets.TabIndex = 35;
            this.txtMaxFrets.Text = "20";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2014, 988);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 29);
            this.label10.TabIndex = 34;
            this.label10.Text = "DT Cost Limit";
            // 
            // txtCostLimit
            // 
            this.txtCostLimit.Location = new System.Drawing.Point(2317, 975);
            this.txtCostLimit.Margin = new System.Windows.Forms.Padding(7);
            this.txtCostLimit.Name = "txtCostLimit";
            this.txtCostLimit.Size = new System.Drawing.Size(228, 35);
            this.txtCostLimit.TabIndex = 33;
            this.txtCostLimit.Text = "2";
            // 
            // cmdBestArrangements
            // 
            this.cmdBestArrangements.Location = new System.Drawing.Point(1489, 1065);
            this.cmdBestArrangements.Margin = new System.Windows.Forms.Padding(7);
            this.cmdBestArrangements.Name = "cmdBestArrangements";
            this.cmdBestArrangements.Size = new System.Drawing.Size(289, 78);
            this.cmdBestArrangements.TabIndex = 32;
            this.cmdBestArrangements.Text = "Create Best Arrangemenets";
            this.cmdBestArrangements.UseVisualStyleBackColor = true;
            this.cmdBestArrangements.Click += new System.EventHandler(this.cmdBestArrangements_Click);
            // 
            // lblOriginalNotes
            // 
            this.lblOriginalNotes.AutoSize = true;
            this.lblOriginalNotes.Location = new System.Drawing.Point(266, 1492);
            this.lblOriginalNotes.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblOriginalNotes.Name = "lblOriginalNotes";
            this.lblOriginalNotes.Size = new System.Drawing.Size(0, 29);
            this.lblOriginalNotes.TabIndex = 31;
            // 
            // lblMatchingNotes
            // 
            this.lblMatchingNotes.AutoSize = true;
            this.lblMatchingNotes.Location = new System.Drawing.Point(266, 1441);
            this.lblMatchingNotes.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMatchingNotes.Name = "lblMatchingNotes";
            this.lblMatchingNotes.Size = new System.Drawing.Size(92, 29);
            this.lblMatchingNotes.TabIndex = 30;
            this.lblMatchingNotes.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 1492);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 29);
            this.label9.TabIndex = 29;
            this.label9.Text = "#Original Notes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 1441);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 29);
            this.label8.TabIndex = 28;
            this.label8.Text = "#Matching Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 1379);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Current Matching Stats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1491, 1287);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Midi Track Number";
            // 
            // txtTrackNumber
            // 
            this.txtTrackNumber.Location = new System.Drawing.Point(1792, 1287);
            this.txtTrackNumber.Margin = new System.Windows.Forms.Padding(7);
            this.txtTrackNumber.Name = "txtTrackNumber";
            this.txtTrackNumber.Size = new System.Drawing.Size(228, 35);
            this.txtTrackNumber.TabIndex = 24;
            this.txtTrackNumber.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1484, 1229);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Filename";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(10, 47);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(7);
            this.tabPage2.Size = new System.Drawing.Size(3065, 2203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reference";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dGridArrCost);
            this.tabPage3.Controls.Add(this.cmdRenderAlphaTab);
            this.tabPage3.Controls.Add(this.txtAlphaMarkup);
            this.tabPage3.Controls.Add(this.txtSelectedArrangement);
            this.tabPage3.Controls.Add(this.cmdCreateScore);
            this.tabPage3.Controls.Add(this.txtArrange);
            this.tabPage3.Controls.Add(this.dGridArrangements);
            this.tabPage3.Location = new System.Drawing.Point(10, 47);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(7);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(3065, 2203);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Arrangemenets";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dGridArrCost
            // 
            this.dGridArrCost.AllowUserToOrderColumns = true;
            this.dGridArrCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridArrCost.Location = new System.Drawing.Point(30, 712);
            this.dGridArrCost.Margin = new System.Windows.Forms.Padding(7);
            this.dGridArrCost.Name = "dGridArrCost";
            this.dGridArrCost.Size = new System.Drawing.Size(2991, 892);
            this.dGridArrCost.TabIndex = 7;
            // 
            // cmdRenderAlphaTab
            // 
            this.cmdRenderAlphaTab.Location = new System.Drawing.Point(1969, 281);
            this.cmdRenderAlphaTab.Margin = new System.Windows.Forms.Padding(7);
            this.cmdRenderAlphaTab.Name = "cmdRenderAlphaTab";
            this.cmdRenderAlphaTab.Size = new System.Drawing.Size(404, 51);
            this.cmdRenderAlphaTab.TabIndex = 6;
            this.cmdRenderAlphaTab.Text = "Render AlphaTab";
            this.cmdRenderAlphaTab.UseVisualStyleBackColor = true;
            this.cmdRenderAlphaTab.Click += new System.EventHandler(this.cmdRenderAlphaTab_Click);
            // 
            // txtAlphaMarkup
            // 
            this.txtAlphaMarkup.Location = new System.Drawing.Point(1668, 373);
            this.txtAlphaMarkup.Margin = new System.Windows.Forms.Padding(7);
            this.txtAlphaMarkup.Multiline = true;
            this.txtAlphaMarkup.Name = "txtAlphaMarkup";
            this.txtAlphaMarkup.Size = new System.Drawing.Size(1348, 292);
            this.txtAlphaMarkup.TabIndex = 5;
            // 
            // txtSelectedArrangement
            // 
            this.txtSelectedArrangement.Location = new System.Drawing.Point(2770, 288);
            this.txtSelectedArrangement.Margin = new System.Windows.Forms.Padding(7);
            this.txtSelectedArrangement.Name = "txtSelectedArrangement";
            this.txtSelectedArrangement.Size = new System.Drawing.Size(247, 35);
            this.txtSelectedArrangement.TabIndex = 4;
            // 
            // cmdCreateScore
            // 
            this.cmdCreateScore.Location = new System.Drawing.Point(1652, 281);
            this.cmdCreateScore.Margin = new System.Windows.Forms.Padding(7);
            this.cmdCreateScore.Name = "cmdCreateScore";
            this.cmdCreateScore.Size = new System.Drawing.Size(303, 51);
            this.cmdCreateScore.TabIndex = 2;
            this.cmdCreateScore.Text = "Create AlphaText";
            this.cmdCreateScore.UseVisualStyleBackColor = true;
            this.cmdCreateScore.Click += new System.EventHandler(this.cmdCreateScore_Click);
            // 
            // txtArrange
            // 
            this.txtArrange.Location = new System.Drawing.Point(1652, 47);
            this.txtArrange.Margin = new System.Windows.Forms.Padding(7);
            this.txtArrange.Multiline = true;
            this.txtArrange.Name = "txtArrange";
            this.txtArrange.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArrange.Size = new System.Drawing.Size(1028, 216);
            this.txtArrange.TabIndex = 1;
            // 
            // dGridArrangements
            // 
            this.dGridArrangements.AllowUserToOrderColumns = true;
            this.dGridArrangements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridArrangements.Location = new System.Drawing.Point(30, 47);
            this.dGridArrangements.Margin = new System.Windows.Forms.Padding(7);
            this.dGridArrangements.Name = "dGridArrangements";
            this.dGridArrangements.Size = new System.Drawing.Size(1615, 651);
            this.dGridArrangements.TabIndex = 0;
            this.dGridArrangements.SelectionChanged += new System.EventHandler(this.dGridArrangements_SelectionChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataListBestNodes);
            this.tabPage4.Controls.Add(this.cmdListBest);
            this.tabPage4.Location = new System.Drawing.Point(10, 47);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(7);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(7);
            this.tabPage4.Size = new System.Drawing.Size(3065, 2203);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "DT Listing";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataListBestNodes
            // 
            this.dataListBestNodes.AllowUserToOrderColumns = true;
            this.dataListBestNodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListBestNodes.Location = new System.Drawing.Point(14, 13);
            this.dataListBestNodes.Margin = new System.Windows.Forms.Padding(7);
            this.dataListBestNodes.Name = "dataListBestNodes";
            this.dataListBestNodes.Size = new System.Drawing.Size(3127, 1321);
            this.dataListBestNodes.TabIndex = 2;
            // 
            // cmdListBest
            // 
            this.cmdListBest.Location = new System.Drawing.Point(7, 1347);
            this.cmdListBest.Margin = new System.Windows.Forms.Padding(7);
            this.cmdListBest.Name = "cmdListBest";
            this.cmdListBest.Size = new System.Drawing.Size(175, 51);
            this.cmdListBest.TabIndex = 1;
            this.cmdListBest.Text = "Show Best Nodes";
            this.cmdListBest.UseVisualStyleBackColor = true;
            this.cmdListBest.Click += new System.EventHandler(this.cmdDTShow_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2722, 1749);
            this.Controls.Add(this.tabMain);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Melodic Banjo Arranger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridArrCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridArrangements)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListBestNodes)).EndInit();
            this.ResumeLayout(false);

        }

   

        #endregion

        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtNoteMatch;
        private System.Windows.Forms.Button cmdArrange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTranspose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdCreateDTGraph;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button cmdCheckTree;
        private System.Windows.Forms.Button cmdCreateArrangemenets;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtArrange;
        private System.Windows.Forms.DataGridView dGridArrangements;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTrackNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOriginalNotes;
        private System.Windows.Forms.Label lblMatchingNotes;
        private System.Windows.Forms.Button cmdCreateScore;
        private System.Windows.Forms.TextBox txtSelectedArrangement;
        private System.Windows.Forms.TextBox txtAlphaMarkup;
        private System.Windows.Forms.Button cmdRenderAlphaTab;
        private DataGridView dGridArrCost;
        private TabPage tabPage4;
        private Button cmdListBest;
        private DataGridView dataListBestNodes;
        private Button cmdBestArrangements;
        private TextBox txtCostLimit;
        private Label label11;
        private TextBox txtMaxFrets;
        private Label label10;
        private Button cmdStopDT;
        private TextBox txtUpdate;
        private Label label13;
        private Label label12;
        private TextBox txtCurrentNotePosition;
        private Button cmdBuildDT2;
        private Label label14;
        private TextBox txtEndNodePerStart;
        private CheckBox chkAutoTrans;
    }
}

