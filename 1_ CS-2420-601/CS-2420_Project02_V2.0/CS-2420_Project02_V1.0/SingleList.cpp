#include "SingleList.h";

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
		q = head;
		while (q->rhLink != nullptr)
		{
			q = q->rhLink;
		}
		p->rhLink = q;
		q->rhLink = nullptr;

	}
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