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
#pragma once
#include <string>;
using namespace std;

class ZeroValueException
{
public:
	ZeroValueException();
	ZeroValueException(int theBadNum);
	string what() const;
	int getBadValue() const;

private:
	int theValue;
	string theMessage;
};

