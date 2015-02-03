#include "Node.h"

class DoubleList
{
private:
	Node* head = nullptr;
	int count = 0;

public:
	// DoubleList()
	// Purpose: default constructor for DoubleList
	// Parameters: none
	// Returns: none
	DoubleList();

	// ~List
	// Purpose: destructor for DoubleList
	// Parameters: none
	// Returns: none
	~DoubleList();

	//
	//
	//
	//
	void insertOrder(int);

	//
	//
	//
	//
	void traverse();

	//
	//
	//
	//
	void traversePrint(void(*visit)(Node* p));

};