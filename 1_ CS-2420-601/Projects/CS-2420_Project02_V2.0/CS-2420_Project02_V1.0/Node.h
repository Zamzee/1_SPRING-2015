// File Prologue
/////////////////////////////////////////
// Class: CS-2420
// Project: Program 2 - Linked Lists
// Name: Russell Andlauer
// Date Last Modified: February 3rd, 2015
/////////////////////////////////////////

#pragma once
#include <string>
#include <iostream>
using namespace std;

struct Node
{
	Node* lhLink;
	Node* rhLink;
	int dataNum;

	// Node()
	// Purpose: default constructor
	// Parameters: none
	// Returns: none
	Node();

	// Node()
	// Purpose: parameterized constructor
	// Parameters: int dataNum
	// Returns: none
	Node(int);


	// ~Node()
	// Purpose: destructor for the Node
	// Parameters: none
	//Returns: none
	~Node();
};