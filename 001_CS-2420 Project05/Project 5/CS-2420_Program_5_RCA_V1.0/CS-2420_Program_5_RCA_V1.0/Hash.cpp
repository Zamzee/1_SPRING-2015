// File Prologue
// Name: Russell Andlauer
// Class: CS-2420-601
// Program 5: Hashing
// Date Last Modified: March 30th, 2015
// Description: This program offers practice implementing a hash table 
//              and a hash function using a file containing a set of integers.
//////////////////////////////////////////////////////////////////////////////
#include "Hash.h"


Hash::Hash()
{
	int HashTable[MAX];
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
	if (value == empty)
	{
		cout << "Collision detected at location %d for value %d: on the screen." << endl;
	}
}

bool Hash::resolveCollision(int vale, int originalLocation)
{

}

void Hash::show()
{

}