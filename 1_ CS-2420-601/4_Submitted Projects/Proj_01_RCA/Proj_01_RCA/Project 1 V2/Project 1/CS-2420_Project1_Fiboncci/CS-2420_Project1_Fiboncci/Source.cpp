// File Prologue
// Course: CS-2420-601
// Project: Project 1 'Recursion'
// Author: Russell Andlauer
// Date Last Modified: January 16th, 2015
///////////////////////////////////////////////////////////////////////////
// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.
///////////////////////////////////////////////////////////////////////////
#include <string>
#include <iomanip>
#include <fstream>
#include <iostream>
using namespace std;

// CalcFibNumRecursive
// Purpose: Calculate the Fibonacci Number using recursion
// Parameters: integer n
// Returns: integer
int CalcFibNumRecursive(int n);

// CalcFibNumNonRecursive
// Purpose: Calculate the Fibonacci Number without using recursion
// Parameters: integer n
// Returns: integer
int CalcFibNumNonRecursive(int n);

int main()
{
	// Declare Variables
	int fibNumRecursive = 0;
	int fibNumNonRecursive = 0;
	string textFileName;

	// Prompt user to enter the filename to be read from
	cout << "\nPlease enter the name of the file to read the integers from. (without .txt)..." << endl;
	cin >> textFileName;

	// Open the file that the user selected
	ifstream idataFile;
	idataFile.open(textFileName + ".txt");

	// If user enters an invalid file name, Prompt user to enter the correct file name
	while (idataFile.fail())
	{
		cout << "\nFile did not open, incorrect file name.\nPlease type the name of the file you want to open (without .txt).\n\tor\nType 'exit' to close program.";
		getline(cin, textFileName);

		if (textFileName == "exit") // If user types 'exit', close program.
		{
			exit(1);
		}
		else // If user enters correct file name, open textFileName
			idataFile.open(textFileName + ".txt");
	}

	// Display Formatting
	cout << "\nThe Recursive Calculate Fibonacci Number Function" << endl;
	cout << "\nInteger Input:\tFibonacci Number" << endl;

	// Check for end of file
	while (idataFile.eof() == false)
	{
		// If not end of file, read integer and save into int fibNum
		idataFile >> fibNumRecursive;

		// Call recursive fibonacci number calculate function
		// Print out int fibNum and result from fibonacci number calculate function
		cout << "\t" << fibNumRecursive << "\t\t" << CalcFibNumRecursive(fibNumRecursive) << endl;
	}
	// If end of file
		// Close file
		idataFile.close();
		system("PAUSE");

	// Re-open file to be read and calculated non-recursively
	cout << "\nThe Non-Recursive Calculate Fibonacci Number Function" << endl;

	// Open the file that the user selected
	idataFile.open(textFileName + ".txt");

	// Display Formatting
	cout << "\nInteger Input:\tFibonacci Number" << endl;

	// Check for end of file
	while (idataFile.eof() == false)
	{
		// If not end of file, read integer and  save into fibNumNonRecursive
		idataFile >> fibNumNonRecursive;

		// Print out int fibNum and result from CalcFibNumNonRecursive function
		cout << "\t" << fibNumNonRecursive << "\t\t" << CalcFibNumNonRecursive(fibNumNonRecursive) << endl;
	}

	// If end of file
		// Close File
	idataFile.close();
		// Exit
	system("PAUSE");
	return 0;
}

int CalcFibNumRecursive(int n)
{
	if (n == 0 || n < 0)
	{
		return 0;
	}

	else if (n == 1)
	{
		return 1;
	}

	else
	{
		return CalcFibNumRecursive(n - 2) + CalcFibNumRecursive(n - 1);
	}
}

int CalcFibNumNonRecursive(int n)
{
	if (n == 0 || n < 0)
	{
		return 0;
	}

	else if (n == 1)
	{
		return 1;
	}
	
	else
	{
		int firstNum = 0;
		int secondNum = 1;
		int sum = 0;

		for (int i = 0; i < (n - 1); i++)
		{
			sum = firstNum + secondNum;
			firstNum = secondNum;
			secondNum = sum;
		}
		return sum;
	}
}