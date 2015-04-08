// File Prologue
// Name: Russell Andlauer
// Class: CS-2420-601
// Program 4: AVL Binary Search Tree
// Date Last Modified: March 14th, 2015
// Description: This program reads in integers from a text file and organizes them into an AVL Binary Search Tree. 
// The program then prints out each node of the AVL tree using both inorder and preorder traversal
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#include <string>
#include <fstream>
#include <iostream>
using namespace std;

int main()
{
	// Program Introduction
	cout << "Name: Russell Andlauer\nClass: CS-2420-601\nProgram 4: AVL Binary Search Tree\n";
	cout << "Description:\n This program reads in integers from a text file\n and organizes them into an AVL Binary Search Tree. \n The program then prints out each node of the AVL tree\n using both inorder and preorder traversal\n";
	cout << "==============================================================\n";

	// Start of Program
	ifstream inputFile;
	string fileName;
	int data;

	//  Prompt User to enter the name of the file to be read from
	cout << "\nPlease enter the name of the data file: ";
	cin >> fileName;

	// Open file, check for read error
	inputFile.open(fileName);
	if (inputFile.fail())
	{
		cout << "Error opening " << fileName << endl;
		system("pause");
		return 1;
	}

	// Print data from file and insert data into an empty AVL binary search tree
	inputFile >> data;
	cout << "\nContents of the Data File" << endl;

	while (!inputFile.eof())
	{
		cout << data << " ";
		inputFile >> data;
	}

	cout << endl;
	// Close file
	inputFile.close();

	system("pause");
	return 0;
}