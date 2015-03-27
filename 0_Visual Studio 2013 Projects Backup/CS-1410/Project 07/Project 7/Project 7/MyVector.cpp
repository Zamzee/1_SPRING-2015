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
#include "MyVector.h"

MyVector::MyVector()
{
	vectorCapacity = DEFAULT_CAPACITY;
	vectorSize = 0;	
	arrayPtr = new int[vectorCapacity];
}

MyVector::MyVector(int n)
{
	vectorCapacity = n;
	vectorSize = 0;
	arrayPtr = new int[vectorCapacity];
}


MyVector::~MyVector()
{
	if (arrayPtr != NULL)
	{
		delete[] arrayPtr;
		arrayPtr = NULL;
	}
}

int MyVector::size() const
{
	return vectorSize;
}

int MyVector::capacity() const
{
	return vectorCapacity;
}

void MyVector::clear()
{
	// Delete the array
	delete[] arrayPtr;

	// Set the arrayPtr to nullptr
	arrayPtr = nullptr;

	// Reset the default array capacity and size
	vectorCapacity = DEFAULT_CAPACITY;
	vectorSize = 0;

	// Create a new array
	arrayPtr = new int[vectorCapacity];
}

void MyVector::push_back(int n)
{
	int element = n;

	if (vectorSize == vectorCapacity)
	{
		// 1) Create a new array that is double the size of the current array
		int doubleCapacity = vectorCapacity * DEFAULT_CAPACITY;
		int* newArray = new int[doubleCapacity];

		// 2) Change vectorCapacity of current array to be the size of the new array
		vectorCapacity = doubleCapacity;

		// 3) Copy all of the integer elements from the current array to the new array, in sequence
		for (int i = 0; i < vectorSize; i++)
		{
			newArray[i] = arrayPtr[i];
		}

		// 4) Delete the original array
			delete[] arrayPtr;

		// 5) Change arrayPtr to point to the new array
			arrayPtr = newArray;
	}

	// 6) Add the new integer element to the next open slot in the array and increment vectorSize
	arrayPtr[vectorSize++] = element;
}

int MyVector::at(int n) const
{
	// If index is out of range of MyVector throw exception (index value)
	if (n < 0 || n >= vectorSize)
		throw n;

	// Return the element at position n of MyVector
	else
		return arrayPtr[n];
}
