// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Lab 25
// Date: 8/5/2014


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

namespace Lab_25_RCA_V1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is the date to be sorted
            int[] theData = { 45, 12, 23, 34 };

            // sort the array in ascending order
            // print out lots of messages so we can see the sort work
            for (int j = 0; j < theData.Length - 1; j++)  // index for outer loop is j
            {
                Console.WriteLine("Iteration {0} for the outer loop", j);
                for (int i = 0; i < theData.Length - 1; i++)  // index for inner loop is i
                {
                    Console.WriteLine("\nIteration {0} for the inner loop", i);
                    if (theData[i] < theData[i + 1])
                        Swap(ref theData[i], ref theData[i + 1]);
                }
            }

            // print out the sorted array
            Console.WriteLine("\n\n*****  The sorted array is: *****");
            for (int i = 0; i < theData.Length; i++)
            {
                Console.Write("{0} ", theData[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        // method prototype for the swap routine
        // parameters: two integers, passed by reference
        // routines: none
        // The two integer values are swapped
        // ---------------------------------------------------
        static void Swap(ref int a, ref int b)
        {
            Console.WriteLine("Swapping {0} and {1}", a, b);
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
