// File Prologue
// Name: Russell Andlauer
// Class: CS-2420-601
// Program 4: AVL Binary Search Tree
// Date Last Modified: March 14th, 2015
// Description: This program reads in integers from a text file and organizes them into an AVL Binary Search Tree. 
// The program then prints out each node of the AVL tree using both inorder and preorder traversal
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#include "Node.h"

Node::Node()
{
	Node* lChild = nullptr;
	Node* rChild = nullptr;
	int dataNum = 0;
}

Node::Node(int inputNum)
{
	dataNum = inputNum;
}

Node::~Node()
{
	rChild = nullptr;
	lChild = nullptr;
}