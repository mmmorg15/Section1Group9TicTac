// Group 1-9 Jake Fuhriman, Anders Houghton, Merrick Morgan, Peter Young
using Section1Group9TicTac;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
receiveBoard rb = new receiveBoard();
string[] gameboard = ["x", "o", "x", "o", "x", "o", " ", "x", "o"];

rb.printBoard(gameboard);

string result = (rb.checkWinner(gameboard));
if (result != "no")
{
    Console.WriteLine(result);
}



