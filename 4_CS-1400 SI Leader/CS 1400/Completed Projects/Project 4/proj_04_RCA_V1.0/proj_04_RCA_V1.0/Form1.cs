﻿// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Project 04
// Date: 6/25/2014


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
            txtSideC.Text = FindSideCLength( double.Parse(txtSideA.Text), double.Parse(txtSideB.Text), double.Parse(txtAngleC.Text)).ToString("f2");
        }

        // FindSideCLength
        // Purpose: Find the length of Side C of a triangle
        // Parameters: length of Side A, length of Side B, angle between Side A and Side B all as doubles
        // Returns: Length of Side C as a double
        static double FindSideCLength(double sideOne, double sideTwo, double angle)
        {
            
            // Convert angle from degrees to radians
            // (Multiply angle x Pi)
            // Divide by 180
            const double CALC_VAR_ONE = 2;
            const double CONV_DENOM = 180;
            angle = (angle * Math.PI) / CONV_DENOM;

            // Find Cosine of angle
            angle = Math.Cos(angle);

            // Multiply Two x (sideA) x (sideB) x cos(angle)
            // Save as double cosine
            double cosine = (CALC_VAR_ONE * sideOne * sideTwo * angle);

            // ((sideA x sideA) + (sideB x sideB)) - cosine
            // Save as double outside
            double outSide = ((sideOne * sideOne) + (sideTwo * sideTwo)) - cosine;
            
            // Square root sideC
            outSide = Math.Sqrt(outSide);
            // return sideC
            return outSide;
        }   
    }
}
