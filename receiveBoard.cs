using System;
using System.Collections.Generic;
using System.Text;

namespace Section1Group9TicTac
{
    internal class receiveBoard
    {
        public void printBoard(string[] gameboard)
        {

            Console.WriteLine($"{gameboard[0]} | {gameboard[1]} | {gameboard[2]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{gameboard[3]} | {gameboard[4]} | {gameboard[5]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{gameboard[6]} | {gameboard[7]} | {gameboard[8]}");
        }

        public string checkWinner(string[] gameboard)
        {




            // Check horizontal rows for winners
            if (gameboard[0] == "x" && gameboard[1] == "x" && gameboard[2] == "x")
            {
                return ("3 in a row! X wins!");
            }
            else if (gameboard[0] == "o" && gameboard[1] == "o" && gameboard[2] == "o")
            {
                return ("3 in a row! O wins!");
            }
            else if (gameboard[3] == "x" && gameboard[4] == "x" && gameboard[5] == "x")
            {
                return ("3 in a row! X wins!");
            }
            else if (gameboard[3] == "o" && gameboard[4] == "o" && gameboard[5] == "o")
            {
                return ("3 in a row! O wins!");
            }
            else if (gameboard[6] == "x" && gameboard[7] == "x" && gameboard[8] == "x")
            {
                return ("3 in a row! X wins!");
            }
            else if (gameboard[6] == "o" && gameboard[7] == "o" && gameboard[8] == "o")
            {
                return ("3 in a row! O wins!");
            }

            // Check vertical rows for winners
            else if (gameboard[0] == "x" && gameboard[3] == "x" && gameboard[6] == "x")
            {
                return ("3 in a row! X wins!");
            }
            else if (gameboard[0] == "o" && gameboard[3] == "o" && gameboard[6] == "o")
            {
                return ("3 in a row! O wins!");
            }
            else if (gameboard[1] == "x" && gameboard[4] == "x" && gameboard[7] == "x")
            {
                return ("3 in a row! X wins!");
            }
            else if (gameboard[1] == "o" && gameboard[4] == "o" && gameboard[7] == "o")
            {
                return ("3 in a row! O wins!");
            }
            else if (gameboard[2] == "x" && gameboard[5] == "x" && gameboard[8] == "x")
            {
                return ("3 in a row! X wins!");
            }
            else if (gameboard[2] == "o" && gameboard[5] == "o" && gameboard[8] == "o")
            {
                return ("3 in a row! O wins!");
            }

            // Check diagonal
            else if (gameboard[0] == "x" && gameboard[4] == "x" && gameboard[8] == "x")
            {
                return ("3 in a row! X wins!");
            }
            else if (gameboard[0] == "o" && gameboard[4] == "o" && gameboard[8] == "o")
            {
                return ("3 in a row! O wins!");
            }
            else if (gameboard[2] == "x" && gameboard[4] == "x" && gameboard[6] == "x")
            {
                return ("3 in a row! X wins!");
            }
            else if (gameboard[2] == "o" && gameboard[4] == "o" && gameboard[6] == "o")
            {
                return ("3 in a row! O wins!");
            }

            int totalguesses = 0;
            for (int i = 0; i < 9; i++)
            {
                if (gameboard[i] == "x" | gameboard[i] == "o")
                {
                    totalguesses++;
                }
            }
            if (totalguesses == 9)
            {
                return ("It's a tie!");
            }

            // No winners yet, go again
            return "no";

        }
    }
}