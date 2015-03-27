// Project: Lab 02
// Author: Russell Andlauer
// CS-1410-001
// Date Last Modified: September 3rd, 2014
// -----------------------------------------------

#include <iostream>
#include <string>
#include <vector>
#include <iomanip>
using namespace std;

const int MAX = 5;
double myData[MAX];

double addValues(double[], int);

void printContent(const vector<double>&);

int main ()
{

	vector<double> myVector;
	double myData[MAX];

	double userValue;
	double result;
	int myDataSize = 0;

	// Prompt the user to enter a decimal value 5 times
	// Save each value into a vector
	for (int i = 0; i < MAX; i++)
	{
		cout << "\nEnter a decimal value: ";
		cin >> userValue;
		myVector.push_back(userValue);
	}

		// Copy each element of the vector into an array
		std::copy(myVector.begin(), myVector.end(), myData);

		// Call a function that adds up the elements of the array
		result = addValues(myData, MAX);

		cout << result << fixed << setprecision(2);

	//for (int j = 0; j < MAX; j++)
	//{
	//	std::copy(myVector.begin(), myVector.end(), myData);
		//myVector[j] >> myData[j];
	//	myDataSize++;
	//}

	//printContent(myVector);

	cout << endl;
	system ("PAUSE");
	return 0;



	// Print the sum accurate to 2 decimal places
}

double addValues(double[], int)
{
	double sum = 0;
	for (int i = 0; i < MAX; i++)
	{
		sum += myData[i];
	}
	return sum;
}

//void printContent(const vector<double>& v)
//{
	//for(int i = 0; i < v.size(); i++)\
		cout << '\n' << v[i] << fixed << setprecision(2);
//}