// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Lab 23
// Date: 7/29/2014


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

namespace Lab_23_RCA_V1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the array 
            const int SIZE = 10;
            int[] numbers = new int[SIZE];           

            // Get user input and save it in the array
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write("Please enter a value. ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Print values in the array as a test (not neccessary for the assignment)
            foreach (int i in numbers)
            {
                Console.WriteLine("+");
                Console.WriteLine(i);                
            }

            Console.WriteLine("=");

            // Call the Sum method and Print the sum           
            Console.WriteLine("{0}", Sum(numbers));

            Console.ReadLine();
        }
        
            // Sum Method
            // Purpose: Add all of the numbers in the array
            // Parameters: int [] numbers
            // Returns: int sum
            static int Sum(int [] numbers)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; ++i)
                {                 
                    sum += numbers [i];                   
                }
                return sum;
            }
    }
}
