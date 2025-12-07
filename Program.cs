using CS_Learning_Journey.Core;
using CS_Learning_Journey.Entities;

namespace CS_Learning_Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entity enemy = new Entity();
            Player player = new Player(1,1);
            Enemy slime = new Enemy(5 , 5);
            GameLogic logic = new GameLogic();
            //int moveCounter = 0;
            //enemy.OnDeath += enemy.HandleOnDeath;
            //char input;

            int mapSize;

            while (true)
            {
                Console.WriteLine("Enter Map Size between 10 to 15");

                string? inputSize = Console.ReadLine();
                if (int.TryParse(inputSize, out mapSize) && mapSize >= 10 && mapSize <= 15)
                {
                    break;
                }
            }


            

            while (true)
            {
                Console.WriteLine("\nEnter WSAD to move , q to exit\n");
                Console.WriteLine();
                char playerInput = Console.ReadKey().KeyChar;


                if (playerInput == char.ToLower('q'))
                {
                    Console.WriteLine(" \nSaving and Exsiting!\n ");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }
                else if(playerInput == char.ToLower('w') || playerInput == char.ToLower('s') || playerInput == char.ToLower('a') || playerInput == char.ToLower('d'))
                {
                    Console.Clear();
                    char[,] arr = new char[mapSize, mapSize];
                    logic.TryMovePlayer(arr, player, slime, playerInput);
                    MapRenderer.DrawMap(arr, player, slime);
                }
                else
                {
                    Console.WriteLine("\n Enter WSAD to move , q to exit");
                }
            }

            //bool isPlayerActive = true;
            //while(isPlayerActive && enemy.IsAlive)
            //{


            //    Console.WriteLine("Press Space Bar to Attack ");
            //    Console.WriteLine($"Turn No {moveCounter}");
            //    System.Threading.Thread.Sleep(500);


            //    input = Console.ReadKey(true).KeyChar;
            //    if (input == ' ')
            //    { 
            //        player.Attack(enemy);
            //        moveCounter++;
            //        System.Threading.Thread.Sleep(500);
            //    }
            //    else if (char.ToLower(input) == 'q')
            //    { 
            //        System.Threading.Thread.Sleep(1000);
            //        Console.Clear();
            //        Console.WriteLine("Saving & Exsiting !");
            //        isPlayerActive = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong Key entred!");
            //        System.Threading.Thread.Sleep(500);
            //    }

            //Console.Clear();



            //}

            //MainMenu.mainMenu();
        }
    }
}

