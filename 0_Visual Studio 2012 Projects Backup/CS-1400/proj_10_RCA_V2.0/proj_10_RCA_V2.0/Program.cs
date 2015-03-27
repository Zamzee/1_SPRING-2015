// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Project 10
// Date: 8/11/2014


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

namespace proj_10_RCA_V2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 10;
            int[] scores = new int[MAX];

            BowlingTeam theTeam = new BowlingTeam();


            Console.WriteLine("Bowling Team Scores");

            bool exit = false;
            String[] temp;

            Bowler tempB;

            Console.WriteLine("Please input a bowler's name and their score, seperated by a space.");
            Console.WriteLine("When finished inputing, hit enter to calculate.");

            for (int i = 0; i < MAX && !exit; i++)
            {
                temp = Console.ReadLine().Split();

                if (temp[0] == "")
                {
                    exit = true;
                }
                else
                {
                    tempB = new Bowler();
                    tempB.setName(temp[0]);
                    tempB.setScore(int.Parse(temp[1]));

                    theTeam.addBowler(tempB);

                }
            }

            string[] output = theTeam.teamOut();

            Console.WriteLine("------------------------Input Complete------------------------");
            Console.WriteLine("Here are the team's results, ranked in order from highest to lowest.");
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }


            Console.WriteLine("Your team average is {0}", theTeam.getAverage());

            Console.ReadLine();
        }
    }
}
