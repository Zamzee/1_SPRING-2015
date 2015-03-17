/////////////////////////////////////////
// File Prologue
// Author: Russell Andlauer
// Class: CS-2420-601
// Project: Program 3 - Stack and Queue
// Date Last Modified: February 15th, 2015
/////////////////////////////////////////

#include "Queue.h"


Queue::Queue()
{
	Node* front = nullptr;
	Node* rear = nullptr;
}


Queue::~Queue()
{
	Node* front = nullptr;
	Node* rear = nullptr;
}

void Queue::append(int n)
{
	Node* p = new Node(n);

	// If the Queue is empty
	if (front == nullptr)
	{
		front = p;
		rear = front;
	}

	// If the Queue is not empty
	else
	{
		rear->rhLink = p;
		rear = p;
	}

	statusCode = 0;
}

int Queue::serve()
{
	Node* p = new Node();
	int tempNum;

	// If Queue is empty
	if (front == nullptr)
	{
		statusCode = 1;
		return -1;
	}

	else
	{
		tempNum = front->dataNum;
		// If there is only one element in the Queue
		if (front == rear)
		{
			delete front;
			front = nullptr;
		}

		// If there more than one element in the Queue
		else
		{
			p = front;
			front = front->rhLink;
			delete p;
			p = nullptr;
		}
		statusCode = 0;
	}

	return tempNum;
}

int Queue::getStatusCode()
{
	return statusCode;

}