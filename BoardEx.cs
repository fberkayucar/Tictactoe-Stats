using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public partial class Program
    {
        static void BoardEx(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                    board[row, col] = ' ';
            }
        }
    }
}
