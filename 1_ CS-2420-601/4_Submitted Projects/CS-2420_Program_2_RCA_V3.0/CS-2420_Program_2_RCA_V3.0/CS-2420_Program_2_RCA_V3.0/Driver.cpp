/////////////////////////////////////////
// File Prologue
// Author: Russell Andlauer
// Class: CS-2420-601
// Project: Program 2 - Linked Lists
// Date Last Modified: February 5th, 2015
/////////////////////////////////////////

#include "SingleList.h"
#include "DoubleList.h"
#include "Node.h"
#include <string>
#include <fstream>
#include <iostream>
#include <iomanip>
using namespace std;

// print
// Purpose: Print integer data member of a Node
// Parameters: Node*
// Returns: none
void print(Node*);

int main()
{
	int tempInt = 0;
	string textFileName;
	SingleList singleListA;
	ifstream idataFile;
	// DoubleLink* dL = new DoubleLink;

	// Print Name, Class, Section Number, Program Number
	cout << "Russell Andlauer\nCS-2420-601\nProgram 2: Linked Lists" << endl;

	// Prompt user for the filename (Handle Exception for improper opening)
	cout << "\nPlease enter the name of the file to read the integers from..." << endl;

	cin >> textFileName;

	// If user types 'exit', close program.

	idataFile.open(textFileName);

	// Open the file
	if (idataFile.fail())
		cout << "couldn't open file." << endl;

	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	// Fixing the idataFile check
	// If user enters an invalid file name, Prompt user to enter the correct file name
	//while (!idataFile.is_open())  //fileName.c_str() == "exit"
	//{
	//	cout << "\nFile did not open, incorrect file name.\nPlease enter the name of the file you want to open (without .txt). ";
	//	cout << "\n\tor\nEnter 'exit' to close program." << endl;
	//	cin >> textFileName;

	//if (textFileName == "exit") // If user types 'exit', close program.
	//{
	//	exit(1);
	//}
	//else // If user enters correct file name, open textFileName
	//idataFile.open(textFileName);
	//}
	/////////////////////////////////////////////////////////////////////////////////////////////
	// Check for end of file
	//while (!(idataFile.eof()))
	//{	

	// Read an integer from the file
	while (idataFile >> tempInt)
	{
		// Insert the integer into a new Node and add the Node to the end of a single-linked list
		// Repeat until end of file is reached
		singleListA.insert(tempInt);
	}


	// Print each integer from the single linked list using the traverse function, passing the print function as a parameter
	cout << "\nSingle List:";
	singleListA.traversePrint(print);
	cout << endl;

	// Traverse the single linked list Node by Node for each Node in the list
	// Insert the integer from each node in the single linked list into the double linked list in ascending order
	// Print each integer from the double linked list using the traverse function, passing the print function as a parameter

	system("pause");
	return 0;
}

void print(Node* p)
{
	cout << "\n" << p->dataNum;
}