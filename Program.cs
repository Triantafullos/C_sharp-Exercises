using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Init_Board(string[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = " ";
                }
            }
        }
        static void PrintBoard(string[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + "  | ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine("\n------------");
            }
        }
        static string ChangeTurn(string player)
        {
            if (player == "X")
            {
                player = "O";
            }
            else
            {
                player = "X";
            }
            return player;
        }

            
        static void Main(string[] args)
        {
            string player = "X";
            string[,] board = new string[3, 3];
            Console.WriteLine("Welcome to a game of Tic Tac Toe");
            Init_Board(board);
            PrintBoard(board);

            Console.Write("Please give us a row : ");
            int row = int.Parse(Console.ReadLine());
            while (row % 1 != 0 && row < 0 || row > 2)
            {
                Console.WriteLine("Please give us a Positive integer from 0 - 2 !");
                     row = int.Parse(Console.ReadLine());
            }
            Console.Write("Please give us a columns : ");
            int col = int.Parse(Console.ReadLine());
            while (col % 1 != 0 || col < 0 || col > 2 )
            {
                Console.WriteLine("Please give us a Positive integer from 0 - 2 !");
                     col = int.Parse(Console.ReadLine());
            }
            ChangeTurn(player);
            board[row, col] = player;
  
            PrintBoard(board);     
            
        }   
    }
}
