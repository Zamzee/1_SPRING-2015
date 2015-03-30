// File Prologue
// Name: Russell Andlauer
// Class: CS-2420-601
// Program 5: Hashing
// Date Last Modified: March 30th, 2015
// Description: This program offers practice implementing a hash table and a hash function using a file containing a set of integers.
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#include <string>
#include <fstream>
#include <iostream>
#include "Hash.h"
using namespace std;

int main()
{

	// Program Introduction
	cout << "Name: Russell Andlauer\nClass: CS-2420-601\nProgram 5: Hashing\n";
	cout << "Description:\n";
	cout << "==============================================================\n";

	// Start of Program

	// Create Variables to read in data
	ifstream inputFile;
	string fileName;
	int data;

	//  Prompt User to enter the name of the file to be read from
	cout << "\nPlease enter the name of the data file: ";
	cin >> fileName;

	// Open file, check for read error
	inputFile.open(fileName);
	if (inputFile.fail())
	{
		cout << "Error opening " << fileName << endl;
		system("pause");
		return 1;
	}

	// Print data from file

	cout << "\nContents of the Data File" << endl;

	while (!inputFile.eof())
	{
		inputFile >> data;

		cout << data << endl;
	}

	// Close file
	inputFile.close();

	cout << "Program Complete" << endl;


	system("pause");
	return 0;
}
