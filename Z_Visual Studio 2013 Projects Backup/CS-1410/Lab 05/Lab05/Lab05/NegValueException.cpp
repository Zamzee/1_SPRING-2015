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
#include "NegValueException.h"


NegValueException::NegValueException()
{
	theValue = 0;
	theMessage = "unknown error";
}

NegValueException::NegValueException(int theBadValue)
{
	theValue = theBadValue;
	theMessage = "\nThe value passed to the calcSquare function was negative...";
}

string NegValueException::what() const
{
	return theMessage;
}

int NegValueException::getBadValue() const
{
	return theValue;
}