using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace
{
    public class Player : Bet
    {
        //passing the local value to global variable using this keyword
        public Bet MyBet;
        public decimal Cash;
        public int[] GuyArray;

        public RadioButton MyRadioButton;
        public Label MyLabel;
        public Label MyLabel2;

     

        public void StatusUpdate()
        {
            // if any player set the bet then it will call the another method to print his name and car number also 
            MyRadioButton.Text = Name + " HAS $" + Cash;   
        }

        //it is used to clear the amount of bet after completion the race
        public void ClearBet()
        {
            // if the user has not set any bet then it will display no one has set the bet 
            MyBet = null;
            MyLabel2.Text = Name + " HASN'T PLACED A BET";
        }

        public bool PlaceBet(int BetAmount, string CarToWin, decimal Test)
        {
            this.MyBet = new Bet() { Amount = BetAmount, Car = CarToWin, Bettor = this, odds = Test};
            if (BetAmount <= Cash)
            {
                 MyLabel2.Text = this.Name + " BETS " + BetAmount + " DOLLARS ON " + CarToWin;
                  this.StatusUpdate();
                   return true;
            }
            else
            {
                  MessageBox.Show(Name + " HAS NO MORE CASH");
                  this.MyBet = null;
                 return false;
            }
        }
        //this method is used for collection of the player if he is winner then it will increment in his account
        public void Collect(string Winner)
        {
            if (MyBet != null) 
                Cash = Cash + MyBet.PayOut(Winner);
            ClearBet();
            StatusUpdate();
        }
    }
}
