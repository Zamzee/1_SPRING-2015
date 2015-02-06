/////////////////////////////////////////
// File Prologue
// Author: Russell Andlauer
// Class: CS-2420-601
// Project: Program 2 - Linked Lists
// Date Last Modified: February 5th, 2015
/////////////////////////////////////////
#pragma once
#include "Node.h"

class SingleList
{
private:
	Node* head;
	int count;

public:
	// SingleList()
	// Purpose: default constructor for SingleList
	// Parameters: none
	// Returns: none
	SingleList();

	// ~List
	// Purpose: destructor for SingleList
	// Parameters: none
	// Returns: none
	~SingleList();

	// Name: insert
	// Purpose: Read an integer from a file and insert into a new Node
	// Parameters: integer
	// Returns: none
	void insert(int);

	// Name: traverse
	// Purpose: Travel through the list visiting each Node in the list
	// Parameters: none
	// Returns: none
	void traverse();

	// Name: traversePrint
	// Purpose: Travel through the list, Print out each Node's integer dataNum
	// Parameters: Node* and ????
	// Returns: none
	void traversePrint(void(*visit)(Node* p));
};