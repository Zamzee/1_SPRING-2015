// File Prologue
// CS-1410-001
// Author: Russell Andlauer
// Date Last Modified: August 27, 2014
// ---------------------------------------

// // I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.
// ---------------------------------------

#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	// declarations
	int age;
	float value;
	string name;

	// Prompt the user for their age
	cout << "\n How old are you? ";

    // Get their age and store it in the variable age
	cin >> age;

    // Prompt the user for how much money they have
	cout << "\n How much money do you have? ";

    // Get the amount of money and store it in the variable value
	cin >> value;

    // Prompt the user to enter their full name.
	cout << " What is your full name? ";

    // created a buffer for the getline function to work properly
	string remainder;
	getline(cin, remainder);

    // Get their name and store it in the string variable name
	getline(cin, name);

    // Now display the following:
    //    The person's name. You must display the full name
	cout << "\n Thank you, " << name << endl;

    //    The person's age
	cout << "\n You are " << age << " years old." << endl;

    //    The money the person has. Display a dollar sign and two digits after the decimal point.
	cout << "\n You have $" << fixed << setprecision(2) << value << "\n ";

	system ("PAUSE");
	return 0;
}