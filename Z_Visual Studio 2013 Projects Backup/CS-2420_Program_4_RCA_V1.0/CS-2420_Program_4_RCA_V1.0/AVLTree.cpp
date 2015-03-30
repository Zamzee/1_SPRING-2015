// File Prologue
// Name: Russell Andlauer
// Class: CS-2420-601
// Program 4: AVL Binary Search Tree
// Date Last Modified: March 16th, 2015
// Description: This program reads in integers from a text file and organizes them into an AVL Binary Search Tree. 
// The program then prints out each node of the AVL tree using both inorder and preorder traversal
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#include "AVLTree.h"


AVLTree::AVLTree()
{
	count = 0;
	root = nullptr;
}


//AVLTree::~AVLTree()
//{
//}

void AVLTree::insert(int num)
{
	if (root == nullptr)
	{
		root = new Node(num);
	}

	else
	{
		Node* p = root;
		Node* q = nullptr;

		while (p != nullptr && p->dataNum != num)
		{
			q = p;
			if (num < p->dataNum)
			{
				p = p->lChild;
			}
			else
			{
				p = p->rChild;
			}
		}
		if (p != nullptr && p->dataNum == num)
		{
			cout << "Duplicate Data->";
		}
			else
			{
				if (num < q->dataNum)
				{
					q->lChild = new Node(num);
				}
				else
				{
					q->rChild = new Node(num);
				}
			}
	}
	count++;
}

int AVLTree::max(int a, int b)
{
	int m = a;
	if (b > a)
	{
		m = b;
	}
	return m;
}

int AVLTree::height(Node* p)
{
	if (p == nullptr)
	{
		return 0;
	}

	if ((p->lChild == nullptr) && (p->rChild == nullptr))
	{
		return 1;
	}

	else
	{
		return 1 + max(height(p->lChild), height(p->rChild));
	}
}

void AVLTree::balFactor(Node* p)
{
	if (p != nullptr)
	{
		p->balanceFactor = height(p->lChild) - height(p->rChild);
		balFactor(p->lChild);
		balFactor(p->rChild);
	}

}


void AVLTree::traverseInOrder(Node* r)
{
	if (r != nullptr)
	{
		traverseInOrder(r->lChild);
		cout << "\n" << r->dataNum << " " << r->balanceFactor;
		traverseInOrder(r->rChild);
	}
}


Node* AVLTree::getRoot() const
{
	return root;
}

void AVLTree::performRotation(Node* r)
{
	Node* p = nullptr;
	Node* q = nullptr;

	p = r->lChild;
	q = r->rChild;

	// Tree is Left-Heavy
	if (r->balanceFactor == +2)
	{
		// LL Case
		if (r->lChild->balanceFactor >= 0)
		{
			// (Left Child) becomes (Parent)
			p = r;

			// (Parent) becomes (Left Child's Right Child)
			q = r->lChild->rChild;

			// (Left Child's Right Child) becomes (Parent's Left Child)
			p->lChild = r;

		}

		else
		// LR Case
		{
			// (Left Child) becomes (Left Child's Right Child's Left Child)

			// (Parent) becomes (Left Child's Right Child's Right Child)

			// (Left Child's Right Child's Right Child) becomes (Parent's Left Child)

			// (Left Child's Right Child's Left Child) becomes (Left Child's Right Child)
		}
	}

	// Tree is Right-Heavy
	if (r->balanceFactor == -2)
	{
		if (r->rChild->balanceFactor <= 0)
		{
			// (Right Child becomes (Parent)

			// (Parent) becomes (Right Child's Left Child)

			// (Right Child's Left Child) becomes (Parent's Right Child)
		}
		else
		// LR Case
		{
			// (Right Child) becomes (Right Child's Left Child's Right Child)

			// (Parent) becomes (Right Child's Left Child's Left Child)

			// (Right Child's Left Child's Left Child) becomes (Parent's Right Child)

			// (Right Child's Left Child's Right Child) becomes (Right Child's Left Child)
		}
	}

}
