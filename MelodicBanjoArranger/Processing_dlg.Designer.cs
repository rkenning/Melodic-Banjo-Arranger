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
            this.txtCurrentNumber = new System.Windows.Forms.TextBox();
            this.txtProcessTarget = new System.Windows.Forms.TextBox();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCurrentNumber
            // 
            this.txtCurrentNumber.Location = new System.Drawing.Point(552, 30);
            this.txtCurrentNumber.Name = "txtCurrentNumber";
            this.txtCurrentNumber.Size = new System.Drawing.Size(222, 20);
            this.txtCurrentNumber.TabIndex = 0;
            // 
            // txtProcessTarget
            // 
            this.txtProcessTarget.Location = new System.Drawing.Point(552, 73);
            this.txtProcessTarget.Name = "txtProcessTarget";
            this.txtProcessTarget.Size = new System.Drawing.Size(222, 20);
            this.txtProcessTarget.TabIndex = 1;
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(56, 120);
            this.txtUpdate.Multiline = true;
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtUpdate.Size = new System.Drawing.Size(929, 371);
            this.txtUpdate.TabIndex = 2;
            // 
            // Processing_dlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 518);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.txtProcessTarget);
            this.Controls.Add(this.txtCurrentNumber);
            this.Name = "Processing_dlg";
            this.Text = "Processing_dlg";
            this.Load += new System.EventHandler(this.Processing_dlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentNumber;
        private System.Windows.Forms.TextBox txtProcessTarget;
        private System.Windows.Forms.TextBox txtUpdate;
    }
}