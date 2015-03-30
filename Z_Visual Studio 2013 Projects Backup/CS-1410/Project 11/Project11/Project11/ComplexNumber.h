// File Prologue
// Author: Russell Andlauer
// Class: CS-1410-001
// Project: Lab #11
// Date Last Modified: November 12th, 2014

/////////////////////////////////////////////////////////////////////////////////////////////////////////
// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.
/////////////////////////////////////////////////////////////////////////////////////////////////////////

#pragma once
class ComplexNumber
{
private:
	double realValue;
	double imaginaryValue;

public:
	// ComplexNumber
	// Purpose: default constructor
	// Parameters: none
	// Returns: none
	ComplexNumber();

	// ComplexNumber
	// Purpose: parameterized constructor
	// Parameters: double 'realValue', double 'imaginaryValue'
	// Returns: none
	ComplexNumber(double, double);

	// setRealValue
	// Purpose: setter for double 'realValue'
	// Parameters: double
	// Returns: none
	void setRealValue(double);

	// setImaginaryValue
	// Purpose: setter for double 'ImaginaryValue'
	// Parameters: double
	// Returns: none
	void setImaginaryValue(double);

	// getRealValue
	// Purpose: getter for double 'realValue'
	// Parameters: none
	// Returns: double 'realValue'
	double getRealValue() const;

	// getImaginaryValue
	// Purpose: getter for double 'imaginaryValue'
	// Parameters: none
	// Returns: double 'imaginaryValue'
	double getImaginaryValue() const;

	// operator+
	// Purpose: Operator Overload function for add operator
	// Parameters: ComplexNumber object by reference
	// Returns: ComplexNumber object
	ComplexNumber operator+(const ComplexNumber&);

	// operator-
	// Purpose: Operator Overload function for subtract operator
	// Parameters: ComplexNumber object by reference
	// Returns: ComplexNumber object
	ComplexNumber operator-(const ComplexNumber&);

	// operator*
	// Purpose: Operator Overload function for multiply operator
	// Parameters: ComplexNumber object by reference
	// Returns: ComplexNumber object
	ComplexNumber operator*(const ComplexNumber&);

	// operator/
	// Purpose: Operator Overload function for divide operator
	// Parameters: ComplexNumber object by reference
	// Returns: ComplexNumber object
	ComplexNumber operator/(const ComplexNumber&);

	// operator=
	// Purpose: Operator Overload function for assignment operator
	// Parameters: ComplexNumber object by reference
	// Returns: ComplexNumber object by reference
	ComplexNumber& operator=(const ComplexNumber&);

	// operator==
	// Purpose: Operator Overload function for equality comparison operator
	// Parameters: ComplexNumber object by reference
	// Returns: bool
	bool operator==(const ComplexNumber&);
	

	// unsure if we need to include a destructor, Visual Studio automatically included one
	~ComplexNumber();
};

