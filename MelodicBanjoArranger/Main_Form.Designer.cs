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
            this.txtStringMatch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(16, 11);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatus.Size = new System.Drawing.Size(94, 288);
            this.txtStatus.TabIndex = 0;
            // 
            // musicPanel
            // 
            this.musicPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.musicPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.musicPanel.Location = new System.Drawing.Point(225, 17);
            this.musicPanel.Name = "musicPanel";
            this.musicPanel.Size = new System.Drawing.Size(545, 282);
            this.musicPanel.TabIndex = 1;
            this.musicPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.musicPanel_Paint);
            // 
            // txtStringMatch
            // 
            this.txtStringMatch.Location = new System.Drawing.Point(125, 11);
            this.txtStringMatch.Multiline = true;
            this.txtStringMatch.Name = "txtStringMatch";
            this.txtStringMatch.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStringMatch.Size = new System.Drawing.Size(94, 288);
            this.txtStringMatch.TabIndex = 2;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 311);
            this.Controls.Add(this.txtStringMatch);
            this.Controls.Add(this.musicPanel);
            this.Controls.Add(this.txtStatus);
            this.Name = "Main_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Panel musicPanel;
        private System.Windows.Forms.TextBox txtStringMatch;

    }
}

