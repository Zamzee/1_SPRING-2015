#include "Node.h";

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