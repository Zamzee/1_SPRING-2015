// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Lab 17
// Date: 7/10/2014


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_17_RCA_V1._0
{
    public partial class Form1 : Form
    {
        // initialize the form and set all 3 radio buttons to not checked
        public Form1()
        {
            InitializeComponent();
            radioBtn_1.Checked = false;
            radioBtn_2.Checked = false;
            radioBtn_3.Checked = false;
        }

        // display standard shipping message box when radio button 1 is checked
        private void radioBtn_1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_1.Checked)
            {
                MessageBox.Show("Selected Standard shipping.");
            }
        }

        // display express shipping message box when radio button 2 is checked
        private void radioBtn_2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_2.Checked)
            {
                MessageBox.Show("Selected Express shipping.");
            }
        }

        // display same-day shipping message box when radio button 3 is checked
        private void radioBtn_3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_3.Checked)
            {
                MessageBox.Show("Selected Same-Day shipping.");
            }
        }

        // display the about message box when the about menustrip item is clicked
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Russell Andlauer\nCS-1400\nLab #17");
        }

        // exit the application when the exit menustrip item is checked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
