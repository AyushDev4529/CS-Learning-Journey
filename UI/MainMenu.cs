using CS_Learning_Journey.Map.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Learning_Journey.UI
{
    internal class MainMenu
    {

        public static void mainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----AYUSH'S ARCADE----");
                Console.WriteLine("Choose A game to Play. ");
                Console.WriteLine("1. Dungeoun Map! ");
                Console.WriteLine("2. Tic Tac Toe! ");
                Console.WriteLine("3. Exit! ");

                char choice = Console.ReadKey(true).KeyChar;

                switch (choice)
                {
                    case '1':
                        //Run Dungeoun Map
                        //Console.Clear();
                        //System.Threading.Thread.Sleep(1000);
                        //MapRenderer.Run();
                        break;
                    case '2':
                        Console.Clear();
                        //initializing Board grid
                        System.Threading.Thread.Sleep(1000);
                        TicTacToe.InitializeBoard();
                        //Run TicTacToe
                        TicTacToe.Run();
                        break;
                    case '3':
                        return;
                    default:
                        Console.WriteLine("Invalid Option! ");
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
            }

        }
    }
}
