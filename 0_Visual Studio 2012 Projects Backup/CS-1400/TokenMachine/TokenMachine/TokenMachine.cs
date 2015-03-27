using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenMachine
{
    class TokenMachine
    {
        private int startTokens = 100;
        private int startQuarters = 0;
        private int quantTokens;
        private int quantQuarters;

        public TokenMachine()
        {
           /// int startTokens = 100;
          ///  int startQuarters = 0;
          ///  int quantTokens;
          ///  int quantQuarters;
        }

        // Get Token Method
        // Purpose: Removes one Token from the machine and adds one Quarter to the machine
        // Parameters: Number of Tokens and Number of Quarters
        // Returns: none
        public void GetToken(int startTokens, int startQuarters)
        {
            int quantTokens = startTokens--;
            int quantQuarters = startQuarters++;

        }

        // Count Tokens Method
        // Purpose: Return the number of Tokens that are in the machine
        // Parameters: quantTokens
        // Returns: quantTokens
        public int CountTokens(int quantTokens)
        {
            return quantTokens;
        }

        // Count Quarters Method
        // Purpose: Return the number of Quarters that are in the machine
        // Parameters: quantQuarters
        // Returns: quantQuarters
        static int CountQuarters(int quantQuarters)
        {
            return quantQuarters;
        }

        public int Reset(int startTokens, int startQuarters, int quantTokens, int quantQuarters)
        {
            quantTokens = startTokens;
            quantQuarters = startQuarters;
            return quantTokens;
           /// return quantQuarters;
        }


    }
}
