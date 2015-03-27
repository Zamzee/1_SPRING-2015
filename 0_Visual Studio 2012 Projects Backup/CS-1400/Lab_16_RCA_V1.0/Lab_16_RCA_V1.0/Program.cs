// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Lab 16
// Date: 7/8/2014


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

namespace Lab_16_RCA_V1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare some constants for saturday and sunday
            const string SAT = "Saturday";
            const string SUN = "Sunday";
            const string COLD = "No";

            // declare a variable to hold user's input
            string today;
            string freezing;
            // prompt the user to enter a day and get the input
            Console.Write("Please enter a day of the week, e.g. Tuesday: ");
            today = Console.ReadLine();

            // see if it is the weekend, if is skip temperature prompt
            if ((today == SAT || today == SUN))
            {
                // it is not a workday, display the weekend message
                Console.WriteLine("Yeah! No work today!");
                Console.ReadLine();
            }
            else
            {
                // prompt the user to indicate if the temperature is above freezing or not
                Console.Write("Is the temperature above freezing outside? Enter Yes or No: ");
                freezing = Console.ReadLine();

                // see if it is a work day and if it is above freezing
                if ((today != SUN && today != SAT && freezing != COLD))
                {
                    // it is a workday and it is above freezing, display the go to work message
                    Console.WriteLine("Go to work.");
                }
                // see if it is a work day and if it is below freezing
                else if ((today != SUN && today != SAT && freezing == COLD))
                {
                    // it is a workday and it is below freezing
                    Console.WriteLine("Go to work and dress warmly.");
                }
                else
                {
                    // its not a workday, display the weekend message
                    Console.WriteLine("Yeah! No work today!");
                }

                Console.ReadLine();
            }
        }
    }
}