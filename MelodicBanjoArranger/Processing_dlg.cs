using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MelodicBanjoArranger
{
    
    public partial class Processing_dlg : Form
    {
        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(string text);

        public Processing_dlg()
        {
            InitializeComponent();
        }

        public void Update_Status(String strMessage)
        {
            if (this.txtUpdate.InvokeRequired)
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


        private void Processing_dlg_Load(object sender, EventArgs e)
        {

        }

  
    }
}
