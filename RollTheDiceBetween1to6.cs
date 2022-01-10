using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class RollTheDiceBetween1to6
    {
        public static void RollDicein1to6()
        {
            int player = 1;
           

            Random random = new Random();
            int DiceRoll = random.Next(1, 7);

            Console.WriteLine("No. of Player in there " + player);

            Console.WriteLine("You got number :" + DiceRoll);
            Console.ReadLine();
        }
    }
}
