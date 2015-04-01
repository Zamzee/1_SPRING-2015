// File Prologue
// Name: Russell Andlauer
// Class: CS-2420-601
// Program 5: Hashing
// Date Last Modified: March 30th, 2015
// Description: This program offers practice implementing a hash table
//              and a hash function using a file containing a set of integers.
///////////////////////////////////////////////////////////////////////////////

#pragma once
#include <iostream>
#include <fstream>
#include <string>
using namespace std;

const int MAX = 20;
const int empty = -999;

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
	// Returns: bool indicating if a collision was detected and that the insert
	bool insert(int value, int location);

	// Function: Resolve Collision
	// Purpose: Attempts to locate an empty location in the array to insert a new value
	// Parameters: int value, int originalLocation
	// Returns: bool indicating the collision was successfully resloved
	bool resolveCollision(int value, int originalLocation);

	// Function: Show
	// Purpose: Show each element of the array representing the Hash Table
	// Parameters: none
	// Returns: none
	void show();

};

//Pseudo - Code
//=============

// 1.	Create an instance of the Hash class (make sure it is initialized by the no-argument constructor).

// 2.	Allow the user to enter the name and path of the file

// 3.	Read an element from the file, if the end of the file is encountered continue with step 6

// 4.	Call the Hash function to get the location where the integer should be stored


// 5.	Call the Insert function to store the integer
// a. If (the Insert function succeeds) repeat with step 3

// b. If the (Insert function fails) (collision is detected)
// 1) Print the error message
// 2) then resolve the collision by calling the Resolve Collision function, repeat with step 3. 

// If (the array is full) and (the Resolve Collision function fails)

// 1) print a message to the screen
// 2) call the Show function.

// 6.	After processing all of the integers in the file, call the Show function to print the contents of the Hash table.

