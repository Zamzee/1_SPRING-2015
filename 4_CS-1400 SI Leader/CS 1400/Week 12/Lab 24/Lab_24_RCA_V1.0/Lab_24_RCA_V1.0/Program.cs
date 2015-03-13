// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Lab 24
// Date: 7/31/2014


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

namespace Lab_24_RCA_V1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the array 
            const int SIZE = 100;
            int[] numbers = new int[SIZE];
            char input = char.Parse(Console.ReadLine());           
            int i = 0;

            // Get user input and save it in the array
            do // (int i = 0; i < SIZE; i++)
            {
                Console.Write("Please enter a value. ");
                numbers[i] = int.Parse(Console.ReadLine());
                i = i++;
                CalcProduct(numbers, i);

                // Call the Product method and Print the product           
                if (input == 1)
                {
                    Console.WriteLine("{0}", CalcProduct(numbers));
                }
            }  while (input != '0' && i < SIZE);




            Console.ReadLine();
        }

        // Product Method
        // Purpose: Multiply all of the numbers in the array
        // Parameters: int [] numbers
        // Returns: int product
        static int CalcProduct(int[] numbers, i)
        {
            const int SIZE = 100;
            int product = 0;
            for (int i = 0; i < SIZE; ++i)
            {
                product *= numbers[i];
            }
            return product;
        }
    }
}