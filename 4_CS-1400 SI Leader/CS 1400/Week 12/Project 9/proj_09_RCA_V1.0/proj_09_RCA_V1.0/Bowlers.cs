﻿// File Prologue
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
    class Bowlers
    {
        Bowler[] bowlers = new Bowler[0];

        // Method: addBowler
        // Purpose: add a new bowler object to the array
        // Parameters: Bowler class
        // Returns: none
        public void addBowler(Bowler iBowler)
        {
            Array.Resize(ref bowlers, bowlers.Length + 1);
            bowlers[bowlers.Length - 1] = iBowler;
        }

        // Method: getHighest
        // Purpose: Find the highest bowling score 
        // Parameters: none
        // Returns: Bowler class for bowler with highest score
        public Bowler getHighest()
        {
            Bowler highest = bowlers[0];

            for (int i = 1; i < bowlers.Length; i++)
            {
                if(bowlers[i].getScore() > highest.getScore())
                {
                    highest = bowlers[i];
                }
            }

            return highest;
        }

        // Method: getLowest
        // Purpose: Find the lowest bowling score
        // Parameters: none
        // Returns: Bowler class for bowler with lowest score
        public Bowler getLowest()
        {
            Bowler lowest = bowlers[0];

            for (int i = 1; i < bowlers.Length; i++)
            {
                if (bowlers[i].getScore() < lowest.getScore())
                {
                    lowest = bowlers[i];
                }
            }

            return lowest;
        }

        // Method:getAverage
        // Purpose: Find the average bowling score
        // Parameters: none
        // Returns: int average
        public int getAverage()
        {
            int average = 0;

            for (int i = 0; i < bowlers.Length; i++)
            {
                average += bowlers[i].getScore();
            }

            average = average / bowlers.Length;

            return average;
        }

    }
}
