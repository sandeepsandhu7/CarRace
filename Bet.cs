using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    public class Bet:Car
    {
       //string function that is used to verify the bet amount and the name of the player this method has 2 arguments like name and amount so thus it can easily verify
        public decimal Amount;
        public string Car;
        public Player Bettor;
        public decimal odds;
        public decimal DBodds;
       
        
        public string GetDescription()
          
        {
            if (Amount == 0)
                return Bettor.Name + "HASN'T PLACED BET";
            else
                return Bettor.Name + "Has placed a bet of $" + Amount + " on " + Car;
        }
     
        public decimal PayOut(string Winner)
        {
            //
            if (Winner == Car)
                return Amount * odds;
            else
                return (0 - Amount);
        }
    }
}
