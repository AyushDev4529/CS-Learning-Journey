using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;


/*
 * ⚔️ The Project: Tic-Tac-Toe
We are going to build a fully functional console game. This project combines every single thing you learned this week:

2D Arrays (The Board)

Loops (The Game Round)

Conditionals (Checking for a Winner)
 */

namespace CS_Learning_Journey
{
    internal class TicTacToe
    {
        private static int gridSize = 3;
        public static char[][] grid = new char[gridSize][];
        //initialize the Board
        public static void InitializeBoard()
        {
            int sum = 1;
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = new char[gridSize];
                for (int j = 0; j < grid[i].Length; j++)
                {
                    //using explicit type conversion converting in32 value of 1+48 and so on, ('0' in ascaii is 48)
                    grid[i][j] = (char)(sum++ + '0');
                }
            }
        }

        //Renders Board
        public static void BoardRender()
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    Console.Write(" " + grid[i][j]);
                    if (j != gridSize - 1)
                        Console.Write(" |");
                }
                Console.WriteLine("\n---+---+---");
            }

        }

        //check win condition
        public static char checkWin()
        {
            bool sameRow = true;
            bool sameCol = true;
            bool sameDiognal = true;
            char firstCellRow;
            char firstCellCol;
            char firstDiagonal, oppositeDiagonal;

            for (int i = 0; i < grid.Length; i++)
            {
                firstCellRow = grid[i][0];
                firstCellCol = grid[0][i];


                //Row check
                if (firstCellRow == 'X' || firstCellRow == 'O')
                {
                    sameRow = true;

                    for (int j = 1; j < grid[i].Length; j++)
                    {
                        if (firstCellRow != grid[i][j])
                        {
                            sameRow = false;
                            break;
                        }
                    }
                    if (sameRow) return firstCellRow;
                }
                //Col Check
                if (firstCellCol == 'O' || firstCellCol == 'X')
                {
                    sameCol = true;
                    for (int j = 1; j < grid[i].Length; j++)
                    {
                        if (firstCellCol != grid[j][i])
                        {
                            sameCol = false;
                            break;
                        }
                    }
                    if (sameCol) return firstCellCol;
                }

            }
            //Diognal check
            firstDiagonal = grid[0][0];
            if (firstDiagonal == 'X' || firstDiagonal == 'O')
            {
                sameDiognal = true;
                for (int i = 0; i < grid.Length; i++)
                {
                    if (grid[i][i] != firstDiagonal)
                    {
                        sameDiognal = false;
                        break;
                    }
                }
                if (sameDiognal) return firstDiagonal;
            }

            //Opposite Diognal check
            oppositeDiagonal = grid[0][gridSize - 1];
            if (oppositeDiagonal == 'X' || oppositeDiagonal == 'O')
            {
                sameDiognal = true;
                for (int i = 0; i < grid.Length; i++)
                {
                    if (grid[i][gridSize - 1 - i] != oppositeDiagonal)
                    {
                        sameDiognal = false;
                        break;
                    }
                }
                if (sameDiognal) return oppositeDiagonal;
            }
            return '\0';
        }

        public static char[][] TicTacToeRender(bool turn, int playerInput = 0 )
        {
            //check player input
            int row = (playerInput - 1) / gridSize;
            int col = (playerInput - 1) % gridSize;

            //update player input
            char symbol = (!turn)?'O':'X';
            char targetChar = (char)(playerInput + '0');

            if (grid[row][col] == targetChar && grid[row][col] != 'X' && grid[row][col] != 'O')
            {
                grid[row][col] = symbol;
            }
            




                BoardRender();

            return grid;

        }
         
    }
}
