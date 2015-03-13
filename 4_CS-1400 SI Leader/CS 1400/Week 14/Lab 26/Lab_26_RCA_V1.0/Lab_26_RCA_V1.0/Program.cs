// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Lab 26
// Date: 8/12/2014


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
using System.IO;


namespace Lab_26_RCA_V1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a File Path to "grades.txt"
            string environment = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\\grades.txt";
            string inputString;

            // Create the array to hold the exam scores
            const int SIZE = 50;
            int[] examScores = new int[SIZE];
            double sum = 0;
            int index = 0;
            int aScore = 0;

            // Create a StreamReader object
            StreamReader theTextFile = new StreamReader(environment);

            // Read the text file, store each value in 'examScores' array
            do {           
                inputString = theTextFile.ReadLine();

                // Store each value in the array 'examScores'
                    if (inputString != null)
                     {
                    aScore = int.Parse(inputString);
                    if (aScore >= 0)
                        examScores[index++] = aScore;
                    }

                } while (inputString != null);

                    for (int i = 0; i < index; i++)
                    {
                        {
                            // add each exam score together
                            sum += examScores[i];

                            // Display each grade value from the text file
                            Console.WriteLine("{0}", examScores[i]);
                        }
                    }
            // Call the calcAverage method and display result
            Console.WriteLine("The average exam score is {0:f2}.", calcAverage(examScores, sum, index));
            Console.ReadLine();           
       }

            // Method: calcAverage
            // Purpose: Calculate the Average Exam Score
            // Parameters: examScores array
            // Returns: double 'average'
            static double calcAverage(int[] iexamScores, double isum, int aindex)
            {
                double total = isum; 
                double iaverage = (total / aindex);

                return iaverage;
            }
    }
}
