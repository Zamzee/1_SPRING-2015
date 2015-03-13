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
    class BowlingTeam
    {
        Bowler[] bowlers = new Bowler[0];
        const int MAX_SCORE = 300;

        // Method: addBowler
        // Purpose: add a bowler class to the bowlers array
        // Parameters: Bowler array, iBowler
        // Returns: none
        public void addBowler(Bowler iBowler)
        {
            Array.Resize(ref bowlers, bowlers.Length + 1);
            bowlers[bowlers.Length - 1] = iBowler;
        }

        // Method: teamOut
        // Purpose: output sorted bowlers array
        // Parameters: none
        // Returns: string array 'data'
        public string[] teamOut()
        {
            Bowler[] temp = Sort(bowlers);
            string[] data = new string[0];

            for (int i = 0; i < temp.Length; i++)
            {
                Array.Resize(ref data, data.Length + 1);

                string toGo = temp[i].getName() + " " + temp[i].getScore().ToString();

                if (temp[i].getScore() == MAX_SCORE)
                {
                    toGo += "*";
                }

                data[data.Length - 1] = toGo;
            }
            return data;
        }

        // Method: Sort
        // Purpose: Sort each Bowler in the Bowlers class by score
        // Parameters: Bowler array, iTeam
        // Returns: iTeam
        public Bowler[] Sort(Bowler[] iTeam)
        {
            for (int i = 0; i < bowlers.Length; i++)
            {
                for (int j = 0; j < iTeam.Length - 1; j++)
                {


                    if (iTeam[j].getScore() < iTeam[j + 1].getScore())
                    {
                        swap(ref iTeam[j], ref iTeam[j + 1]);
                    }
                }
            }
            return iTeam;
        }

        // Method:swap
        // Purpose: reorder currently compared Bowlers in Bowlers array
        // Parameters: ref Bowler a, ref Bowler b
        // Returns: none
        public void swap(ref Bowler a, ref Bowler b)
        {
            Bowler temp = a;
            a = b;
            b = temp;
        }

        // Method: getAverage
        // Purpose: Calculate the average score of the Bowlers array
        // Parameters: none
        // Returns: double 'average'
        public double getAverage()
        {
            double average = 0;


            for (int i = 0; i < bowlers.Length; i++)
            {
                average += bowlers[i].getScore();
            }

            average = average / bowlers.Length;

            return average;

        }
    }
}
