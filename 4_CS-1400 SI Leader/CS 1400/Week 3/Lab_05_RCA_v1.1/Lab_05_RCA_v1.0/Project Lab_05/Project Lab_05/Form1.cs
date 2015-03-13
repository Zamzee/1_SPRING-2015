///// Project Prolog
// Name: Russell Andlauer
// CS 1400 Online
// Project: CS1400_Lab_05
// Date: 5/29/2014 
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
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
            string aboutMsg = "Russell C. Andlauer\nCS1400\nLab #05";
            string headerMsg = "About Dialog Box";
            MessageBox.Show(aboutMsg, headerMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The BtnCompute_Click Method
        /// Purpose: Get a value from the user and display it back again
        /// //Parameters: The sending object, and the event arguments
        /// Returns: none
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(TxtIn.Text);
            string outStr = string.Format("{0:D}", num);
            TxtOut.Text = outStr;
        }
    }
}
