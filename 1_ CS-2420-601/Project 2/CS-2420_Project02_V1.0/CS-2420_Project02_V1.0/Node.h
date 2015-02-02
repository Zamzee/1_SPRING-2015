#pragma once
#include <string>
#include <iostream>
using namespace std;

class Node
{
private:
	Node* lhLink = nullptr;
	Node* rhLink = nullptr;
	int dataNum = 0;


public:
	// Node()
	// Purpose: default constructor
	// Parameters: none
	// Returns: none
	Node();

	// Node()
	// Purpose: parameterized constructor
	// Parameters: int dataNum, Node* previous, Node* follow
	// Returns: none
	Node(int numInput, Node* previous = nullptr, Node* follow = nullptr);


	// ~Node()
	// Purpose: destructor for the Node
	// Parameters: none
	//Returns: none
	~Node();

	// setlhLink
	// Purpose: setter for lhLink pointer
	// Parameters: Node*
	// Returns: none
	void setlhLink(Node*);

	// setrhLink
	// Purpose: setter for rhLink pointer
	// Parameters: Node*
	// Returns: none
	void setrhLink(Node*);

	// getlhLink
	// Purpose: getter for lhLink pointer
	// Parameters: none
	// Returns: Node pointer
	Node* getlhLink() const;

	// getRhLink
	// Purpose: getter for RhLink pointer
	// Parameters: none
	// Returns: Node pointer
	Node* getrhLink() const;
};