// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Project 9
// Date: 8/1/2014


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.
// Received help from the tutor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_09_RCA_V1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Bowlers bowlers = new Bowlers();

            // Prompt user to input bowler name and bowler score, display how to stop entering scores and calculate
            Console.WriteLine("Enter bowler name and score, seperated by a space.");
            Console.WriteLine("Press enter when finished adding scores to calculate.");
            // Save user response into a string array input
            string[] input = Console.ReadLine().Split();

            // Initialize new Bowler object        
            Bowler temp;
            // Check if user input indicates to calculate
            bool exit = Checker(input);

            while(!exit)
            {                                            
                temp = new Bowler();
                temp.setName(input[0]);
                temp.setScore(int.Parse(input[1]));

                bowlers.addBowler(temp);
                input = Console.ReadLine().Split();
                exit = Checker(input);                
              }

            // Display Results
                Console.WriteLine("Your highest score was {0} by {1})", bowlers.getHighest().getScore(), bowlers.getHighest().getName());
                Console.WriteLine("Your lowest score was {0} by {1})", bowlers.getLowest().getScore(), bowlers.getLowest().getName());
                Console.WriteLine("The average score was {0}.)", bowlers.getAverage());

                Console.ReadLine();
            }

             // Method: Checker
             // Purpose: Check if user input indicates if calculations should be done
             // Parameters: string array input
             // Returns: bool end
            static bool Checker(string[] input)
            {
                bool end = false;
                if (input[0] =="")
                {
                    end = true;
                }

                return end;
            }

        
    }
}
