using CS_Learning_Journey.Entities;
using static System.Net.Mime.MediaTypeNames;


namespace CS_Learning_Journey.Core
{
    public class GameLogic
    {
        public enum MoveResult { OutofBounds, EnemyAhead, WallAhead, Success }
        public void TryMovePlayer(char[,] map, Player player, Enemy enemy, char playerInput)
        {
            int mapSize = map.GetLength(0);

            //start with player current position
            int nextPlayerRow = player.row;
            int nextPlayerCol = player.col;

            // calculate next player position based on input

            switch (char.ToLower(playerInput))
            {
                case 'w':
                    nextPlayerRow--;
                    break;
                case 'a':
                    nextPlayerCol--;
                    break;
                case 's':
                    nextPlayerRow++;
                    break;
                case 'd':
                    nextPlayerCol++;
                    break;
            }

            if (playerInput == '\0') return;

            MoveResult result = CanMove(nextPlayerRow, nextPlayerCol, enemy, mapSize);

            //calculating player movement
            switch (result)
            {
                case MoveResult.Success:
                    player.row = nextPlayerRow;
                    player.col = nextPlayerCol;
                    break;
                case MoveResult.OutofBounds:
                    Console.WriteLine("You can't move outside the map!");
                    break;
                case MoveResult.EnemyAhead:
                    Console.WriteLine("Enemy Ahead! Preapare for battle!");
                    break;
                case MoveResult.WallAhead:
                    Console.WriteLine("A Wall blocks your path!");
                    break;

            }


           

          
        }


        public MoveResult CanMove(int nextRow, int nextCol, Enemy enemy, int mapSize)
        {

            //check if inBound 
            if ((nextRow < 0 || nextRow >= mapSize) || (nextCol < 0 || nextCol >= mapSize)) { return MoveResult.OutofBounds; }
            //Enemy range  check
            if (nextRow == enemy.Row && nextCol == enemy.Col) { return MoveResult.EnemyAhead; }
            else
                return MoveResult.Success;


        }

        

    }

    public class PlayerInput 
    {
        Player player = new Player(1, 1);
        Enemy slime = new Enemy(5, 5);
        GameLogic logic = new GameLogic();
        public int MapSizeInput()
        {
            int mapSize;
            while (true)
            {
                Console.WriteLine("Enter Map Size between 10 to 15");

                string? inputSize = Console.ReadLine();
                if (int.TryParse(inputSize, out mapSize) && mapSize >= 10 && mapSize <= 15)
                {
                    return mapSize;
                }
            }

        }

        public void MovementLogic()
        {
            //MapSizeInput();   
            int mapSize = MapSizeInput();
            char[,] arr = new char[mapSize, mapSize];
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
                else if (playerInput == char.ToLower('w') || playerInput == char.ToLower('s') || playerInput == char.ToLower('a') || playerInput == char.ToLower('d'))
                {
                    Console.Clear();
                    
                    logic.TryMovePlayer(arr, player, slime, playerInput);
                    MapRenderer.DrawMap(arr, player, slime);
                }
                else
                {
                    Console.Clear();
                    MapRenderer.DrawMap(arr,player, slime);
                    //Console.WriteLine("\n Enter WSAD to move , q to exit");
                }
            }
        }

    }


}

