/////////////////////////////////////////
// File Prologue
// Author: Russell Andlauer
// Class: CS-2420-601
// Project: Program 3 - Stack and Queue
// Date Last Modified: February 15th, 2015
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
	// Purpose: Default Constructor for the Node object
	// Parameters: none
	// Returns: none                                                                                                                                     
	Node();

	// Node()
	// Purpose: Parameterized Constructor for the Node object
	// Parameters: int dataNum
	// Returns: none
	Node(int);


	// ~Node()
	// Purpose: Destructor for the Node object
	// Parameters: none
	//Returns: none
	~Node();
};