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
            this.cmdBuildDT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdCreateDTGraph = new System.Windows.Forms.Button();
            this.cmdCosts = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdCheckTree = new System.Windows.Forms.Button();
            this.cmdCreateArrangemenets = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataDTResults = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTrackNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtArrange = new System.Windows.Forms.TextBox();
            this.dGridArrangements = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMatchingNotes = new System.Windows.Forms.Label();
            this.lblOriginalNotes = new System.Windows.Forms.Label();
            this.cmdCreateScore = new System.Windows.Forms.Button();
            this.alphaTabControl1 = new AlphaTab.Platform.CSharp.WinForms.AlphaTabControl();
            this.txtSelectedArrangement = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDTResults)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridArrangements)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(18, 33);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(465, 299);
            this.txtNotes.TabIndex = 0;
            // 
            // txtNoteMatch
            // 
            this.txtNoteMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteMatch.Location = new System.Drawing.Point(18, 340);
            this.txtNoteMatch.Multiline = true;
            this.txtNoteMatch.Name = "txtNoteMatch";
            this.txtNoteMatch.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNoteMatch.Size = new System.Drawing.Size(528, 253);
            this.txtNoteMatch.TabIndex = 2;
            // 
            // cmdArrange
            // 
            this.cmdArrange.Location = new System.Drawing.Point(806, 350);
            this.cmdArrange.Name = "cmdArrange";
            this.cmdArrange.Size = new System.Drawing.Size(145, 23);
            this.cmdArrange.TabIndex = 4;
            this.cmdArrange.Text = "Re-Arrange";
            this.cmdArrange.UseVisualStyleBackColor = true;
            this.cmdArrange.Click += new System.EventHandler(this.cmdArrange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Original Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mappings";
            // 
            // txtTranspose
            // 
            this.txtTranspose.Location = new System.Drawing.Point(768, 473);
            this.txtTranspose.Name = "txtTranspose";
            this.txtTranspose.Size = new System.Drawing.Size(100, 20);
            this.txtTranspose.TabIndex = 9;
            this.txtTranspose.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 246);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 117);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Banjo Tuning Notes\r\n\r\n4)  D4 = 62\r\n3)  B3 = 59\r\n2)  G3 = 55\r\n1)  C3 = 48\r\n0)  G4 " +
    "= 67 ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(882, 190);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Semitones Transposed";
            // 
            // cmdBuildDT
            // 
            this.cmdBuildDT.Location = new System.Drawing.Point(639, 350);
            this.cmdBuildDT.Name = "cmdBuildDT";
            this.cmdBuildDT.Size = new System.Drawing.Size(145, 23);
            this.cmdBuildDT.TabIndex = 15;
            this.cmdBuildDT.Text = "Build DT";
            this.cmdBuildDT.UseVisualStyleBackColor = true;
            this.cmdBuildDT.Click += new System.EventHandler(this.cmdBuildDT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "DT Results";
            // 
            // cmdCreateDTGraph
            // 
            this.cmdCreateDTGraph.Location = new System.Drawing.Point(806, 419);
            this.cmdCreateDTGraph.Name = "cmdCreateDTGraph";
            this.cmdCreateDTGraph.Size = new System.Drawing.Size(145, 23);
            this.cmdCreateDTGraph.TabIndex = 18;
            this.cmdCreateDTGraph.Text = "Create DT Graph";
            this.cmdCreateDTGraph.UseVisualStyleBackColor = true;
            this.cmdCreateDTGraph.Click += new System.EventHandler(this.cmdCreateDTGraph_Click);
            // 
            // cmdCosts
            // 
            this.cmdCosts.Location = new System.Drawing.Point(639, 379);
            this.cmdCosts.Name = "cmdCosts";
            this.cmdCosts.Size = new System.Drawing.Size(145, 23);
            this.cmdCosts.TabIndex = 19;
            this.cmdCosts.Text = "Calculate Costs";
            this.cmdCosts.UseVisualStyleBackColor = true;
            this.cmdCosts.Click += new System.EventHandler(this.cmdCosts_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(768, 499);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(325, 20);
            this.txtFileName.TabIndex = 20;
            this.txtFileName.Text = "Dance1.mid";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmdCheckTree
            // 
            this.cmdCheckTree.Location = new System.Drawing.Point(998, 350);
            this.cmdCheckTree.Name = "cmdCheckTree";
            this.cmdCheckTree.Size = new System.Drawing.Size(147, 23);
            this.cmdCheckTree.TabIndex = 21;
            this.cmdCheckTree.Text = "Check Tree";
            this.cmdCheckTree.UseVisualStyleBackColor = true;
            this.cmdCheckTree.Click += new System.EventHandler(this.cmdCheckTree_Click);
            // 
            // cmdCreateArrangemenets
            // 
            this.cmdCreateArrangemenets.Location = new System.Drawing.Point(639, 419);
            this.cmdCreateArrangemenets.Name = "cmdCreateArrangemenets";
            this.cmdCreateArrangemenets.Size = new System.Drawing.Size(145, 23);
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
            this.tabMain.Location = new System.Drawing.Point(12, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1503, 860);
            this.tabMain.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblOriginalNotes);
            this.tabPage1.Controls.Add(this.lblMatchingNotes);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataDTResults);
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
            this.tabPage1.Controls.Add(this.cmdBuildDT);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmdCosts);
            this.tabPage1.Controls.Add(this.txtNoteMatch);
            this.tabPage1.Controls.Add(this.cmdCreateDTGraph);
            this.tabPage1.Controls.Add(this.cmdArrange);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1495, 834);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Initial Stuff";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataDTResults
            // 
            this.dataDTResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDTResults.Location = new System.Drawing.Point(489, 33);
            this.dataDTResults.Name = "dataDTResults";
            this.dataDTResults.Size = new System.Drawing.Size(826, 299);
            this.dataDTResults.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(639, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Midi Track Number";
            // 
            // txtTrackNumber
            // 
            this.txtTrackNumber.Location = new System.Drawing.Point(768, 525);
            this.txtTrackNumber.Name = "txtTrackNumber";
            this.txtTrackNumber.Size = new System.Drawing.Size(100, 20);
            this.txtTrackNumber.TabIndex = 24;
            this.txtTrackNumber.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Filename";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1495, 834);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reference";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtSelectedArrangement);
            this.tabPage3.Controls.Add(this.alphaTabControl1);
            this.tabPage3.Controls.Add(this.cmdCreateScore);
            this.tabPage3.Controls.Add(this.txtArrange);
            this.tabPage3.Controls.Add(this.dGridArrangements);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1495, 834);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Arrangemenets";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtArrange
            // 
            this.txtArrange.Location = new System.Drawing.Point(872, 21);
            this.txtArrange.Multiline = true;
            this.txtArrange.Name = "txtArrange";
            this.txtArrange.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArrange.Size = new System.Drawing.Size(443, 141);
            this.txtArrange.TabIndex = 1;
            // 
            // dGridArrangements
            // 
            this.dGridArrangements.AllowUserToOrderColumns = true;
            this.dGridArrangements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridArrangements.Location = new System.Drawing.Point(13, 21);
            this.dGridArrangements.Name = "dGridArrangements";
            this.dGridArrangements.Size = new System.Drawing.Size(835, 292);
            this.dGridArrangements.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Current Matching Stats";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 646);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "#Matching Notes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 669);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "#Original Notes";
            // 
            // lblMatchingNotes
            // 
            this.lblMatchingNotes.AutoSize = true;
            this.lblMatchingNotes.Location = new System.Drawing.Point(114, 646);
            this.lblMatchingNotes.Name = "lblMatchingNotes";
            this.lblMatchingNotes.Size = new System.Drawing.Size(41, 13);
            this.lblMatchingNotes.TabIndex = 30;
            this.lblMatchingNotes.Text = "label10";
            // 
            // lblOriginalNotes
            // 
            this.lblOriginalNotes.AutoSize = true;
            this.lblOriginalNotes.Location = new System.Drawing.Point(114, 669);
            this.lblOriginalNotes.Name = "lblOriginalNotes";
            this.lblOriginalNotes.Size = new System.Drawing.Size(41, 13);
            this.lblOriginalNotes.TabIndex = 31;
            this.lblOriginalNotes.Text = "label11";
            // 
            // cmdCreateScore
            // 
            this.cmdCreateScore.Location = new System.Drawing.Point(872, 180);
            this.cmdCreateScore.Name = "cmdCreateScore";
            this.cmdCreateScore.Size = new System.Drawing.Size(187, 23);
            this.cmdCreateScore.TabIndex = 2;
            this.cmdCreateScore.Text = "Create Score";
            this.cmdCreateScore.UseVisualStyleBackColor = true;
            this.cmdCreateScore.Click += new System.EventHandler(this.cmdCreateScore_Click);
            // 
            // alphaTabControl1
            // 
            this.alphaTabControl1.Location = new System.Drawing.Point(13, 319);
            this.alphaTabControl1.Name = "alphaTabControl1";
            this.alphaTabControl1.Size = new System.Drawing.Size(1294, 487);
            this.alphaTabControl1.TabIndex = 3;
            this.alphaTabControl1.Text = "alphaTabControl1";
            this.alphaTabControl1.Track = null;
            // 
            // txtSelectedArrangement
            // 
            this.txtSelectedArrangement.Location = new System.Drawing.Point(872, 210);
            this.txtSelectedArrangement.Name = "txtSelectedArrangement";
            this.txtSelectedArrangement.Size = new System.Drawing.Size(390, 20);
            this.txtSelectedArrangement.TabIndex = 4;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 903);
            this.Controls.Add(this.tabMain);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Melodic Banjo Arranger";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDTResults)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridArrangements)).EndInit();
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
        private System.Windows.Forms.Button cmdBuildDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdCreateDTGraph;
        private System.Windows.Forms.Button cmdCosts;
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
        private System.Windows.Forms.DataGridView dataDTResults;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOriginalNotes;
        private System.Windows.Forms.Label lblMatchingNotes;
        private System.Windows.Forms.Button cmdCreateScore;
        private System.Windows.Forms.TextBox txtSelectedArrangement;
        private AlphaTab.Platform.CSharp.WinForms.AlphaTabControl alphaTabControl1;
    }
}

