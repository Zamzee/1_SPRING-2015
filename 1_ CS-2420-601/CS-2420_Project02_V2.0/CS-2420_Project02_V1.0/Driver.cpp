// File Prologue
/////////////////////////////////////////
// Class: CS-2420
// Project: Program 2 - Linked Lists
// Name: Russell Andlauer
// Date Last Modified: January 31st, 2015
/////////////////////////////////////////
#include "SingleList.h";
#include "DoubleList.h";
#include "Node.h";
#include <string>
#include <fstream>
#include <iostream>
#include <iomanip>
using namespace std;

//
//
//
//
void print(Node*);

int main()
{
	int tempInt;
	string textFileName;
	SingleList singleList;
	ifstream idataFile;
	// DoubleLink* dL = new DoubleLink;

	// Print Name, Class, Section Number, Program Number
	cout << "Russell Andlauer\n" << "CS-2420-601\n" << "Program 2: Linked Lists" << endl;

	// Prompt user for the filename (Handle Exception for improper opening)
	cout << "\nPlease enter the name of the file to read the integers from. (without .txt)..." << endl;
	cin >> textFileName;

	// Open the file
	
	idataFile.open(textFileName + ".txt");

	// If user enters an invalid file name, Prompt user to enter the correct file name
	while (!idataFile.fail())
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
	if (idataFile.is_open())
	{
		// Check for enf of file
		while (idataFile >> tempInt)
		{
			// Read an integer from the file
			singleList.insert(tempInt);
			// Insert the integer into a new node and add it at the end of a single linked list
		}
		cout << "\nSingle List:";
			singleList.traversePrint(print);
		cout << endl;
			// Repeat previous step until end of file is reached

			// Traverse the single linked list bode by node for each node in the list

			// Insert the integer from each node in the single linked list into the double linked list in ascending order

			// Print each integer from the single linked list using the traverse function, passing the print function as a parameter

			// Print each integer from the double linked list using the traverse function, passing the print function as a parameter
		
	}
	system("pause");
	return 0;
}

void print(Node* p)
{
	cout << "\n" << p->dataNum;
}