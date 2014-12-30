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
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.musicPanel = new System.Windows.Forms.Panel();
            this.txtNoteMatch = new System.Windows.Forms.TextBox();
            this.cmbOctive = new System.Windows.Forms.ComboBox();
            this.cmdArrange = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(15, 41);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatus.Size = new System.Drawing.Size(284, 554);
            this.txtStatus.TabIndex = 0;
            // 
            // musicPanel
            // 
            this.musicPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.musicPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.musicPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.musicPanel.Location = new System.Drawing.Point(782, 41);
            this.musicPanel.Name = "musicPanel";
            this.musicPanel.Size = new System.Drawing.Size(695, 554);
            this.musicPanel.TabIndex = 1;
            this.musicPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.musicPanel_Paint);
            // 
            // txtNoteMatch
            // 
            this.txtNoteMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteMatch.Location = new System.Drawing.Point(305, 41);
            this.txtNoteMatch.Multiline = true;
            this.txtNoteMatch.Name = "txtNoteMatch";
            this.txtNoteMatch.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNoteMatch.Size = new System.Drawing.Size(450, 554);
            this.txtNoteMatch.TabIndex = 2;
            // 
            // cmbOctive
            // 
            this.cmbOctive.FormattingEnabled = true;
            this.cmbOctive.Location = new System.Drawing.Point(1176, 12);
            this.cmbOctive.Name = "cmbOctive";
            this.cmbOctive.Size = new System.Drawing.Size(121, 21);
            this.cmbOctive.TabIndex = 3;
            // 
            // cmdArrange
            // 
            this.cmdArrange.Location = new System.Drawing.Point(1303, 12);
            this.cmdArrange.Name = "cmdArrange";
            this.cmdArrange.Size = new System.Drawing.Size(75, 23);
            this.cmdArrange.TabIndex = 4;
            this.cmdArrange.Text = "Re-Arrange";
            this.cmdArrange.UseVisualStyleBackColor = true;
            this.cmdArrange.Click += new System.EventHandler(this.cmdArrange_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 618);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1462, 130);
            this.textBox1.TabIndex = 5;
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
            this.label2.Location = new System.Drawing.Point(302, 15);
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
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Arranged Decision";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 770);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdArrange);
            this.Controls.Add(this.cmbOctive);
            this.Controls.Add(this.txtNoteMatch);
            this.Controls.Add(this.musicPanel);
            this.Controls.Add(this.txtStatus);
            this.Name = "Main_Form";
            this.Text = "Melodic Banjo Arranger";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Panel musicPanel;
        private System.Windows.Forms.TextBox txtNoteMatch;
        private System.Windows.Forms.ComboBox cmbOctive;
        private System.Windows.Forms.Button cmdArrange;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}

