﻿// File Prologue
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
    class Bowler
    {
        string name;
        int score;

        // Method: setName
        // Purpose: setter for string name
        // Parameters: string iName
        // Returns:none
        public void setName(string iName)
        {
            name = iName;
        }

        // Method: setScore
        // Purpose: setter for int score
        // Parameters: int iScore
        // Returns: none
        public void setScore(int iScore)
        {
            score = iScore;
        }

        // Method: getName
        // Purpose: getter for string name
        // Parameters: none
        // Returns: string name
        public string getName()
        {
            return name;
        }

        // Method: getScore
        // Purpose: getter for int score
        // Parameters: none
        // Returns: int score
        public int getScore()
        {
            return score;
        }
    }
}
