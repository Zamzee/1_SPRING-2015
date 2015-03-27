﻿// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Project 5 Sales Invoice Calculator
// Date: July 6th, 2014


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

namespace proj_05_RCA_V1._0
{
    class SalesInvoice
    {
        // declare constants and member data
        const double STATE_TAX_RATE = .0745;
        const double LOCAL_TAX_RATE = .025;
        double numItems;
        double itemPrice;
        double netPrice;
        double stateTax;
        double localTax;
        double totalPay;

        // The Default Constructor
        // Purpose: Initialize member data
        // Parameters: None
        // Returns: None
        public SalesInvoice()
        {
            numItems = 0;
            itemPrice = 0;
            netPrice = 0;
            stateTax = 0;
            localTax = 0;
            totalPay = 0;

        }

        // The Parameterized Constructor
        // Purpose: Sets the declared variables to the values passed in
        // Parameters: The number of items and price of each item given by the user
        // Returns: None
        public SalesInvoice(double p1, double p2, double p3, double p4, double p5, double p6)
        {
            numItems = p1;
            itemPrice = p2;
            netPrice = p3;
            stateTax = p4;
            localTax = p5;
            totalPay = p6;
        }

        // The Reset Method
        // Purpose: Resets the Sales Invoice to the default values
        // Parameters: None
        // Returns: None
        public void Reset()
        {
            numItems = 0;
            itemPrice = 0;
            netPrice = 0;
            stateTax = 0;
            localTax = 0;
            totalPay = 0;
        }


        // The GetNumItems Method
        // Purpose: Getter for numItems
        // Parameters: None
        // Returns: the number of items as a double
        public double GetNumItems()
        {
            return numItems;
        }

        // The GetItemPrice Method
        // Purpose: Getter for itemPrice
        // Parameters: None
        // Returns: the price of each item as a double
        public double GetItemPrice()
        {
            return itemPrice;
        }

        // SetNumItems Method
        // Purpose: Setter for numItems
        // Parameters: double p1
        // Returns: None
        public void SetNumItems(double p1)
        {
            numItems = p1;
        }

        // SetItemPrice Method
        // Purpose: Setter for itemPrice
        // Parameters: double p2
        // Returns: None
        public void SetItemPrice(double p2)
        {
            itemPrice = p2;
        }

        // CalcNetPrice Method
        // Purpose: Calculate the total cost before tax is applied to the purchase
        // Parameters: None
        // Returns: double netPrice
        public double CalcNetPrice()
        {
            double netPrice = numItems * itemPrice;
            return netPrice;
        }

        // CalcStateTax Method
        // Purpose: Calculate the State Tax applied to the sale
        // Parameters: None
        // Returns: double stateTax
        public double CalcStateTax()
        {
            double netPrice = numItems * itemPrice;
            double stateTax = netPrice * STATE_TAX_RATE;
            return stateTax;
        }

        // CalcLocalTax Method
        // Purpose: Calculate the Local Tax applied to the sale
        // Parameters: None
        // Returns: double localTax
        public double CalcLocalTax()
        {
            double netPrice = numItems * itemPrice;
            double stateTax = netPrice * STATE_TAX_RATE;
            double localTax = netPrice * LOCAL_TAX_RATE;
            return localTax;
        }

        // CalcTotalPay Method
        // Purpose: Calculate the Total amount to pay for the sale
        // Parameters: None
        // Returns: double totalPay
        public double CalcTotalPay()
        {
            double netPrice = numItems * itemPrice;
            double stateTax = netPrice * STATE_TAX_RATE;
            double localTax = netPrice * LOCAL_TAX_RATE;
            double totalPay = netPrice + stateTax + localTax;
            return totalPay;
        }
    }
}
