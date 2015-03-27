// File Prologue
/////////////////////////////////////////
// Class: CS-2420
// Project: Program 2 - Linked Lists
// Name: Russell Andlauer
// Date Last Modified: February 3rd, 2015
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