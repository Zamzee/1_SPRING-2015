/////////////////////////////////////////
// File Prologue
// Author: Russell Andlauer
// Class: CS-2420-601
// Project: Program 3 - Stack and Queue
// Date Last Modified: February 15th, 2015
/////////////////////////////////////////

#include <iostream>
#include <string>
#include <fstream>
#include "Node.h"
#include"Stack.h"
#include"Queue.h"

using namespace std;

void print(const string&, const string&, int, int);
string stack_status[] = { "success", "underflow" };

int main()
{
	fstream readFile;
	int num;
	int result;
	string data;
	string stack;
	Stack StackData;
	Queue QueueData;
	string myFile;
	cout << "---------------------------------------------" << endl;
	cout << "Russell Andlauer\n" << endl;
	cout << "CS-2420-601" << endl;
	cout << "\n---------Program 3: Stack and Queue----------\n" << endl;
	cout << "This Program reads in instructions from a textfile" << endl;
	cout << "to demonstrate the understanding of Stacks and Queues.\n" << endl;
	cout << "---------------------------------------------\n" << endl;

	cout << "Enter the name of the textfile you would like to use: " << endl;
	cin >> myFile;
	readFile.open(myFile);
	if (readFile.fail())
	{
		cout << "Error opening the file:  " << myFile << "\n" << "\nPlease enter the correct name of the textfile";
		system("pause");
		return 1;
	}
	while (readFile >> data)
	{

		if (data == "push")
		{
			readFile.ignore();
			readFile >> num;
			StackData.push(num);
			stack = "stack";
			result = StackData.getStatusCode();
		}
		else if (data == "pop")
		{
			StackData.pop();
			stack = "stack";
			result = StackData.getStatusCode();
		}
		else if (data == "append")
		{
			readFile.ignore();
			readFile >> num;
			QueueData.append(num);
			stack = "queue";
			result = QueueData.getStatusCode();
		}
		else
		{
			num = QueueData.serve();
			stack = "queue";
			result = QueueData.getStatusCode();
		}
		print(data, stack, num, result);
	}



	system("pause");
	return 0;
}

void print(const string& data, const string& stack, int num, int result)
{
	if (data == "pop")
	{
		cout << data << '\t' << stack << "\t---\t" << stack_status[result] << endl;
	}
	else
	{
		cout << data << '\t' << stack << '\t';
		if (num == -1)
			cout << "---";
		else
			cout << num;
		cout << '\t' << stack_status[result] << endl;
	}

}
