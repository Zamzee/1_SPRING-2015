using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokenMachine
{
    public partial class Form1 : Form
    {
        // class level reference to a token machine
        private TokenMachine tm;
        public Form1()
        {
            InitializeComponent();

            //create a token machine object
            tm = new TokenMachine();
            tm.GetToken ();
           /// tm.Reset();
            
        }

        // The About Menu Item event handler
        // Purpose: To display information about this program
        // Parameters: The sending object and event arguments
        // Returns: None
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Russell C. Andlauer\nCS-1400\nLab 12");
        }

        // The Exit Menu Item event handler
        // Purpose: To close the application
        // Parameters the sending object and event arguments
        // Returns: none
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetToken_Click(object sender, EventArgs e)
        {
            int Tokens = tm.CountTokens();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
