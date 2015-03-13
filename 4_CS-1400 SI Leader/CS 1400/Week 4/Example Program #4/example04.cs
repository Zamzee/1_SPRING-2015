// weekly samples
// program #4
// Roger deBry
// May 2009
// ----------------

using System;

class Program
{
    // constants for conversions
    const int QUIT_TIME = 1600;
    const int HUNDRED = 100;     
    const int SIXTY = 60;             
    
    static void Main( )
    {

     int currentTime = 0;

     Console.Write("Please type in the current time in military format (hhmm): ");
     currentTime = int.Parse(Console.ReadLine( ));

     // convert current time to minutes
     int currHours = currentTime / HUNDRED;
     int currMins = currHours * SIXTY + (currentTime % HUNDRED);

     // convert quit time to minutes (could have used a constant for this, but this is more general)
     int quitHours = QUIT_TIME / HUNDRED;
     int quitMins = quitHours * SIXTY + (QUIT_TIME % HUNDRED);

     // calculate minutes left till quitting time
     int minsLeft = quitMins - currMins;

     // convert back to hours and minutes
     int hoursLeft = minsLeft / SIXTY;
     minsLeft = minsLeft % 60;

     // print result
     Console.WriteLine("There are {0} hours and {1} minutes left until quitting time", hoursLeft, minsLeft);

     Console.ReadLine( );
    }

}