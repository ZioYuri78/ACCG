using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCG
{
    public partial class SyncForm : Form
    {
        public SyncForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.tbLogArea.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.tbLogArea.Invoke(d, new object[] { text });
            }
            else
            {
                this.tbLogArea.AppendText(text);
            }
        }

    }
}
