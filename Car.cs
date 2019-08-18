using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CarRace
{
    public class Car
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public string Name;
        public PictureBox MyPictureBox = null;
        public bool Winner = false;
        public int Location = 0;
        public decimal oddsFor;
        public decimal oddsAgainst;
      
        public Random Randomizer;
    
        public bool Run()
        {
            // calling the next method of the random class and pass the value to the move variable from 1 to 6
            int move = Randomizer.Next(1, 6);
            Location = Location + move;
            // calling the method of movie picture box while passing the argument to the method
            MyPictureBox.Left = StartingPosition + Location;
            if (MyPictureBox.Left >= RaceTrackLength)   
            {
                Winner = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        //this user define method that is used for set all the pictures and all the starting position.this method is void method it will not return any value
        public void TakeStartingPosition()
        {
           Location = 0;
           MyPictureBox.Left = StartingPosition;
        }
    }
}
