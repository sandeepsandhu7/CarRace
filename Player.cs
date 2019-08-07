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
        public Bet MyBet;
        public decimal Cash;
        public int[] GuyArray;

        public RadioButton MyRadioButton;
        public Label MyLabel;
        public Label MyLabel2;

     

        public void StatusUpdate()
        {
            MyRadioButton.Text = Name + " HAS $" + Cash;   
        }

        public void ClearBet()
        {
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

        public void Collect(string Winner)
        {
            if (MyBet != null) 
                Cash = Cash + MyBet.PayOut(Winner);
            ClearBet();
            StatusUpdate();
        }
    }
}
