using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class ExactWinningPositionAt100
    {
        public const int NoPlay = 0;
        public const int GotLadder = 1;
        public const int SnakeBite = 2;
        public const int WinningP = 100;
        public static void RepeatTillWinningAtPosition100()
        {

            int StartingP = 1;
            int CurrentP = 0;


            while (StartingP <= WinningP)
            {

                Random random = new Random();
                int DiceRoll = random.Next(1, 7);
                Console.WriteLine("You are getting the Number:" + DiceRoll);

                Random random1 = new Random();
                int Check = random1.Next(0, 3);

                CurrentP = StartingP + DiceRoll;

                if (CurrentP == 100)
                {

                    StartingP = StartingP - DiceRoll;
                    Console.WriteLine("....................You won the game...................... ");

                    break;
                }
                else if (CurrentP > 100)
                {

                    Console.WriteLine("you do not have any option and you will have to stay in that position: " + DiceRoll);
                    Console.WriteLine("You are at position :" + StartingP);
                    continue;



                }


                if (Check == NoPlay)
                {

                    Console.WriteLine("You do not have any option ");
                    Console.WriteLine("You are staying in that position");


                }
                else if (Check == GotLadder)
                {
                    StartingP = StartingP + DiceRoll;
                    Console.WriteLine("You are moving forward by:" + DiceRoll);
                }
                else if (Check == SnakeBite)
                {
                    StartingP = StartingP - DiceRoll;
                    Console.WriteLine("You are moving Backward by" + DiceRoll);

                }

                if (StartingP <= 0)
                {


                    StartingP = StartingP - StartingP;
                    Console.WriteLine("...............You lost the Game........................:");
                    Console.WriteLine(".............Restart the Game............");


                }

                Console.WriteLine("Your position is " + StartingP);


            }

        }
    }
}
