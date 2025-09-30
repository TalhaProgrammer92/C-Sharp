using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Board
{
    public class GameBoard
    {
        // Attributes
        public char[,] Grid { get; set; }

        // Constructor
        public GameBoard()
        {
            Grid = new char[3, 3]
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };
        }

        // Method - Reset board
        public void Reset()
        {
            char count = '1';
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Grid[i, j] = count;
                }
                count++;
            }
        }

        // Method - Display
        public void Display()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write($"{Grid[i, j]} ");
                Console.WriteLine();
            }
        }
    }
}
