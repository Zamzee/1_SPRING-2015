﻿// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Lab 10
// Date: 6/17/14


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_RCA_V1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1 = 0;
            double side2 = 0;
            
            // Ask the user to enter the length of one side of a triangle
            Console.WriteLine( "Enter the length of one side of the triangle.");

            // Get the user's input and save it as a double 'side1'
            side1 = double.Parse(Console.ReadLine());

            // Ask the user to enter the length of the other side of the triangle
            Console.WriteLine( "Enter the length of the other side of the triangle.");

            // Get the user's input and save it as a double 'side2'
            side2 = double.Parse(Console.ReadLine());

            // Call the CalcHypotenuse method and pass in the lengths of the two sides of the triangle as parameters
            // Save the value returned as a double 'hypotenuse'
            double hypotenuse = CalcHypotenuse(side1, side2);
            
            // Display return value in the console
            Console.WriteLine("The length of the hypotenuse is {0}.", hypotenuse);
            // String.Format("{0:d3}", hypotenuse); unsure how to properly do this in a console application
            Console.ReadLine();
        }
         // The Find the Hypotenuse Method
        // Purpose: To find the hypotenuse of a triangle
        // Parameters: Side A and Side B as doubles
        // Returns: The length of Side C as a double

        static double CalcHypotenuse (double side1, double side2)
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


    }
    
}
