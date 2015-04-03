// File Prologue
// Name: Russell C. Andlauer
// Class: CS-2420-601
// Program 5: Hashing
// Date Last Modified: April 2nd, 2015
// Description: This program offers practice implementing a hash table
//              and a hash function using a file containing a set of integers.
///////////////////////////////////////////////////////////////////////////////

#pragma once
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

const int MAX = 20;
const int EMPTY = -999;

class Hash
{
protected:
	
	//Hash Table (int Array of 20 elements)	
	int HashTable[MAX];

public:

	// Function: Hash
	// Purpose: Default Constructor - set each element of the Hash table to '-999'
	// Parameters: none
	// Returns: none
	Hash();

	// Function: getHashValue
	// Purpose: Returns the location in the array that the int 'value' should be placed
	// Parameters: int value
	// Returns: int representing the location in the array the int 'value' should be placed
	int getHashValue(int value);

	// Function: insert
	// Purpose: attempts to insert the passed integer value into the array unless there is a key value already in the array
	// Parameters: int value, int location
	// Returns: bool indicating if a collision was detected and if the value was successfully inserted into the array
	bool insert(int value, int location);

	// Function: Resolve Collision
	// Purpose: Attempts to locate an empty location in the array to insert a new value
	// Parameters: int value, int originalLocation
	// Returns: bool indicating the collision was successfully resolved
	bool resolveCollision(int value, int originalLocation);

	// Function: Show
	// Purpose: Show each element of the array representing the Hash Table
	// Parameters: none
	// Returns: none
	void show();

};