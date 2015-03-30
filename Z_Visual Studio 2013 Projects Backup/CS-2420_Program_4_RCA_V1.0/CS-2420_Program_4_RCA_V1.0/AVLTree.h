// File Prologue
// Name: Russell Andlauer
// Class: CS-2420-601
// Program 4: AVL Binary Search Tree
// Date Last Modified: March 16th, 2015
// Description: This program reads in integers from a text file and organizes them into an AVL Binary Search Tree. 
// The program then prints out each node of the AVL tree using both inorder and preorder traversal
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#pragma once
#include "Node.h"

class AVLTree
{
protected:
	int count;
	Node* root;

public:
	// AVLTree
	// Purpose: Default Constructor for the AVLTree object
	// Parameters: none
	// Returns: none    
	AVLTree();

	//~AVLTree();

	// insert
	// Purpose: Insert a new Node into the AVL Tree
	// Parameters: integer from the datafile
	// Returns: none
	void insert(int);

	// max
	// Purpose: Determine which integer is larger
	// Parameters: two integers
	// Returns: the larger integer
	int max(int, int);


	// height
	// Purpose: Determine the height of a Node in the AVL Tree
	// Parameters: Node pointer
	// Returns: integer representing the Node's height
	int height(Node*);

	// balFactor
	// Purpose: Determine the balance factor for a Node in the AVL Tree
	// Parameters: Node pointer
	// Returns: none
	void balFactor(Node*);

	// traverseInOrder
	// Purpose: Traverse the AVL Tree inorder
	// Parameters: Node*
	// Returns: none
	void traverseInOrder(Node* r);

	// getter for root
	Node* getRoot() const;

	// performRotation
	// Purpose: Determine which of the 4 cases the inbalance is and rotate accordingly
	// Parameters: Node* (the first Node that is out of balance)
	// Returns: none
	void performRotation(Node*);



};

