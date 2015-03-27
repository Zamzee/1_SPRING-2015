using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// File Prologue.......................................
// Author: Russell C. Andlauer
// Course: CS 1400
// Project: Project 03
// Date: June 14th, 2014

// I declare that the following source code was written soley by me, or provided on
// the course web site for this program. I understand that copying any source code, 
// in whole or in part, constitutes cheating, and that I will receive a zero grade 
// on this project if I am found in violation of this policy.

namespace proj_03_RCA_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBox_Old_Depart_TextChanged(object sender, EventArgs e)
        {
          
        }
        // About Menu Item click displays 'About' Window
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Russell C. Andlauer\nCS-1400\nProject 03");
        }
        // Exit Menu Item click closes the form application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBox_Old_Arrive_TextChanged(object sender, EventArgs e)
        {
          
        }
        // Calculate button click event calls the "Run()" method
        private void btn_Calculate_New_Arrive_Click(object sender, EventArgs e)
        {
            Run();
        }

        // Name: Run Method
        // Purpose: Calculates the new arrival time based on user input
        private void Run()
        {
            const int HUN_PART = 100;
            const int MIN_PER_HOUR = 60;
            const int EXTRA_TIME = 25;
            const int PER_CENT = 100;
            // Gets user input from the Old_Depart and Old_Arrive text boxes and saves as integers
            int oldDepartTime = int.Parse(txtBox_Old_Depart.Text);
            int oldArriveTime = int.Parse(txtBox_Old_Arrive.Text);

            // Converts the user entered old departure time into minutes
            int oldDepartHours = (oldDepartTime / HUN_PART);
            int oldDepartMins = (oldDepartTime % HUN_PART);
            oldDepartTime = (oldDepartMins + (oldDepartHours * MIN_PER_HOUR));

            // Converts the user entered old arrival time into minutes
            int oldArriveHours = (oldArriveTime / HUN_PART);
            int oldArriveMins = (oldArriveTime % HUN_PART);
            oldArriveTime = ( oldArriveMins + (oldArriveHours * MIN_PER_HOUR));

            // Calculates the extra 25% travel time and adds this value to the old arrival time
            int travelTime = ((oldArriveTime - oldDepartTime) * EXTRA_TIME) / PER_CENT;
            oldArriveTime = oldArriveTime + travelTime;

            // Converts the new Arrival time into the (hhmm) format
            int newArriveHours = (oldArriveTime / MIN_PER_HOUR);
            int newArriveMins = (oldArriveTime % MIN_PER_HOUR);
            int newArriveTime = ((newArriveHours * PER_CENT) + newArriveMins);

            // displays the new arrival time in a 4 digit format in the New_Arrive_Textbox
            txtBox_New_Arrive.Text = newArriveTime.ToString();
            txtBox_New_Arrive.Text = String.Format("{0:d4}", newArriveTime);

        }

        private void txtBox_New_Arrive_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
