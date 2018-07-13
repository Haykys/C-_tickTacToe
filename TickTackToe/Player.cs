using System;
using System.Collections.Generic;
using System.Text;

namespace TickTackToe
{
    class Player
    {

        public bool Player1 { get; set; } = true;
        public bool Player2 { get; set; } = false;
        public bool GameOver { get; set; } = false;
        public int NumberOfRounds { get; set; } = 0;

        public void choseNumber()
        {
            Board board = new Board();
            Console.Clear();

            while (!GameOver)
            {
                board.createAndUpdateBoard();
                if ((board.PlayFields[0] == "O" && board.PlayFields[1] == "O" && board.PlayFields[2] == "O") ||
                    (board.PlayFields[3] == "O" && board.PlayFields[4] == "O" && board.PlayFields[5] == "O") ||
                    (board.PlayFields[6] == "O" && board.PlayFields[7] == "O" && board.PlayFields[8] == "O") ||
                    (board.PlayFields[0] == "O" && board.PlayFields[3] == "O" && board.PlayFields[6] == "O") ||
                    (board.PlayFields[1] == "O" && board.PlayFields[4] == "O" && board.PlayFields[7] == "O") ||
                    (board.PlayFields[2] == "O" && board.PlayFields[5] == "O" && board.PlayFields[8] == "O") ||
                    (board.PlayFields[0] == "O" && board.PlayFields[4] == "O" && board.PlayFields[8] == "O") ||
                    (board.PlayFields[2] == "O" && board.PlayFields[4] == "O" && board.PlayFields[6] == "O"))
                {
                    Console.WriteLine("Player 1 has won!");
                    Console.WriteLine("Press any key to restart the game");
                    NumberOfRounds = 0;
                    Console.ReadKey();
                    choseNumber();
                } else if ((board.PlayFields[0] == "X" && board.PlayFields[1] == "X" && board.PlayFields[2] == "X") ||
                    (board.PlayFields[3] == "X" && board.PlayFields[4] == "X" && board.PlayFields[5] == "X") ||
                    (board.PlayFields[6] == "X" && board.PlayFields[7] == "X" && board.PlayFields[8] == "X") ||
                    (board.PlayFields[0] == "X" && board.PlayFields[3] == "X" && board.PlayFields[6] == "X") ||
                    (board.PlayFields[1] == "X" && board.PlayFields[4] == "X" && board.PlayFields[7] == "X") ||
                    (board.PlayFields[2] == "X" && board.PlayFields[5] == "X" && board.PlayFields[8] == "X") ||
                    (board.PlayFields[0] == "X" && board.PlayFields[4] == "X" && board.PlayFields[8] == "X") ||
                    (board.PlayFields[2] == "X" && board.PlayFields[4] == "X" && board.PlayFields[6] == "X"))
                {
                    Console.WriteLine("Player 2 has won!");
                    Console.WriteLine("Press any key to restart the game");
                    NumberOfRounds = 0;
                    Console.ReadKey();
                    choseNumber();
                } else if (NumberOfRounds == 9)
                {
                    Console.WriteLine("It's a draw!");
                    Console.WriteLine("Press any key to restart the game");
                    NumberOfRounds = 0;
                    Console.ReadKey();
                    choseNumber();
                }
                else if (Player1)
                {
                    Console.WriteLine("Player 1: Choose your field!");
                } else if (Player2)
                {
                    Console.WriteLine("Player 2: Choose your field!");
                }

                string input = Console.ReadLine();

                int counter = 0;
                foreach (string field in board.PlayFields)
                {
                    if (input == field && Player1)
                    {
                        board.PlayFields[counter] = "O";
                        NumberOfRounds++;
                        Player1 = false;
                        Player2 = true;

                    } else if (input == field && Player2)
                    {
                        board.PlayFields[counter] = "X";
                        NumberOfRounds++;
                        Player1 = true;
                        Player2 = false;
                    }
                    counter++;
                }
                Console.Clear();
            }
        }
    }
}
