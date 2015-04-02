// File Prologue
// Name: Russell Andlauer
// Class: CS-2420-601
// Program 5: Hashing
// Date Last Modified: April 1st, 2015
// Description: This program offers practice implementing a hash table 
//              and a hash function using a file containing a set of integers.
//////////////////////////////////////////////////////////////////////////////
#include "Hash.h"


Hash::Hash()
{
	HashTable[MAX];
	int value = 0;
	int location = (MAX - 1);

}

int Hash::getHashValue(int value)
{
	int newEntry = value;
	int key = newEntry % MAX;

	return key;
}

bool Hash::insert(int value, int location)
{
	if (value == EMPTY)
	{
		cout << "Collision detected at location %d for value %d: on the screen." << endl;
		// temporary
		return true;
	}
}

bool Hash::resolveCollision(int vale, int originalLocation)
{
	// temporary 
	return true;
}

void Hash::show()
{

}