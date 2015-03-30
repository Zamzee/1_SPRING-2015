// File Prologue
// Author: Russell C. Andlauer
// Class: CS-1410-001
// Project: Lab 05
// Date Last Modified: September 24th, 2014

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.
////////////////////////////////////////////////////////////////////////////
#include <iostream>
#include <string>
using namespace std;

#include "NegValueException.h"
#include "ZeroValueException.h"

// calcSquare function
// Purpose: To calculate the value of an integer squared
// Parameters: int 'value'
// Returns: int
int calcSquare(int value);

int main()
{
	// Declare an integer value to store the user's input
	int input;
	do
	{
	// Prompt the user to enter a positve, non-zero integer value
	cout << "\nPlease enter a positive, non-zero integer value to square..." << endl;
	cin >> input;

	// Pass this value to a funcion named calculateSquare // this function only works on positive, non-zero values
	try
	{
		int answer = calcSquare(input);
		cout << "\nThe value of your number squared is " << answer << endl;
	}
		// Exception 1) negative number
	catch (NegValueException n)
	{
		// display the bad value
		cout << "\nYou entered the value " << n.getBadValue() << endl;
		// indicate what the error was
		cout << n.what() << endl;
	}
		// Exception 2) number is 0
	catch (ZeroValueException n)
	{
		// display the bad value
		cout << "\nYou entered " << n.getBadValue() << endl;
		// indicate what the error was
		cout << n.what() << endl;
	}

	} while (input <= 0);

	system("PAUSE");
	return 0;
}


int calcSquare(int value)
{
	// Exception 1) negative number
	if (value < 0)
		throw NegValueException(value);

	// Exception 2) number is 0
	else if (value == 0)
		throw ZeroValueException(value);
	else
		return value * value;
}
