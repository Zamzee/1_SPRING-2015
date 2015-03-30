// File Prologue
// Header File for the myRectangle class
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

#pragma once

class myRectangle
{
private:
	// declarations
	int height;
	int width;


public:
	// function prototypes

	// Default Constructor
	// Purpose: Initializes the myRectangle class
	// Parameters: none
	// Returns: none
	myRectangle();
	//~myRectangle(); // VS Studio added this line because I made the header and implementation files before using the class wizard to make the class (merged files)

	// Parameterized Constructor
	// Purpose: Initializes the parameters for the myRectangle class
	// Parameters: constant int height, constant int width
	// Returns: none
	myRectangle(const int, const int);

	// getHeight function
	// Purpose: getter for height
	// Parameters: none
	// Returns: int height
	int getHeight() const;

	// setHeight function
	// Purpose: setter for height
	// Parameters: int
	// Returns: none
	void setHeight(const int);

	// getWidth function
	// Purpose: getter for width
	// Parameters: none
	// Returns: int width
	int getWidth() const;

	// setWidth function
	// Purpose: setter for width
	// Parameters: int
	// Returns: none
	void setWidth(const int);

	// calcArea function
	// Purpose: Calculate the area of the rectangle
	// Parameters: int height, int width
	// Returns: none
	int calcArea() const;
};
