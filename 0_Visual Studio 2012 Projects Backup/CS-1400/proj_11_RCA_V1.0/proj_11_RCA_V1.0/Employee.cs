// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Project 11
// Date: 8/13/2014


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace proj_11_RCA_V1._0
{
    class Employee
    {
        const double REGULAR_HOURS = 40;
        const double OVERTIME_RATE = 1.5;
        const double FEDERAL_TAX = 0.20;
        const double STATE_TAX = 0.075;
        double totalPay = 0;
        double taxAmount = 0;

        int employeeNumber;
        string name;
        string address;
        double hourlyWage;
        double hoursWorked;

        // Method: setEmployeeNumber
        // Purpose: setter for employeeNumber
        // Parameters: int iEmployeeNumber
        // Returns: none
        public void setEmployeeNumber(int iEmployeeNumber)
        {
            employeeNumber = iEmployeeNumber;
        }

        // Method: setName
        // Purpose: setter for name
        // Parameters: string iName
        // Returns: none
        public void setName(string iName)
        {
            name = iName;
        }

        // Method: setAddress
        // Purpose: setter for address
        // Parameters: string iAddress
        // Returns: none
        public void setAddress(string iAddress)
        {
            address = iAddress;
        }

        // Method: setHourlyWage
        // Purpose: setter for hourlyWage
        // Parameters: double iHourlyWage
        // Returns: none
        public void setHourlyWage(double iHourlyWage)
        {
            hourlyWage = iHourlyWage;
        }

        // Method: setHoursWorked
        // Purpose: setter for hoursWorked
        // Parameters: double iHoursWorked
        // Returns: none
        public void setHoursWorked(double iHoursWorked)
        {
            hoursWorked = iHoursWorked;
        }

        // Method: getEmployeeNumber
        // Purpose: getter for employeeNumber
        // Parameters: none
        // Returns: int employeeNumber
        public int getEmployeeNumber()
        {
            return employeeNumber;
        }

        // Method: getName
        // Purpose: getter for name
        // Parameters: none
        // Returns: string name
        public string getName()
        {
            return name;
        }

        // Method: getAddress
        // Purpose: getter for address
        // Parameters: none
        // Returns: string address
        public string getAddress()
        {
            return address;
        }

        // Method: getHourlyWage
        // Purpose: getter for hourlyWage
        // Parameters: none
        // Returns: double hourlyWage
        public double getHourlyWage()
        {
            return hourlyWage;
        }

        // Method:getHoursWorked
        // Purpose: getter for double hoursWorked
        // Parameters: none
        // Returns: double hoursWorked
        public double getHoursWorked()
        {
            return hoursWorked;
        }

        // Method: CalcPay
        // Purpose: Calcuate the paycheck for the employee
        // Parameters: none
        // Returns: double totalPay
        public double CalcPay()
        {
            if (hoursWorked > REGULAR_HOURS)
            {
                double timeHalf = hoursWorked - REGULAR_HOURS;
                timeHalf = timeHalf * (OVERTIME_RATE * hourlyWage);
                totalPay = timeHalf + (REGULAR_HOURS * hourlyWage);
            }

            else
            {
                totalPay = hourlyWage * hoursWorked;
            }

            taxAmount = totalPay * (FEDERAL_TAX + STATE_TAX);
            totalPay = totalPay - taxAmount;

            return totalPay;
        }

        // Method: Read
        // Purpose: Read the data from the textfile and save data into proper variables
        // Parameters: StreamReader 'reader'
        // Returns: bool
        public bool Read(ref StreamReader reader)
        {
            string[] temp;
            if (!reader.EndOfStream)
            {
                employeeNumber = int.Parse(reader.ReadLine());
                name = reader.ReadLine();
                address = reader.ReadLine();
                temp = reader.ReadLine().Split();
                hourlyWage = double.Parse(temp[0]);
                hoursWorked = double.Parse(temp[1]);
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
