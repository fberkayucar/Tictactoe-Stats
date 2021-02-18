using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public partial class Program
    {
        static void Print(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {

                Console.Write(row + 1 + "| ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("   1   2   3   ");
        }
    }
}
