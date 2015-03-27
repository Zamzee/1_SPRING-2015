// File Prologue
/////////////////////////////////////////
// Class: CS-2420
// Project: Program 2 - Linked Lists
// Name: Russell Andlauer
// Date Last Modified: February 3rd, 2015
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

	if (head == nullptr)
	{
		head = q;
		head->rhLink = nullptr;
	}

	else
	{
		p = head;
		while (p->rhLink != nullptr)
		{
			p = p->rhLink;
			//cout << count;
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