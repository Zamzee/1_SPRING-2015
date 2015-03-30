// File Prologue
// CS-1410-001
// Project: Lab 04
// Author: Russell Andlauer
// Date Last Modified: September 16th, 2014
//--------------------------------------------

#include <iostream>
#include <fstream>
#include <array>
#include <iomanip>

using namespace std;

const int SIZE = 100;

int main()
{
	// Declare an array of double values
	double voltages[SIZE];
	int dataElements = 0;  // companion variable to determine how much data is in the array

	// Open 'voltages.txt' 
	ifstream voltsIn;
	voltsIn.open("voltages.txt");

	// Verify file opened correctly
	if (voltsIn.good())
	{
		do
		{
			// Read the voltage values from the file, store values in the array
			int i;
			for (i = 0; i < SIZE; i++)
			{
				double data = 0;
				voltsIn.getline >> data;
					data >> voltages[i];
				dataElements++;
				// Test the state of the stream after each read operation
				voltsIn.good();
			}

			// Read until end of file
		} while (!voltsIn.eof());
	}

	else
	{
		cout << "\nSorry, bad file name, can't open the file.\n";
		return 1;
	}

	cout << fixed << setprecision(2);

	cout << voltages[0];

	// Calculate the average voltage value and display it.
	double average;
	double sum = 0;
	int j;
	for (j = 0; j <= dataElements; j++)
	{
		sum += voltages[j];
	}
	average = sum / dataElements;

	cout << average << endl;

	system("PAUSE");
	return 0;
}