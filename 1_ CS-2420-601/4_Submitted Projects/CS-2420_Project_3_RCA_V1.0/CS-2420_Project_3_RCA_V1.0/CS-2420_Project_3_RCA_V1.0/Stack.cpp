/////////////////////////////////////////
// File Prologue
// Author: Russell Andlauer
// Class: CS-2420-601
// Project: Program 3 - Stack and Queue
// Date Last Modified: February 15th, 2015
/////////////////////////////////////////

#include "Stack.h"

Stack::Stack()
{
	top = nullptr;
}


Stack::~Stack()
{
	top = nullptr;
}

void Stack::push(int n)
{
	Node* p = new Node(n);

	// If Stack is empty
	if (top == nullptr)
	{
		top = p;
	}
	// If the Stack is not empty
	else
	{
		p->rhLink = top;
		top = p;
	}
	statusCode = 0;

}

void Stack::pop()
{
	Node* p = new Node();

	// If the Stack is empty
	if (top == nullptr)
	{
		// Underflow
		statusCode = 1;
	}

	// If the Stack has at least one element
	else
		if (top->rhLink == nullptr)
		{
			delete top;
			top = nullptr;
		}
		else
		{
			p = top;
			top = top->rhLink;
			delete p;
			p = nullptr;
		}
	// No Error
	statusCode = 0;
}

int Stack::getStatusCode()
{
	return statusCode;
}
