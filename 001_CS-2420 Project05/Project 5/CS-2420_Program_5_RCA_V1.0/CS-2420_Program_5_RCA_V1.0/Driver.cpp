// File Prologue
// Name: Russell Andlauer
// Class: CS-2420-601
// Program 5: Hashing
// Date Last Modified: April 1st, 2015
// Description: This program offers practice implementing a hash table 
//              and a hash function using a file containing a set of integers.
//////////////////////////////////////////////////////////////////////////////
#include <string>
#include <fstream>
#include <iostream>
#include "Hash.h"
using namespace std;

int main()
{

	// Program Introduction
	cout << "Name: Russell Andlauer\nClass: CS-2420-601\nProgram 5: Hashing\n";
	cout << "Description: This program offers practice implementing a hash table\n\t\tand a hash function using a file containing a set of integers.\n";
	cout << "================================================================================\n";

	// Start of Program

	// 1.	Create an instance of the Hash class (make sure it is initialized by the default constructor).
	Hash hashTable = Hash();

	// Create Variables to read in data
	ifstream inputFile;
	string fileName;
	int data;

	// 2.	Prompt the user to enter the name and the path of the file to be read from
	cout << "\nPlease enter the name of the data file: ";
	cin >> fileName;

	// Open file, check for read error
	inputFile.open(fileName);

	// if there is a read error, inform user and exit
	if (inputFile.fail())
	{
		cout << "Error opening " << fileName << endl;
		system("pause");
		return 1;
	}

	// Print data from file
	cout << "\nContents of the Data File" << endl;

	// 3.	Read an element from the file, if the end of the file is encountered continue with step 6
	while (!inputFile.eof())
	{
		inputFile >> data;

		cout << data << endl;

		// 4.	Call the Hash function to get the location where the integer should be stored
		hashTable.getHashValue(data);

		// 5.	Call the Insert function to store the integer
		hashTable.insert(data, hashTable.getHashValue(data));
			// a. If (the Insert function succeeds) repeat with step 3

			// b. If the (Insert function fails) (collision is detected)
		if (!hashTable.insert(data,hashTable.getHashValue(data)))
		{
			// 1) Print the error message
			cout << "\nCollision detected ... Resolving ...\n";

			// 2) then resolve the collision by calling the Resolve Collision function, repeat with step 3. 
			hashTable.resolveCollision(data, hashTable.getHashValue(data));
		}
			// If (the array is full) and (the Resolve Collision function fails)


	}

	// Close file
	inputFile.close();

	// 6.	After processing all of the integers in the file, call the Show function to print the contents of the Hash table.

	

	// End of Program
	cout << "\nProgram Complete" << endl;


	system("pause");
	return 0;
}