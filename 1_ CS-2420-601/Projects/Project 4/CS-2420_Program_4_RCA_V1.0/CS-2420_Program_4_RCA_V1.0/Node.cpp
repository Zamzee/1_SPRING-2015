// File Prologue
// Name: Russell Andlauer
// Class: CS-2420-601
// Program 4: AVL Binary Search Tree
// Date Last Modified: March 16th, 2015
// Description: This program reads in integers from a text file and organizes them into an AVL Binary Search Tree. 
// The program then prints out each node of the AVL tree using both inorder and preorder traversal
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#include "Node.h"

Node::Node()
{
	lChild = nullptr;
	rChild = nullptr;
	Node_dataNum dataNum = 0;
	int balanceFactor = 0;
}

Node::Node(int inputNum)
{
	lChild = nullptr;
	rChild = nullptr;
	dataNum = inputNum;
	balanceFactor = 0;
}

//Node::~Node()
//{
//	rChild = nullptr;
//	lChild = nullptr;
//}