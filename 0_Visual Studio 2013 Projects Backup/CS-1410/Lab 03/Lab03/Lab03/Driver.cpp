// File Prologue
// Driver File for the myRectangle class
// Class: CS-1410
// Project: Lab 03
// Author: Russell Andlauer
// Date Last Modified: September 10th, 2014
// ------------------------------------------------------------------------
// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.
// ------------------------------------------------------------------------

#include <iostream>
#include "myRectangle.h"
using namespace std;

int main()
{
	// create a myRectangle class
	myRectangle theRectangle;

	// declarations
	int height = 4;
	int width = 7;

	// Program Description
	cout << "\nThis program calculates the area of a rectangle.\n\n";

	// Rectangle Description
	cout << "\nThe rectangle has a height of " << height << " and a width of " << width << endl;

	// set the height and width of the rectangle
	theRectangle.setHeight(height);  
	theRectangle.setWidth(width);

	// Display the area of the rectangle
	cout << "\nThe area of the rectangle is: " << theRectangle.calcArea() << endl;

	system("PAUSE");
	return 0;
}