using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



// File Prologue
// Name: Russell C. Andlauer
// Project: Project 02
// Date: June 7th, 2014


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

namespace proj_02_RCA_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtBox_WheelDiam_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBox_WheelDiam_Leave(object sender, EventArgs e)
        {
            
            run();  ///will run the 'run' method below to calculate and display the solution
        }

        /// <summary> Method: 'Run'
        /// Takes user input for wagon wheel diameter
        /// Calculates wheel circumference based on user input
        /// Calculates number of times the wheel will turn in one mile
        /// displays the results in the 'Turns_per_Mile' textbox
        /// </summary>
        private void run()
        {
            const double ONE_MILE = 63360; 
            ///Get user input from TxtBox_Wheel Diam
            ///Save user input as double WheelDiam
            double WheelDiam = double.Parse(TxtBox_WheelDiam.Text);

            ///Calculate Wheel Circumference based on user input for diameter
            double WheelCircumference = Math.PI * WheelDiam;

            ///Turns_per_Mile = ONE_MILE / WheelCircumference
            double Turns_per_Mile = ONE_MILE / WheelCircumference;
            
            ///Display Turns_per_Mile Result in the TxtBox_TurnNum
            TxtBox_TurnNum.Text = Turns_per_Mile.ToString();

            ///Move cursor to TxtBox_TurnNum after 'tab' key is pressed
            TxtBox_TurnNum.Focus();
        }

        //Method to display the program's 'About' information
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Russell C. Andlauer\nCS-1400\nProject 02");
        }

        //Method to close the program using the exit menu button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Method to clear the two text boxes and reposition the cursor to the TxtBox_Wheel_Diameter upon the 'Clear' button being pressed
        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtBox_WheelDiam.Text = "";
            TxtBox_TurnNum.Text = "";
            TxtBox_WheelDiam.Focus();
        }
    }
}
