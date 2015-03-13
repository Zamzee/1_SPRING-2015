// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: 6
// Date: 7/11/2014


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.
// Received help from the tutoring lab

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_06_RCA_V1._0
{
    class ShippingCalculator
    {
        const int standard = 0;
        const int express = 1;
        const int sameDay = 2;
        const int item = 0;
        const int pounds = 1;
        int count;
        int category;
        int shippingType;
        bool surcharge;

        // setCount 
        // Purpose: set count variable
        // Parameters: int combo box index
        // Returns: none
        public void setCount(int comboIndex)
        {
            count = comboIndex;
        }

        // setCategory
        // Purpose: set category variable
        // Parameters: int combo box index
        // Returns: none
        public void setCategory(int comboIndex)
        {
            category = comboIndex;
        }

        // setShippingType
        // Purpose: set shipping type variable
        // Parameters: int combo box index
        // Returns: none
        public void setShippingType(int comboIndex)
        {
            shippingType = comboIndex;
        }

        // setSurcharge
        // Purpose: set surcharge variable
        // Parameters: int combo box index
        // Returns: none
        public void setSurcharge(bool comboIndex)
        {
            surcharge = comboIndex;
        }

        // getCount
        // Purpose: get the count variable
        // Parameters: none
        // Returns: int count
        public int getCount()
        {
            return count;
        }
        // getCategory
        // Purpose: get the Category variable
        // Parameters: none
        // Returns: int category
        public int getCategory()
        {
            return category;
        }

        // getShippingType
        // Purpose: get the shipping type variable
        // Parameters: none
        // Returns: int shippingType
        public int getShippingType()
        {
            return shippingType;
        }

        // get Surcharge
        // Purpose: get the surcharge variable
        // Parameters: none
        // Returns: bool surcharge
        public bool getSurcharge()
        {
            return surcharge;
        }

        // Calculate
        // Purpose: determine which type of shipping method to calculate
        // Parameters: none
        // Returns: either StandardCalc(), ExpressCalc(), or SameDayCalc()
        public double Calculate()
        {
            if (shippingType == standard)
            {
                return StandardCalc();
            }
            else if (shippingType == express)
            {
                return ExpressCalc();
            }
            else
            {
                return SameDayCalc();
            }
        }

        // StandardCalc
        // Purpose: Calculate with Standard shipping
        // Parameters: none
        // Returns: Standard Shipping Cost
        public double StandardCalc()
        {
            double cost = 0;
            double option1 = 3.00;
            double option2 = 1.45;

            if (category == item)
            {
                cost = option1;
            }
            else if (category == pounds)
            {
                cost = option2;
            }
            return (cost * count) + surchargeCalc();
        }

        // ExpressCalc
        // Purpose: Calculate with Express shipping
        // Parameters: none
        // Returns: Express Shipping Cost
        public double ExpressCalc()
        {
            double cost = 0;
            double option1 = 4.00;
            double option2 = 2.50;

            if (category == item)
            {
                cost = option1;
            }
            else if (category == pounds)
            {
                cost = option2;
            }
            return (cost * count) + surchargeCalc();
        }

        // SameDay Calc
        // Purpose: Calculate with SameDay shipping
        // Parameters: none
        // Returns: SameDay shipping cost
        public double SameDayCalc()
        {
            double cost = 0;
            double option1 = 5.50;
            double option2 = 3.00;

            if (category == item)
            {
                cost = option1;
            }
            else if (category == pounds)
            {
                cost = option2;
            }
            return (cost * count) + surchargeCalc();
        }

        // surcharge Calc
        // Purpose: Add the surcharge and calculate amount of surcharge depending on type of shipping
        // Parameters: none
        // Returns: surcharge for Standard, Express, or SameDay shipping
        public double surchargeCalc()
        {
            double option1 = 2.50;
            double option2 = 5.00;
            double option3 = 8.00;

            if (surcharge)
            {
                if (shippingType == standard)
                {
                    return option1;
                }

                else if (shippingType == express)
                {
                    return option2;
                }

                else 
                {
                    return option3;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
