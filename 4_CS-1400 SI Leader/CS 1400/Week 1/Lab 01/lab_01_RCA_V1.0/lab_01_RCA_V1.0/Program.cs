using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// File Prologue.......................................
// Author: Russell Andlauer
// Course: CS 1400
// Project: Lab One
// Date: May 14 2014

// I declare that the following source code was written soley by me, or provided on
// the course web site for this program. I understand that copying any source code, 
// in whole or in part, constitutes cheating, and that I will receive a zero grade 
// on this project if I am found in violation of this policy.


namespace lab_01_RCA_V1._0
{
    class Program
    {
        static void Main(string[] args)
        {// This program displays my student information
            string name = "Russell Andlauer";
            string course = "CS 1400";
            string section = "001";
            string project = "Lab One";

            // This coded inserts the strings into the stream object cout
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Course: {0}", course);
            Console.WriteLine("Section: {0}", section);
            Console.WriteLine("Project: {0}", project);

            Console.ReadLine();
        }
    }
}
