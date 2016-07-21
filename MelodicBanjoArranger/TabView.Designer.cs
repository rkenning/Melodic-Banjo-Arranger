namespace MelodicBanjoArranger
{
    partial class TabView
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
            this.alphaTabControl1 = new AlphaTab.Platform.CSharp.WinForms.AlphaTabControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alphaTabControl1
            // 
            this.alphaTabControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.alphaTabControl1.Location = new System.Drawing.Point(287, 3);
            this.alphaTabControl1.Name = "alphaTabControl1";
            this.alphaTabControl1.Size = new System.Drawing.Size(316, 157);
            this.alphaTabControl1.TabIndex = 0;
            this.alphaTabControl1.Text = "alphaTabControl1";
            this.alphaTabControl1.Track = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1406, 0);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(1319, 3);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 2;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // TabView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 657);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.alphaTabControl1);
            this.Name = "TabView";
            this.Text = "TabView";
            this.Load += new System.EventHandler(this.TabView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AlphaTab.Platform.CSharp.WinForms.AlphaTabControl alphaTabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cmdClose;
    }
}