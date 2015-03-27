// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Lab 22
// Date: 7/23/2014


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

namespace Lab_22_RCA_V1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 0;
            int dollars = 0;
            int cents = 0;

            // Prompt user to enter a value for an amount of money
            Console.WriteLine("Please enter an amount of money written as a decimal, such as 4.53");

            // Save user input as double value
            value = double.Parse(Console.ReadLine());

            // Call the SplitValue method
            SplitValue(value, ref dollars, ref cents);

            // Print the amount of dollars and cents
            Console.WriteLine("There are {0} dollars and {1} cents in {2:C}.", dollars, cents, value);
            Console.ReadLine();
        }

        static void SplitValue(double value, ref int dollars, ref int cents)
        {
            const int FACTOR = 100;
            dollars = (int)value;
            cents = (int)((value - dollars) * FACTOR);
        }
    }
}
