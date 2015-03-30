// File Prologue
// Class: CS-1410-001
// Project: Project 04
// Authors: Russell Andlauer
// Date Last Modified: September 21st, 2014

//--------------------------------------------------------------------------
// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.
//--------------------------------------------------------------------------

#include "Employee.h"
#include <string>
#include <iostream>
#include <iomanip>
#include <fstream>
using namespace std;

// printCheck
// Purpose: Output the paycheck to the user; including employee's name, wage, hours worked, and net pay amount
// Parameters: Employee Object
// Returns: none
void printCheck(const Employee& e);

int main()
{
	int input;
	// Present the user with a menu of choices: 1) Create a data file, or 2) Read data from a file and print checks
	cout << "\nThis program has two options:";
	cout << "\n1) Create a data file";
	cout << "\n or";
	cout << "\n2) Print checks";
	cout << "\nPlease enter (1) to create a file or (2) to print checks:";
	cin >> input;

	// 1) If create a data file is selected
	if (input == 1)
	{
	// Create three employee objects
	Employee joe(37, "Joe Brown", "123 Main St.", "123-6788", 45, 10.00);
	Employee sam(21, "Sam Jones", "45 East State", "661-9000", 30, 12.00);
	Employee mary(15, "Mary Smith", "12 High Street", "401-8900", 40, 15.00);

	// Create an ofstream object and open a file, create name and pass file name as the parameter
	ofstream odataFile("employeeData.txt");

	// Send messages to each of the three Employee objects to write themselves out to the file
	if (odataFile.good())
	{
		joe.writeData(odataFile);

		sam.writeData(odataFile);

		mary.writeData(odataFile);

		// Close the file
		odataFile.close();
	}

	// Print a message that the creation of the file is complete
	cout << "\nEmployee data successfully written to employeeData.txt" << endl;

	// Exit
	system("PAUSE");
	return 0;
	}

	// 2) If read data from a file and print checks is selected
	if (input == 2)
	{
		// Create three new Employee objects, using the default Employee constructor
		Employee joe;
		Employee sam;
		Employee mary;
		bool goodInput = true;

		// Open the file that was just saved
		ifstream idataFile("employeeData.txt");
		if (idataFile.fail())
		{
			cout << "\nFile did not open.";
			exit(1);
		}
		else
		{
			// Have each object read itself from the file
			if (!idataFile.eof() && idataFile.good())
			{
				
			joe.readData(idataFile);
			sam.readData(idataFile);
			mary.readData(idataFile);
			goodInput = true;
			}

			else
			{
				goodInput = false;
				cout << "\nFile Read Error";
			}

			// This segment of code is used to test if the proper data is assigned to the correct variables in the default employee constructor
			cout << joe.getEmployeeNumber() << endl;
			cout << joe.getName() << endl;
			cout << joe.getAddress() << endl;
			cout << joe.getPhoneNumber() << endl;
			cout << joe.getHourlyWage() << endl;
			cout << joe.getHoursWorked() << endl;
			system("PAUSE");

			// Call the printCheck() function for each of the three new objects
			printCheck(joe);
			system("PAUSE");
			system("CLS");

			printCheck(sam);
			system("PAUSE");
			system("CLS");

			printCheck(mary);

			// Exit
			system("PAUSE");
			return 0;
		}
	}
	else
		cout << "\nInvalid selection, please reopen and enter a (1) or a (2).\nGoodbye.";
	system("PAUSE");
	return 1;
}

void printCheck(const Employee& e)
{
	// Output paycheck information
	cout << "\n-------------------Legitimate Business Inc.----------------------" << endl;

	// Output employee's name
	cout << "\nPay to the order of: " << e.getName() << endl;

	// Output paycheck design elements
	cout << "\n\nBank of Unmarked Briefcase Under Parkbench Previously Agreed Upon";
	cout << "\n-----------------------------------------------------------------" << endl;

	// Output formatting
	cout << fixed << setprecision(2);

	// Output employee's hours worked
	cout << "\nHours Worked: " << e.getHoursWorked();

	// Output employee's wage
	cout << "\nHourly Wage: " << e.getHourlyWage() << endl;

	// Output paycheck design element
	cout << "-----------------------------------------------------------------" << endl;

	// Output employee's net pay
	cout << "\nWeekly Paycheck Amount: $" << e.calcPay() << endl;

	// Output paycheck design element
	cout << "\n-----------------------------------------------------------------" << endl;
}
