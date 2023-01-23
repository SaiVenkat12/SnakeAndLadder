﻿using System;
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
            const int snake = 0;
            const int ladder = 1;
            const int NoGame= 2;
            int position = 0;
            Random random= new Random();
            
            while(position<100)
            {
                int diceRoll = random.Next(1, 7);
                //Console.WriteLine("Dice Roll= " + diceRoll);
                int choice = random.Next(0, 3);
                switch (choice)
                {
                    case snake:
                        position -= diceRoll;
                        Console.WriteLine("Snake");
                        if (position < 0)
                        {
                            position = 0;
                            Console.WriteLine("Player 1 position : " + position);
                        }
                        else
                        {
                            Console.WriteLine("Player 1 position : " + position);
                        }
                        break;
                    case ladder:
                        position += diceRoll;
                        Console.WriteLine("Ladder");
                        if(position>=100)
                        {
                            position = 100;
                            Console.WriteLine("Player 1 position : " + position);
                            Console.WriteLine("player1 Wins");
                        }
                        else
                        {
                            Console.WriteLine("Player 1 position : " + position);
                        }
                        break;
                    case NoGame:
                        Console.WriteLine("No Game");
                        Console.WriteLine("Player 1 position : " + position);
                        break;
                }
            
            }
        }
    }
}
