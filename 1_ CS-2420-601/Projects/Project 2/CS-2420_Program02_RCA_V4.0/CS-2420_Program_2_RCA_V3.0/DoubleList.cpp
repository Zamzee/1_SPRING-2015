/////////////////////////////////////////
// File Prologue
// Author: Russell Andlauer
// Class: CS-2420-601
// Project: Program 2 - Linked Lists
// Date Last Modified: February 5th, 2015
/////////////////////////////////////////
#include "DoubleList.h"


DoubleList::DoubleList()
{
	head = nullptr;
	count = 0;
}

DoubleList::DoubleList(SingleList n)
{
	// Node* Cursor = n->head
	// else 
	// if (cursor->dataNum < doubleHead
	// Make connections lhLink

}

DoubleList::~DoubleList()
{
}

void DoubleList::insertSort(void(*visit)(Node* p))
{
	Node* slNode = new Node(Node* p);

	if (head == nullptr)
	{
		head = slNode;
		head->rhLink = nullptr;
	}

	else
	{
		Node* r = head;
		Node* s = nullptr;

		while (r != nullptr && slDataNum > r->dataNum)
		{
			s = r;
			r = r->rhLink;
		}

		if (r == nullptr)
		{
			s->rhLink = r;
			r->lhLink = s;
			head = r;
		}

		else
		{
			if (s == nullptr)
			{
				r->rhLink = slNode;
				slNode->lhLink = s;
				slNode->rhLink = nullptr;
			}
		}
	}
}

void DoubleList::traverse(void(*visit)(Node* n))
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

// TraversePrint

// sort()