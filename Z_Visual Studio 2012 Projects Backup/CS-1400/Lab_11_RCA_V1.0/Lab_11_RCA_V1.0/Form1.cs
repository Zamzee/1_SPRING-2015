// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400 Online
// Project: Lab 11
// Date: 6/19/2014


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

namespace Lab_11_RCA_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double side1 = 0;
        double side2 = 0;
        double hypotenuse = CalcHypotenuse(side1, side2);
        txtHypotenuse.Text = hypotenuse.ToString();
        //double side1 = double.Parse(txtSide1.Text);
       // double side2 = double.Parse(txtSide2.Text);
      ///  double hypotenuse = CalcHypotenuse(side1, side2);
        ///    txtHypotenuse.Text = hypotenuse.ToString();
        //double hypotenuse = 0;
        // Get value of side1 from txtSide1, save as double
                 // double side1 = double.Parse(txtSide1.Text);

        // Get value of side2 from txtSide2, save as double

        // Call CalcHypotenuse method

        // Display result in txtHypotenuse




        // The Find the Hypotenuse Method
        // Purpose: To find the hypotenuse of a triangle
        // Parameters: Side A and Side B as doubles
        // Returns: The length of Side C as a double

        static double CalcHypotenuse(double side1, double side2)
        {
            // Square side1
            side1 = side1 * side1;

            // Square side2
            side2 = side2 * side2;

            // Add side1 and side2
            // Save as hypotenuse
            side2 = side1 + side2;

            // Square root hypotenuse
            side2 = Math.Sqrt(side2);
            return side2;
        }

        private void btn_Calc_Hypotenuse_Click(object sender, EventArgs e)
        {
            CalcHypotenuse(side1, side2);
           //double hypotenuse = CalcHypotenuse(side1, side2);
           txtHypotenuse.Text = hypotenuse.ToString();
           /// txtHypotenuse.Text = String.Format("{0:3}", hypotenuse);
        }

        private void txtSide1_TextChanged(object sender, EventArgs e)
        {
            double side1 = double.Parse(txtSide1.Text);
        }

        private void txtSide2_TextChanged(object sender, EventArgs e)
        {
            double side2 = double.Parse(txtSide2.Text);
        }

        private void txtHypotenuse_TextChanged(object sender, EventArgs e)
        {
         double hypotenuse = CalcHypotenuse(side1, side2);
         txtHypotenuse.Text = hypotenuse.ToString();
        }
    }
}
