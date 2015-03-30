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


Employee::Employee()
{
	employeeNumber = 0;
	name = "";
	address = "";
	phoneNumber = "";
	hourlyWage = 0.0;
	hoursWorked = 0.0;
}

Employee::Employee(int eNum, string eName, string eAddress, string ePhoneNum, double wage, double hours)
{
	employeeNumber = eNum;
	name = eName;
	address = eAddress;
	phoneNumber = ePhoneNum;
	hourlyWage = wage;
	hoursWorked = hours;
}

int Employee::getEmployeeNumber() const
{
	return employeeNumber;
}

string Employee::getName() const
{
	return name;
}

string Employee::getAddress() const
{
	return address;
}

string Employee::getPhoneNumber() const
{
	return phoneNumber;
}

double Employee::getHourlyWage() const
{
	return hourlyWage;
}

double Employee::getHoursWorked() const
{
	return hoursWorked;
}

void Employee::setEmployeeNumber(int eNum)
{
	employeeNumber = eNum;
}

void Employee::setName(string eName)
{
	name = eName;
}

void Employee::setAddress(string eAddress)
{
	address = eAddress;
}

void Employee::setPhoneNumber(string ePhoneNum)
{
	phoneNumber = ePhoneNum;
}

void Employee::setHourlyWage(double wage)
{
	hourlyWage = wage;
}

void Employee::setHoursWorked(double hours)
{
	hoursWorked = hours;
}

double Employee::calcPay() const
{
	const double REGULAR_HOURS = 40;
	const double OT_RATE = 1.5;
	const double FED_TAX_RATE = 0.20;
	const double STATE_TAX_RATE = 0.075;


	if (hoursWorked <= REGULAR_HOURS)
	{
		double pay = (hoursWorked * hourlyWage);
		double payCheck = pay - (pay * (FED_TAX_RATE + STATE_TAX_RATE));
		return payCheck;
	}

	else if (hoursWorked > REGULAR_HOURS)
	{
		double overtimeHours = (hoursWorked - REGULAR_HOURS);
		double overTimePay = (overtimeHours * (OT_RATE * hourlyWage));
		double regPay = (hoursWorked - overtimeHours) * hourlyWage;
		double netPay = regPay + overTimePay;
		double payCheck = netPay - (netPay * (FED_TAX_RATE + STATE_TAX_RATE));
		return payCheck;
	}
}



