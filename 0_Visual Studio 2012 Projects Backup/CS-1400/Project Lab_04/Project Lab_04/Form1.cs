///// Project Prolog
// Name: Russell C. Andlauer
// CS 1400 Section 003
// Project: CS1400_Lab_04
// Date: 4/26/2014 5:30 PM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
///
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Lab_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ///summary <summary>
        ///Purpose: To respond to the Exit menu click event and close the program.
        ///</summary>
        ///<param name="sender"></param>
        ///<param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             Close();
        }

        /// <summary>
        /// Purpose: To respond to the About menu click event and display a message box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutMsg = "Russell C. Andlauer\nCS1400\nLab #04";
            string headerMsg = "About Dialog BOx";
            MessageBox.Show(aboutMsg, headerMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
