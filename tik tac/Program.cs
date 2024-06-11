using System;

namespace TicTacToe
{
    class Program
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; // Player 1 starts
        static int choice; // Chosen position

        static void Main(string[] args)
        {
            do
            {
                Console.Clear(); // Whenever loop will restart, screen will be clear
                Console.WriteLine("Player 1: X and Player 2: O");
                Console.WriteLine("\\n");

                if (player % 2 == 0) // Checking the chance of the player
                {
                    Console.WriteLine("Player 2's turn");
                }
                else
                {
                    Console.WriteLine("Player 1's turn");
                }
                Console.WriteLine("\\n");
                Board(); // calling the board Function
                choice = int.Parse(Console.ReadLine()); // Taking users choice

                // Checking if the position entered is already occupied
                if (board[choice - 1] != 'X' && board[choice - 1] != 'O')
                {
                    if (player % 2 == 0) // If chance is of player 2
                    {
                        board[choice - 1] = 'O';
                        player++;
                    }
                    else // If chance is of player 1
                    {
                        board[choice - 1] = 'X';
                        player++;
                    }
                }
                else // If there is any position where user want to run the game and it's already marked
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, board[choice - 1]);
                    Console.WriteLine("\\n");
                    Console.WriteLine("Please wait 2 second board is loading again...");
                    System.Threading.Thread.Sleep(2000);
                }
            } while (!CheckWin() && player < 10); // This loop will be run until all cell of the board will not be filled

            Console.Clear(); // clearing the console
            Board();

            if (CheckWin() && player < 10)
            {
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 1 wins!");
                }
                else
                {
                    Console.WriteLine("Player 2 wins!");
                }
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }

        private static void Board() // Board method which creats board
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
            Console.WriteLine("||__ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
            Console.WriteLine("||__ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
            Console.WriteLine("     |     |      ");
        }

        private static bool CheckWin() // checking winning condition
        {
            if (board[0] == board[1] && board[1] == board[2])
            {
                return true;
            }
            else if (board[3] == board[4] && board[4] == board[5])
            {
                return true;
            }
            else if (board[6] == board[7] && board[7] == board[8])
            {
                return true;
            }
            else if (board[0] == board[3] && board[3] == board[6])
            {
                return true;
            }
            else if (board[1] == board[4] && board[4] == board[7])
            {
                return true;
            }
            else if (board[2] == board[5] && board[5] == board[8])
            {
                return true;
            }
            else if (board[0] == board[4] && board[4] == board[8])
            {
                return true;
            }
            else if (board[2] == board[4] && board[4] == board[6])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
