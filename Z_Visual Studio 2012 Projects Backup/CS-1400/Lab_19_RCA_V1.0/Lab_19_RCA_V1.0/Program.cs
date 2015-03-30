// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Lab 20
// Date: 7/17/2014


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

namespace Lab_19_RCA_V1._0
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Create a random number generator
            Random randomNums = new Random();
            char response = 'n';
            const int BOX = 6;
            const int SIX = 6;
            const int ONE = 1;

            // 2. Ask the user if they want to roll the dice
            Console.WriteLine("Do you want to roll the dice? ('y' or 'n')");
            
            do
            {

                // 3. Get the user's response as either 'y' or 'n' 
                response = char.Parse(Console.ReadLine());

                // 4.  If user's response is not 'y' or 'n'                                         
                while ((response != 'y') && (response != 'n'))
                {
                    // 5. Display an error message
                    Console.WriteLine("Invalid response, please enter either 'y' or 'n'");
                    // 6. Go back to step 3
                    response = char.Parse(Console.ReadLine());
                }

                // 7. If the user responds with a 'n'                   
                while (response == 'n')
                {
                    // 8. Display message "Goodbye"
                    Console.WriteLine("Goodbye.");
                    // 9. Exit program
                    Environment.Exit(0);
                }
               
                // 7. If the user responds with a 'y'
                // 8. Generate two random numbers in the range 1-6, Save as int d1, int d2                    
                int d1 = randomNums.Next(1, BOX + 1);
                int d2 = randomNums.Next(1, BOX + 1);

                // 11. If  d1 and d2 are both sixes
                if (d1 == SIX && d2 == SIX)               
                {
                    // 12. Display message "You rolled boxcars"
                    Console.WriteLine("You rolled Boxcars.");
                }

                // 13. If d1 and d2 are both ones
                else if (d1 == ONE && d2 == ONE)
                {
                    // 14. Display message "You rolled snake-eyes"
                    Console.WriteLine("You rolled Snake-eyes.");
                }

                // 15. Else
                else
                {
                    // 16. Display "You rolled (d1) and (d2)"                                                             
                    Console.WriteLine("You rolled {0} and {1}", d1, d2);
                }
                // 17. Ask user if they want to roll again
                Console.WriteLine("Do you want to roll again? ('y' or 'n')");
                // 18. Go back to step 3
                                                              
            } while (response == 'y');

            Console.ReadLine();
        }
    }
}
