/////////////////////////////////////////
// File Prologue
// Author: Russell Andlauer
// Class: CS-2420-601
// Project: Program 2 - Linked Lists
// Date Last Modified: February 5th, 2015
/////////////////////////////////////////

#include "Node.h"

Node::Node()
{
	Node* lhLink = nullptr;
	Node* rhLink = nullptr;
	int dataNum = 0;
}

Node::Node(int inputNum)
{
	dataNum = inputNum;
}

Node::~Node()
{
	rhLink = nullptr;
	lhLink = nullptr;
}