#include "Node.h"

class list
{
private:
	Node* firstPtr = nullptr;
	Node* lastPtr = nullptr;
	int count = 0;

public:
	// SingleList()
	// Purpose: default constructor for SingleList
	// Parameters: none
	// Returns: none
	SingleList();

	// ~List
	// Purpose: destructor for SingleList
	// Parameters: none
	// Returns: none
	~SingleList();

	// push_back
	// Purpose: adds a Node to the end of the List
	// Parameters: Node pointer
	// Returns: none
	void push_back(Node*);

	// push_front
	// Purpose: adds a Node to the front of the List
	// Parameters: Node pointer
	// Returns: none
	void push_front(Node*);

	// pop_back
	// Purpose: removes the last Node from the List
	// Parameters: none
	// Returns: pointer to the Node
	Node* pop_back();

	// pop_front
	// Purpose: removes the first Node from the List
	// Parameters: none
	// Returns: pointer to the Node
	Node* pop_front();

	// getFirst
	// Purpose: returns a pointer to the first Node in the List
	// Parameters: none
	// Returns: Node pointer
	Node* getFirst() const;

	// getLast
	// Purpose: returns a pointer to the last Node in the List
	// Parameters: none
	// Returns: Node pointer
	Node* getLast() const;
};