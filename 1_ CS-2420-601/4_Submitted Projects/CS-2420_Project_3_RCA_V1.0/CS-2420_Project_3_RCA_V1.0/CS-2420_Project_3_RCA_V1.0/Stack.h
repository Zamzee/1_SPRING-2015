/////////////////////////////////////////
// File Prologue
// Author: Russell Andlauer
// Class: CS-2420-601
// Project: Program 3 - Stack and Queue
// Date Last Modified: February 15th, 2015
/////////////////////////////////////////

#pragma once
#include "Node.h"

class Stack
{
private:
	Node* top;
	int statusCode;

public:
	// Name: Stack()
	// Purpose: default constructor for a new Stack object
	// Parameters: none
	// Returns: none
	Stack();

	// Name: ~Stack()
	// Purpose: destructor for the Stack object
	// Parameters: none
	// Returns: none
	~Stack();

	// Name: push()
	// Purpose: Add a new Node to the Stack
	// Parameters: none
	// Returns: none
	void push( int);

	// Name: pop()
	// Purpose: Remove a Node from the Stack
	// Parameters: none
	// Returns: none
	void pop();

	// Name: getStatusCode()
	// Purpose: Display Status of the Stack Operations, 0 = Success, 1 = Underflow
	// Parameters: none
	// Returns: integer representing the Status Code
	int getStatusCode();

};

