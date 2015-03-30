// File Prologue
// Name: Russell Andlauer
// Class: CS-2420-601
// Program 5: Hashing
// Date Last Modified: March 30th, 2015
// Description: This program offers practice implementing a hash table and a hash function using a file containing a set of integers.
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#pragma once

class Hash
{
private:
	//Hash Table (int Array of 20 elements)
public:
	// Hash()
	// Purpose: Default Constructor
	// Parameters:
	//
	Hash();

	//+ 

	//	+ Hash Function

	//	+ Insert Function

	//	+ Resolve Collision Function

	//	+ Show Function

	
	
	//~Hash();
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

