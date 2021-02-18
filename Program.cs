using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    public partial class Program
    {
        static void Main(string[] args)
        {

            int turns = 9;
            char player = 'X';
            int choice;
            int row, col;
            char quit;
            char[,] board = new char[3, 3];
            string playerw,playerw1;
            statsTxt();
            do
            {
                board = new char[3, 3];
                Console.Clear();
                Console.WriteLine("1.Start");
                Console.WriteLine("2.Editor");
                Console.WriteLine("3.Exit");
                Console.WriteLine("4.Stats");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {

                    Console.WriteLine("Who's playing?");
                    playerw = Console.ReadLine();
                    Console.WriteLine("2. player?");
                    playerw1 = Console.ReadLine();
                    while (true)
                    {

                        Console.Clear();
                        for (row = 0; row < 3; row++)
                        {

                            Console.Write(row + 1 + "| ");
                            for (col = 0; col < 3; col++)
                            {
                                Console.Write(board[row, col]);
                                Console.Write(" | ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("   1   2   3   ");
                        Console.WriteLine("Player '" + player + "' is playing!");
                        Console.WriteLine("Select the row");
                        row = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Select column");
                        col = Convert.ToInt32(Console.ReadLine()) - 1;
                        board[row, col] = player;


                        if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!");
                            if (player == 'X')
                                stats(playerw + " won against " + playerw1 );
                            else if (player == 'O')
                            {
                                stats(playerw1 + " won against " + playerw );
                            }
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        if (turns == 0)
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("We have a draw here 'X' and 'O' pretty good at this game");
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        else if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!\a");
                            if (player == 'X')
                                stats(playerw + " won against " + playerw1);
                            else if (player == 'O')
                            {
                                stats(playerw1 + " won against " + playerw);
                            }
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }

                        else if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!\a");
                            if (player == 'X')
                                stats(playerw + " won against " + playerw1);
                            else if (player == 'O')
                            {
                                stats(playerw1 + " won against " + playerw);
                            }
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        else if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!\a");
                            if (player == 'X')
                                stats(playerw + " won against " + playerw1);
                            else if (player == 'O')
                            {
                                stats(playerw1 + " won against " + playerw);
                            }
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        else if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!\a");
                            if (player == 'X')
                                stats(playerw + " won against " + playerw1);
                            else if (player == 'O')
                            {
                                stats(playerw1 + " won against " + playerw);
                            }
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        else if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!\a");
                            if (player == 'X')
                                stats(playerw + " won against " + playerw1);
                            else if (player == 'O')
                            {
                                stats(playerw1 + " won against " + playerw);
                            }
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        else if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!\a");
                            if (player == 'X')
                                stats(playerw + " won against " + playerw1);
                            else if (player == 'O')
                            {
                                stats(playerw1 + " won against " + playerw);
                            }
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        else if (player == board[0, 2] && player == board[1, 1] && player == board[2, 0])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Great! Player '" + player + "' won!\a");
                            if (player == 'X')
                                stats(playerw + " won against " + playerw1);
                            else if (player == 'O')
                            {
                                stats(playerw1 + " won against " + playerw);
                            }
                            Console.WriteLine("Press enter to return menu..");
                            Console.ReadLine();
                            break;
                        }
                        if (player == 'X')
                        {
                            player = 'O';
                        }
                        else
                        {
                            player = 'X';
                        }

                    }

                }
                else if (choice == 2)
                {
                    Console.WriteLine("Fevzi Berkay Ucar\nAydede street 26/3\n06590 ANKARA ");
                    Console.WriteLine("Press enter to return menu..");
                    Console.ReadLine();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Do you want to quit?\n1.Exit\n2.Return to menu..\nPlease type one.");
                    quit = (char)Convert.ToInt32(Console.ReadLine());
                    if (quit == 1)
                    {
                        break;
                    }
                    else if (quit == 2)
                    {
                        Console.WriteLine("Press enter to return menu...");
                        Console.ReadLine();
                    }
                }
                else if(choice == 4)
                {
                    Console.Clear();
                    
                    StreamReader sr = new StreamReader(@"C:\stats.txt");
                    string Veri = sr.ReadToEnd();
                    sr.Close();
                    Console.WriteLine(Veri);
                    
                    Console.WriteLine("Press enter to return menu...");
                    Console.ReadLine();
                }


            } while (true);
            Console.WriteLine("To exit the game just press any button");
            Console.ReadKey();
        }








    }
}