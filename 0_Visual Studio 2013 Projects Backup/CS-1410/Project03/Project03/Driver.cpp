// File Prologue
// Class: CS-1410-001
// Project: Project 03
// Authors: Russell Andlauer and Jeff Pearson (We each typed our own programs for more practice but worked together to write it.)
// Date Last Modified: September 12th, 2014

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
using namespace std;

void printCheck(string, double, double, double);

int main()
{
	// Create an Employee object 'employeeOne'
	Employee employeeOne(1, "Jimmy 'not-a-criminal' Criminally", "123 street" , "801-123-4567", 10.00, 45);
	
	// Create an Employee object 'employeeTwo'
	Employee employeeTwo(2, "Freddie 'from-the-docks' Mc'Sketchy", "123 avenue", "801-867-5309", 12.50, 30);

	// Call printCheck function for employeeOne
	printCheck(employeeOne.getName(), employeeOne.getHourlyWage(), employeeOne.getHoursWorked(), employeeOne.calcPay());

	// Wait for user to hit Enter to continue
	system("PAUSE");
	//return 0;

	// Clear the console
	system("CLS");

	// Call printCheck function for employeeTwo
	printCheck(employeeTwo.getName(), employeeTwo.getHourlyWage(), employeeTwo.getHoursWorked(), employeeTwo.calcPay());

	system("PAUSE");
	return 0;
}

void printCheck(string eName, double eWage, double eHours, double ePaycheck)
{
	string name = eName;
	double wage = eWage;
	double hours = eHours;
	double paycheck = ePaycheck;

	// Output paycheck information
	cout << "\n-------------------Legitimate Business Inc.----------------------" << endl;

	// Output employee's name
	cout << "\nPay to the order of: " << name << endl;

	// Output paycheck design elements
	cout << "\n\nBank of Unmarked Briefcase Under Parkbench Previously Agreed Upon";
	cout << "\n-----------------------------------------------------------------" << endl;

	// Output formatting
	cout << fixed << setprecision(2);

	// Output employee's hours worked
	cout << "\nHours Worked: " << eHours;

	// Output employee's wage
	cout << "\nHourly Wage: " << eWage << endl;

	// Output paycheck design element
	cout << "-----------------------------------------------------------------" << endl;

	// Output employee's net pay
	cout << "\nWeekly Paycheck Amount: $" << paycheck << endl;

	// Output paycheck design element
	cout << "\n-----------------------------------------------------------------" << endl;
}
