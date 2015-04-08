// Project: Project 1 'Recursion'
// Author: Russell Andlauer
// Course: CS-2420-601
// Date Last Modified: January 15th, 2015

#include <string>
#include <iomanip>
#include <fstream>
#include <iostream>
using namespace std;

//
//
//
//
int CalcFibNumRecursive(int n);

//
//
//
//
int CalcFibNumNonRecursive(int n);

int main()
{
	int fibNumRecursive = 0;
	int fibNumNonRecursive = 0;
	string textFileName;

	// Prompt user to enter the filename to be read from
	cout << "\nPlease enter the name of the file to read the integers from. (without .txt)..." << endl;
	cin.ignore(80, '\n');
	getline(cin, textFileName);

	// Open the file that the user selected
	ifstream idataFile(textFileName + ".txt");

	// If user enters an invalid file name, Prompt user to enter the correct file name
	while (!idataFile.is_open())
	{
		cout << "\nFile did not open, incorrect file name.\nPlease enter the name of the file you want to open (without .txt). ";
		cout << "\n\tor\nEnter 'exit' to close program." << endl;
		getline(cin, textFileName);

		if (textFileName == "exit") // If user types 'exit', close program.
		{
			exit(1);
		}
		else // If user enters correct file name, open textFileName
			idataFile.open(textFileName + ".txt");
	}

	cout << "\nThe Recursive Calculate Fibonacci Number Function" << endl;
	// Check for end of file
	while (idataFile.eof() == false)
	{
		// If not end of file, read integer and save into int fibNum
		idataFile >> fibNumRecursive;

		// Call recursive fibonacci number calculate function
		cout << "\t" << fibNumRecursive << "\t\t" << CalcFibNumNonRecursive(fibNumRecursive) << endl;

		// Print out int fibNum and result from fibonacci number calculate function
	}
	// If end of file

		// Close file
		
		// Re-open file to be read and calculated non-recursively

	cout << "\nThe Non - Recursive Calculate Fibonacci Number Function" << endl;
		// Open the file that the user selected
		ifstream idataFileTwo(textFileName + ".txt");

		// If user enters an invalid file name, Prompt user to enter the correct file name
		while (!idataFileTwo.is_open())
		{
			cout << "\nFile did not open, incorrect file name.\nPlease enter the name of the file you want to open (without .txt). ";
			cout << "\n\tor\nEnter 'exit' to close program." << endl;
			getline(cin, textFileName);

			if (textFileName == "exit") // If user types 'exit', close program.
			{
				exit(1);
			}
			else // If user enters correct file name, open textFileName
				idataFileTwo.open(textFileName + ".txt");
			}

		cout << "\nInteger Input:\tFibonacci Number" << endl;
		// Check for end of file
	while (idataFileTwo.eof() == false)
	{
		// If not end of file, read integer and  save into fibNumNonRecursive
		idataFileTwo >> fibNumNonRecursive;

		// Call calculate fibonacci function calculate non-recursively function
		cout << "\t" << fibNumNonRecursive << "\t\t" << CalcFibNumNonRecursive(fibNumNonRecursive) << endl;

		// Print out int fibNum and result from fibonacci number calculate non-recursively function

	}


	// If end of file

		// Close File, Exit
		
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
			secondNum = sum;
		}
		return sum;
	}
}