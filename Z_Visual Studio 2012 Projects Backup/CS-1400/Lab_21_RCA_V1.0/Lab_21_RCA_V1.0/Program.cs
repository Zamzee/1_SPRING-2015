// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Lab 21
// Date: 7/22/2014


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

namespace Lab_21_RCA_V1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare some variables to test the program
            int number1 = 10;
            int number2 = 15;

            // call the Swap method and output the result
            Swap(ref number1, ref number2);
            Console.WriteLine("number1 = {0}", number1);
            Console.WriteLine("number2 = {0}", number2);

            Console.ReadLine();

        }

        // The Swap method
        // Purpose: To interchange the value of two variables
        // Parameters: two integers
        // Returns: None       
        // Side Effect: the values of the 2 integers are swapped

        static void Swap(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;

        }

    }
}

// Passing the parameters by reference make the program work correctly because 
// this actually changes the value of each variable outside of the method,
// not only inside of the method, 
// leaving the orginal values of the two variables the same.