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

#pragma once
#include <string>
using namespace std;

class Employee
{
private:
	int employeeNumber;
	string name;
	string address;
	string phoneNumber;
	double hourlyWage;
	double hoursWorked;

public:
	// default Employee class constructor
	// Purpose: construct an employee class object
	// Parameters: none
	// Returns: none
	Employee();

	// parameterized Employee class constructor
	// Purpose: construct an employee class with parameters
	// Parameters: int, string, string, string, double, double
	// Returns: none
	Employee(int, string, string, string, double, double);

	// getEmployeeNumber
	// Purpose: getter for int 'employeeNumber'
	// Parameters: none
	// Returns: int 'employeeNumber'
	int getEmployeeNumber() const;

	// getName
	// Purpose: getter for string 'name'
	// Parameters: none
	// Returns: string 'name'
	string getName() const;

	// getAddress
	// Purpose: getter for string 'address'
	// Parameters: none
	// Returns: string 'address'
	string getAddress() const;

	// getPhoneNumber
	// Purpose: getter for string 'phoneNumber'
	// Parameters: none
	// Returns: string 'phoneNumber'
	string getPhoneNumber() const;

	// getHourlyWage
	// Purpose: getter for double 'hourlyWage'
	// Parameters: none
	// Returns: double 'hourlyWage'
	double getHourlyWage() const;

	// getHoursWorked
	// Purpose: getter for double 'hoursWorked'
	// Parameters: none
	// Returns: double 'hoursWorked'
	double getHoursWorked() const;

	// setEmployeeNumber
	// Purpose: setter for int 'employeeNumber'
	// Parameters: int 'eNum'
	// Returns: none
	void setEmployeeNumber(int);

	// setName
	// Purpose: setter for string 'employeeName'
	// Parameters: string 'eName'
	// Returns: none
	void setName(string);

	// setAddress
	// Purpose: setter for string 'eAddress'
	// Parameters: string 'eAddress'
	// Returns: none
	void setAddress(string);

	// setPhoneNumber
	// Purpose: setter for string 'ePhoneNum'
	// Parameters: string 'ePhoneNum'
	// Returns: none
	void setPhoneNumber(string);

	// setHourlyWage
	// Purpose: setter for double 'hourlyWage'
	// Parameters: double 'hourlyWage'
	// Returns: none
	void setHourlyWage(double);

	// setHoursWorked
	// Purpose: setter for double 'hoursWorked'
	// Parameters: double 'hoursWorked'
	// Returns: none
	void setHoursWorked(double);

	// calcPay
	// Purpose: Calculate the Paycheck amount for the Employee
	// Parameters: none
	// Returns: double
	double calcPay() const;
};

