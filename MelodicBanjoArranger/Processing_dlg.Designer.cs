namespace MelodicBanjoArranger
{
    partial class Processing_dlg
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
            this.txtCurrentNotePosition = new System.Windows.Forms.TextBox();
            this.txtProcessTarget = new System.Windows.Forms.TextBox();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCurrentNotePosition
            // 
            this.txtCurrentNotePosition.Location = new System.Drawing.Point(395, 9);
            this.txtCurrentNotePosition.Name = "txtCurrentNotePosition";
            this.txtCurrentNotePosition.Size = new System.Drawing.Size(222, 20);
            this.txtCurrentNotePosition.TabIndex = 0;
            // 
            // txtProcessTarget
            // 
            this.txtProcessTarget.Location = new System.Drawing.Point(395, 33);
            this.txtProcessTarget.Name = "txtProcessTarget";
            this.txtProcessTarget.Size = new System.Drawing.Size(222, 20);
            this.txtProcessTarget.TabIndex = 1;
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(8, 59);
            this.txtUpdate.Multiline = true;
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUpdate.Size = new System.Drawing.Size(609, 427);
            this.txtUpdate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // Processing_dlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.txtProcessTarget);
            this.Controls.Add(this.txtCurrentNotePosition);
            this.Name = "Processing_dlg";
            this.Text = "Processing_dlg";
            this.Load += new System.EventHandler(this.Processing_dlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentNotePosition;
        private System.Windows.Forms.TextBox txtProcessTarget;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}