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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTranspose = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdBuildDT = new System.Windows.Forms.Button();
            this.txtDTResults = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdCreateDTGraph = new System.Windows.Forms.Button();
            this.cmdCosts = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(15, 41);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(465, 299);
            this.txtNotes.TabIndex = 0;
            // 
            // txtNoteMatch
            // 
            this.txtNoteMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteMatch.Location = new System.Drawing.Point(15, 342);
            this.txtNoteMatch.Multiline = true;
            this.txtNoteMatch.Name = "txtNoteMatch";
            this.txtNoteMatch.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNoteMatch.Size = new System.Drawing.Size(528, 253);
            this.txtNoteMatch.TabIndex = 2;
            // 
            // cmdArrange
            // 
            this.cmdArrange.Location = new System.Drawing.Point(890, 599);
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
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Original Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mappings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status";
            // 
            // txtTranspose
            // 
            this.txtTranspose.Location = new System.Drawing.Point(1008, 576);
            this.txtTranspose.Name = "txtTranspose";
            this.txtTranspose.Size = new System.Drawing.Size(100, 20);
            this.txtTranspose.TabIndex = 9;
            this.txtTranspose.Text = "10";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(12, 625);
            this.txtUpdate.Multiline = true;
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUpdate.Size = new System.Drawing.Size(800, 159);
            this.txtUpdate.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1243, 734);
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
            this.pictureBox1.Location = new System.Drawing.Point(606, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(882, 190);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(887, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Semitones Transposed";
            // 
            // cmdBuildDT
            // 
            this.cmdBuildDT.Location = new System.Drawing.Point(1111, 598);
            this.cmdBuildDT.Name = "cmdBuildDT";
            this.cmdBuildDT.Size = new System.Drawing.Size(75, 23);
            this.cmdBuildDT.TabIndex = 15;
            this.cmdBuildDT.Text = "Build DT";
            this.cmdBuildDT.UseVisualStyleBackColor = true;
            this.cmdBuildDT.Click += new System.EventHandler(this.cmdBuildDT_Click);
            // 
            // txtDTResults
            // 
            this.txtDTResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDTResults.Location = new System.Drawing.Point(486, 41);
            this.txtDTResults.Multiline = true;
            this.txtDTResults.Name = "txtDTResults";
            this.txtDTResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDTResults.Size = new System.Drawing.Size(1028, 299);
            this.txtDTResults.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "DT Results";
            // 
            // cmdCreateDTGraph
            // 
            this.cmdCreateDTGraph.Location = new System.Drawing.Point(890, 641);
            this.cmdCreateDTGraph.Name = "cmdCreateDTGraph";
            this.cmdCreateDTGraph.Size = new System.Drawing.Size(145, 23);
            this.cmdCreateDTGraph.TabIndex = 18;
            this.cmdCreateDTGraph.Text = "Create DT Graph";
            this.cmdCreateDTGraph.UseVisualStyleBackColor = true;
            this.cmdCreateDTGraph.Click += new System.EventHandler(this.cmdCreateDTGraph_Click);
            // 
            // cmdCosts
            // 
            this.cmdCosts.Location = new System.Drawing.Point(890, 671);
            this.cmdCosts.Name = "cmdCosts";
            this.cmdCosts.Size = new System.Drawing.Size(145, 23);
            this.cmdCosts.TabIndex = 19;
            this.cmdCosts.Text = "Calculate Costs";
            this.cmdCosts.UseVisualStyleBackColor = true;
            this.cmdCosts.Click += new System.EventHandler(this.cmdCosts_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(15, 808);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(465, 20);
            this.txtFileName.TabIndex = 20;
            this.txtFileName.Text = "bwv772.2.mid";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 903);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.cmdCosts);
            this.Controls.Add(this.cmdCreateDTGraph);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDTResults);
            this.Controls.Add(this.cmdBuildDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.txtTranspose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdArrange);
            this.Controls.Add(this.txtNoteMatch);
            this.Controls.Add(this.txtNotes);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Melodic Banjo Arranger";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtNoteMatch;
        private System.Windows.Forms.Button cmdArrange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTranspose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdBuildDT;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDTResults;
        private System.Windows.Forms.Button cmdCreateDTGraph;
        private System.Windows.Forms.Button cmdCosts;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}

