// File Prologue
/////////////////////////////////////////
// Class: CS-2420
// Project: Program 2 - Linked Lists
// Name: Russell Andlauer
// Date Last Modified: February 3rd, 2015
/////////////////////////////////////////

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

	//
	//
	//
	//
	void insert(int);

	//
	//
	//
	//
	void traverse();

	//
	//
	//
	//
	void traversePrint(void(*visit)(Node* p));

};