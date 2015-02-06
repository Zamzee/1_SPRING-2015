/////////////////////////////////////////
// File Prologue
// Author: Russell Andlauer
// Class: CS-2420-601
// Project: Program 2 - Linked Lists
// Date Last Modified: February 5th, 2015
/////////////////////////////////////////
#pragma once
#include "Node.h"
#include "SingleList.h"

class DoubleList
{
private:
	Node* head = nullptr;
	int count = 0;

public:
	// DoubleList()
	// Purpose: default constructor for DoubleList
	// Parameters: none
	// Returns: none
	DoubleList();
	
	//
	//
	//
	//
	DoubleList(SingleList n);

	// ~List
	// Purpose: destructor for DoubleList
	// Parameters: none
	// Returns: none
	~DoubleList();

	//
	//
	//
	//
	void insertOrder(int);

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