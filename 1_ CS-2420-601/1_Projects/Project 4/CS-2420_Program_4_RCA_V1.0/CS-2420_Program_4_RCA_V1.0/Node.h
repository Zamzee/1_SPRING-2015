// File Prologue
// Name: Russell Andlauer
// Class: CS-2420-601
// Program 4: AVL Binary Search Tree
// Date Last Modified: March 16th, 2015
// Description: This program reads in integers from a text file and organizes them into an AVL Binary Search Tree. 
// The program then prints out each node of the AVL tree using both inorder and preorder traversal
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#pragma once
#include <iostream>
using namespace std;

typedef int Node_dataNum;
struct Node
{
	Node* lChild;
	Node* rChild;
	Node_dataNum dataNum;
	int balanceFactor;

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
	//~Node();
};
