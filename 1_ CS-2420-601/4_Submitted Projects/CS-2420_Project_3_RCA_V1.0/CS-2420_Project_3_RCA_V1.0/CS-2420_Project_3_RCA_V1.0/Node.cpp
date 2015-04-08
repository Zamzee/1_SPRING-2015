/////////////////////////////////////////
// File Prologue
// Author: Russell Andlauer
// Class: CS-2420-601
// Project: Program 3 - Stack and Queue
// Date Last Modified: February 15th, 2015
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