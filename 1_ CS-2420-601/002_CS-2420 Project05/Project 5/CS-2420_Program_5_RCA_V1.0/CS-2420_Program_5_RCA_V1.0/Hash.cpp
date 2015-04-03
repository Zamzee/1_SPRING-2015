// File Prologue
// Name: Russell C. Andlauer
// Class: CS-2420-601
// Program 5: Hashing
// Date Last Modified: April 2nd, 2015
// Description: This program offers practice implementing a hash table 
//              and a hash function using a file containing a set of integers.
//////////////////////////////////////////////////////////////////////////////
#include "Hash.h"

Hash::Hash()
{
	HashTable[MAX];

	for (int i = 0; i < MAX; i++)
	{
		HashTable[i] = EMPTY;
	}
}

int Hash::getHashValue(int value)
{
	int key = value;
	key = key % MAX;
	return key;
}

bool Hash::insert(int value, int location)
{
	if (HashTable[location] == EMPTY)
	{
		HashTable[location] = value;
		return true;
	}

	else if (HashTable[location] == value)
	{
		cout << "Duplicate data... the value " << value << " is already in the array" << endl;
		return true;
	}

	else
	{
		cout << "Collison detected at location " << location << " for the value " << value << endl;

		return false;
	}
}

bool Hash::resolveCollision(int value, int originalLocation)
{
	// Using Linear Probing to Resolve Collision
	int testLocation = originalLocation;
	bool insertSuccess = false;

	// Start at the location of the collision and incrementally check if the location is occupied
	while (!insertSuccess)
	{
		// If insertion was not successful, increment location
		testLocation++;

		// Try to insert in the new location
		testLocation = getHashValue(testLocation);
		insertSuccess = insert(value, testLocation);

		 //Check if the array is full
		if (testLocation == originalLocation)
		{
			return false;
		}
	}

	// If the collision is successfully resolved
	return true;
}

void Hash::show()
{
	for (int i = 0; i < MAX; i++)
	{
		cout << HashTable[i] << endl;
	}
}