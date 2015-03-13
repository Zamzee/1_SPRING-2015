// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Project 7
// Date: 7/18/2014


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
using System.Diagnostics;
using System.Windows;

namespace proj_07_RCA_V1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            formatConsole();          

            // 1. Set month = 1, adult = 1, babies = 0, total = 1
            int month = 1;
            int adults = 1;
            int babies = 0;
            int total = 1;

            bool under = true;
            const int MAX = 500;

            // 2. Print Student Information
            Console.WriteLine("Russell Andlauer \t CS-1400\t Project 7");
            // 3. Print "Table of Rabbit Population in Pairs"
            Console.WriteLine("\nTable of Rabbit Population in Pairs");
            // 4. Print "Month Adults Babies Total"
            Console.WriteLine("\nMonth\tAdults\tBabies\tTotal");
            // 5. Print initial row
            Console.WriteLine("\n{0}\t{1}\t{2}\t{3}", month, adults, babies, total);

                // 6. If under is true
            while (under == true)
            {
                // 7. increment month
                month ++;
                // 8. adults equals adults + babies
                adults = adults + babies;

                // 9. babies equals adults - babies
                babies = adults - babies;
                
                // 10. total equals adults + babies
                total = adults + babies;
                // 11. print month adults babies total values
                Console.WriteLine("\n{0}\t{1}\t{2}\t{3}", month, adults, babies, total);
                // 12. go back to step 6

                // 13. If total is >= 500
                if (total >= MAX)
                {
                    // 14. under is false
                    under = false;
                }
            }
            // 15. Print when there will not be enough cages
            Console.WriteLine("\nYou will run out of cages in month {0}.", month);
            Console.ReadLine();
        }

        static void formatConsole()
        {          
            Console.Clear();
            Console.SetWindowPosition(0, 0);
            Console.WindowHeight = Console.LargestWindowHeight - 30;
        }
    }
}
