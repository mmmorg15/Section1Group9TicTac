// Group 1-9 Jake Fuhriman, Anders Houghton, Merrick Morgan, Peter Young
// public void printBoard(array)
// public string checkWinner(array)



using Section1Group9TicTac;
using System.ComponentModel.Design;

receiveBoard rb = new receiveBoard();

string [] board = ["0", "1", "2", "3", "4", "5", "6", "7", "8"];
string result = "";

// Welcome to the Game
Console.WriteLine("Welcome to Tic-Tac_Toe");

for (int turn = 1; turn <= 9; turn++)
{
    // Show board before the move
    rb.printBoard(board);

    int currentPlayer = (turn % 2 == 1) ? 1 : 2;
    string mark = (currentPlayer == 1) ? "x" : "o";

    int playerInput;

    while (true)
    {
        Console.Write($"Player {currentPlayer} ({mark}), pick a spot (0-8): ");

        if (!int.TryParse(Console.ReadLine(), out playerInput))
        {
            Console.WriteLine("Enter a number 0–8.");
            continue;
        }

        if (playerInput < 0 || playerInput > 8)
        {
            Console.WriteLine("Pick a valid spot 0–8.");
            continue;
        }

        if (board[playerInput] == "x" || board[playerInput] == "o")
        {
            Console.WriteLine("That spot is taken. Try again.");
            continue;
        }

        break;
    }

    
    board[playerInput] = mark;


    result = rb.checkWinner(board);
    if (result != "no")
    {
        break;
    }
}


//Print winner Message
rb.checkWinner(board);
