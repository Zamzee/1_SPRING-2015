// File Prologue
// Author: Russell Andlauer
// Class: CS-1410-001
// Project: Project 07
// Date Last Modified: October 12th, 2014

/////////////////////////////////////////////////////////////////////////////////////////////////////////
// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.
/////////////////////////////////////////////////////////////////////////////////////////////////////////
#pragma once
#include <string>
using namespace std;

const int DEFAULT_CAPACITY = 2;

class MyVector
{
private:
	int vectorCapacity;
	int vectorSize;
	int* arrayPtr;

public:
	// default MyVector class constructor
	// Purpose: Construct a MyVector class object
	// Parameters: none
	// Returns: none
	MyVector();

	// parameterized MyVector class constructor
	// Purpose: Construct a MyVector class object with an int parameter for capacity
	// Parameters: int capacity
	// Returns: none
	MyVector(int);

	// deconstructor for the MyVector class
	// Purpose: delete an instance of the MyVector class
	// Parameters: none
	// Returns: none
	~MyVector();

	// size function
	// Purpose: Return the int vectorSize of the MyVector class
	// Parameters: none
	// Returns: const int vectorSize
	int size() const;

	// capacity function
	// Purpose: Return the int vectorCapacity of the MyVector class
	// Parameters: none
	// Returns: const int vectorCapacity
	int capacity() const;

	// clear function
	// Purpose: Delete all elements of the MyVector class and reset vectorSize to 0 and VectorCapacity to 2
	// Parameters: none
	// Returns: none
	void clear();

	// push_back function
	// Purpose: add an int element to the vector, grow the vector if not enough room for int element
	// Parameters: int n
	// Returns: none
	void push_back(int);

	// at function
	// Purpose: return the element at position n of the MyVector class
	// Parameters: int n
	// Returns: const int at position n
	int at(int) const;

};

