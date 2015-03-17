/////////////////////////////////////////
// File Prologue
// Author: Russell Andlauer
// Class: CS-2420-601
// Project: Program 3 - Stack and Queue
// Date Last Modified: February 15th, 2015
/////////////////////////////////////////

#pragma once
#include "Node.h"

class Queue
{
private:
	Node* front;
	Node* rear;
	int statusCode;

public:

	// Name: Queue()
	// Purpose: Default Constructor for a new Queue object
	// Parameters: none
	// Returns: none
	Queue();

	// Name: ~Queue()
	// Purpose: Destructor for the Queue object
	// Parameters: none
	// Returns: none
	~Queue();

	// Name: append()
	// Purpose: Add a new Node to the Queue
	// Parameters: none
	// Returns: none
	void append(int n);

	// Name: serve()
	// Purpose: Remove a Node from the Queue
	// Parameters: none
	// Returns: none
	int serve();

	// Name: getStatusCode()
	// Purpose: Display Status of the Queue Operations, 0 = Success, 1 = Underflow
	// Parameters: none
	// Returns: integer representing the Status Code
	int getStatusCode();
};

