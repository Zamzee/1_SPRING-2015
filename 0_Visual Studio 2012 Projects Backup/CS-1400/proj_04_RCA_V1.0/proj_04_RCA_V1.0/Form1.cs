// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Project 04
// Date: 6/24/2014


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

namespace proj_04_RCA_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sideA;
        double sideB;
        double sideC;
        double angle;
        double cosine;

        //inputs
        sideA = double.Parse(txtSideA.Text);
        sideB = double.Parse(txtSideB.Text);
        angle = double.Parse(txtAngleC.Text);

        //output to textbox
        txtSideC.Text = sideC.ToString();
        txtSideC.Text = String.Format("{0:d2}", sideC);

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Russell C. Andlauer\nCS-1400\nProject 04");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            FindSideCLength(sideA, sideB, angle);
        }

        // FindSideCLength
        // Purpose: Find the length of Side C of a triangle
        // Parameters: length of Side A, length of Side B, angle between Side A and Side B all as doubles
        // Returns: Length of Side C as a double
        static double FindSideCLength(double sideA, double sideB, double angle)
        {
            
            // Convert angle from degrees to radians
            // (Multiply angle x Pi)
            // Divide by 180
            angle = (angle * Math.PI) / 180;

            // Find Cosine of angle
            angle = Math.Cos(angle);

            // Multiply Two x (sideA) x (sideB) x cos(angle)
            // Save as double cosine
            double cosine = (2 * sideA * sideB * angle);

            // ((sideA x sideA) + (sideB x sideB)) - cosine
            // Save as double sideC
            double sideC = ((sideA * sideA) + (sideB * sideB)) - cosine;
            
            // Square root sideC
            sideC= Math.Sqrt(sideC);
            // return sideC
            return sideC;
        }

        private void txtSideA_TextChanged(object sender, EventArgs e)
        {
            // works here
            sideA = double.Parse(txtSideA.Text);
            
        }
    }
}
