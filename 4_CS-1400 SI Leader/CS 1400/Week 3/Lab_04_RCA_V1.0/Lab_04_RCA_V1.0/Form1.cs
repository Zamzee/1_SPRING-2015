// File Prologue.......................................
// Author: Russell Andlauer
// Course: CS 1400
// Project: Lab Four
// Date: May 27th, 2014

// I declare that the following source code was written soley by me, or provided on
// the course web site for this program. I understand that copying any source code, 
// in whole or in part, constitutes cheating, and that I will receive a zero grade 
// on this project if I am found in violation of this policy.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04_RCA_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary> The exitToolStripMenuItem1 method
        /// Purpose: To close the window and terminate the application
        /// </summary>
        /// <param name="sender"></param>The object generating the event and the event arguments
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>THe ToolStripMenuItem2 method
        /// Purpose: To show an about information window
        /// </summary>
        /// <param name="sender"></param>The object generating the event and the event arguments
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Russell Andlauer\nCS1400\nLab #4");
        }
    }
}
