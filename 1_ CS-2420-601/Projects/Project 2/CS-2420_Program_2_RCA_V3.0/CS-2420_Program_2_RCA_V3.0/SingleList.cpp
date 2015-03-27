/////////////////////////////////////////
// File Prologue
// Author: Russell Andlauer
// Class: CS-2420-601
// Project: Program 2 - Linked Lists
// Date Last Modified: February 5th, 2015
/////////////////////////////////////////

#include "SingleList.h"

SingleList::SingleList()
{
	Node* head = nullptr;
	int count = 0;
}

SingleList::~SingleList()
{
	Node* p = nullptr;
	p = head;
	while (p != nullptr)
	{
		p = head->rhLink;
		delete head;
		head = p;
		count = 0;
	}
}

void SingleList::insert(int inputNum)
{
	Node* p = nullptr;
	Node* q = new Node(inputNum);

	// If new Node is the first Node in the SingleList
	if (head == nullptr)
	{
		head = q;
		head->rhLink = nullptr;
	}

	// If new Node is not the first Node in the SingleList
	else
	{
		p = head;
		while (p->rhLink != nullptr)
		{
			p = p->rhLink;
		}
		p->rhLink = q;
		q->rhLink = nullptr;

	}
	// Increment count by one for the new Node
	count++;
}

void SingleList::traverse()
{
	if (head == nullptr)
		cout << "The list is empty";
	else
	{
		Node* p;
		p = head;
		while (p != nullptr)
		{
			p = p->rhLink;
		}
	}
}

void SingleList::traversePrint(void(*visit)(Node* p))
{
	Node* p;
	p = head;

	while (p != nullptr)
	{
		(*visit)(p);
		p = p->rhLink;
	}
}