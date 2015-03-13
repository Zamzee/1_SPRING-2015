// Project Prolog
// Name: Russell C. Andlauer
// CS 1400 Online
// Project: CS1400_Lab_09
// Date: 6/12/2014 
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;

static class Program
{
    /// <summary>
    /// Purpose: Entry point to your C# program
    /// </summary>
    static void Main()
    {
        //Prompt User to enter the radius of one of the crop circles
        Console.WriteLine("Enter the radius of one of the crop circles.");

        //Save radius as a double "rad"
        double rad = double.Parse(Console.ReadLine());

        //Multiply "Rad" by 2 to find the length of one side of the square
        //Save value as a double "SquareSideLength"
        double SquareSideLength = rad * 2;

        //Multiply Pi * rad * rad to find the area of each circle
        //Save value as a double "AreaOfCircle"
        double AreaOfCircle = Math.PI * (rad * rad);

        //Multiply "SquareSideLength" by "SquareSideLength" to find the area of the square
        //Save Value as a double "AreaSquare"
        double AreaOfSquare = SquareSideLength * SquareSideLength;

        //Subtract "AreaOfCircle" from "AreaOfSquare" to find the are of the shaded region
        //Save value as a double AreaOfShadedRegion
        double AreaOfShadedRegion = AreaOfSquare - AreaOfCircle;

        //Output the "AreaOfShadedRegion" as a string in the Console saying "The area of the shaded region is _______." 
        Console.WriteLine("The area of the shaded region is {0} units squared.", AreaOfShadedRegion);

        Console.ReadLine();
    }//End Main()
}//End class Program
