using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab25GUITokenMachine
{
    class MyTokenMachine
    {
        /*
         * This is my token machine class
         * It is paterned after the UML diagram in Lab 13 instructions
         * First we declare constants and set up member data
        */

        const int FullTokens = 100;
        private int numTokens;
        private int numQuaters;

        // This first method is called a default constructor 
        // It is called when creating an object of the class to initialize member data
        public MyTokenMachine()
        {
            numTokens = FullTokens;
            numQuaters = 0;
        }

        // Method resets the token machine to default values.
        // Notice it is the same as the default constructor
        public void Reset()
        {
            numTokens = FullTokens;
            numQuaters = 0;
        }

        // This Method is called to dispence tokens
        // It dispences a token for a quarter 
        // So when it is called the number of quaters goes up and the number of tokens goes down
        // It includes a test for no tokens and stops working if the number of tokens is less than one
        public void GetToken()
        {
            if (numTokens >= 1)
            {
                numTokens--;
                numQuaters++;
            }
        }

        // This method returned the number of tokens in the machine
        public int CountTokens()
        {
            return numTokens;
        }

        // This method returnes the number of quaters in the machine 
        public int CountQuarters()
        {
            return numQuaters;
        }

    }
}
