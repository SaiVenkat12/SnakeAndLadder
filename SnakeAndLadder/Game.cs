using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Game
    {
        public static void GamePlay()
        {
            int position = 0;
            Random random= new Random();
            int diceRoll=random.Next(1, 7);
            position = diceRoll ;
            Console.WriteLine("Player 1 position : " + position);
        }
    }
}
