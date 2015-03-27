// File Prologue
// Name: Russell Andlauer
// Class: CS-2420-601
// Program 4: AVL Binary Search Tree
// Date Last Modified: March 14th, 2015
// Description: This program reads in integers from a text file and organizes them into an AVL Binary Search Tree. 
// The program then prints out each node of the AVL tree using both inorder and preorder traversal
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#pragma once
using namespace std;

struct Node
{
	Node* lChild;
	Node* rChild;
	int dataNum;

	// Node()
	// Purpose: Default Constructor for the Node object
	// Parameters: none
	// Returns: none                                                                                                                                     
	Node();

	// Node()
	// Purpose: Parameterized Constructor for the Node object
	// Parameters: int dataNum
	// Returns: none
	Node(int);


	// ~Node()
	// Purpose: Destructor for the Node object
	// Parameters: none
	//Returns: none
	~Node();
};
