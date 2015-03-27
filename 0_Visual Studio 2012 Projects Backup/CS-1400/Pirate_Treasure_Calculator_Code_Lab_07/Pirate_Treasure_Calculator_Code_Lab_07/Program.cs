// Project Prolog
// Name: Dennis A. Fairclough
// CS 1400 Section XXX
// Project: CS1400_Lab_01
// Date: 5/1/2013 12:44:44 PM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;

static class Program
{
    /// <summary>
    /// Purpose: Entry point to your C# program
    /// </summary>
    static void Main()
    {

        Console.WriteLine("Press Enter to continue ...");
        Console.ReadLine();

 int TotalCrew; //# of crewmen onboard
        int TotalGold;  //Amount of Gold Coins in Treasure Chest
        int TotalPay;  // 3 coins distributed to all crewmembers
        int Capt_Share; //Captain Jack's 12% cut
        int First_Mate_Share;  //1st Mate's 8% cut
        int Crew_Cut;  //treasure divided up by the whole crew including the Captain and 1st Mate
        int PBA_Fee;  // remainder of Gold given to the Private's Benevolent Association

       // Console.WriteLine("Press Enter to continue ...");
       // Console.ReadLine();

        Console.WriteLine("How many Pirates are on board the Black Pearl?");       //1) Ask User how many Pirates are on board. (?)
        TotalCrew = int.Parse(Console.ReadLine());                                 //2) Get the User's Input and Save it as TotalCrew (int)
        Console.WriteLine("How much Gold have you gathered in your plundering?");  //3) Ask the User how much Gold has been collected. (?)
        TotalGold = int.Parse(Console.ReadLine());                                 //4) Get the User's Input and Save it as TotalGold (int)

        TotalPay = (3*(TotalCrew));//6) Multiply TotalCrew by 3 and Save it as TotalPay (int)    (xxxxx)  //5) Count TotalGold

        TotalGold= TotalGold - TotalPay;  //9) Subtract TotalPay from TotalGold
        Capt_Share= ((int)(TotalGold * 0.12));     //10) Multiply TotalGold by 0.12 and Save result as Capt_Share (int)
        TotalGold= TotalGold - Capt_Share;  //11) Subtract Cap'n_Share from TotalGold
        First_Mate_Share= (int)(TotalGold * 0.08);   //12) Multiply TotalGold by .08 and Save results as 1st_Mate_Share (int)
        TotalGold= TotalGold - First_Mate_Share;   //13) Subtract 1st_Mate_Share from TotalGold
        Crew_Cut= TotalGold / TotalCrew;   //15) Divide TotalGold by TotalCrew and Save as Crew_Cut (int)
        PBA_Fee= TotalGold % TotalCrew;//16) Save remainder as PBA_Fee (int)

        Console.WriteLine("Each crew member gets {0} pieces of Gold.  The PBA gets {1} pieces of Gold. \n  The Captain gets an extra {2} Gold, and the First Mate gets and extra {3} Gold.", Crew_Cut, PBA_Fee, Capt_Share, First_Mate_Share);
            //16) Print result "Each crew member gets {0} pieces of Gold.  The PBA gets {1} pieces of Gold.", CrewCut, PBA;
        Console.ReadLine();
    }//End Main()
}//End class Program