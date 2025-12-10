using CS_Learning_Journey.Core;
using CS_Learning_Journey.Entity;
using static System.Net.Mime.MediaTypeNames;


namespace CS_Learning_Journey.Core
{
    public class GameLogic
    {
        //enum for move results 
        public enum MoveResult { OutofBounds, EnemyAhead, WallAhead, Success }

        //setting function with enum return type
        public MoveResult TryMovePlayer(char[,] map, Player player, Enemy enemy, char playerInput)
        {
            int mapSize = map.GetLength(0);

            //start with player current position
            int nextPlayerRow = player.Row;
            int nextPlayerCol = player.Col;

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

            if (playerInput == '\0') return 0;

            MoveResult result = CanMove(nextPlayerRow, nextPlayerCol, enemy, mapSize);


            //calculating player movement
            switch (result)
            {
                case MoveResult.Success:
                    player.Row = nextPlayerRow;
                    player.Col = nextPlayerCol;
                    return MoveResult.Success;

                case MoveResult.OutofBounds:
                    Console.WriteLine("You can't move outside the map!");
                    return MoveResult.OutofBounds;

                case MoveResult.EnemyAhead:
                      return MoveResult.EnemyAhead;
                    
                case MoveResult.WallAhead:
                    Console.WriteLine("A Wall blocks your path!");
                    return MoveResult.WallAhead;

                default:
                    return 0;

            }
        }


        //Checking if player can move
        public MoveResult CanMove(int nextRow, int nextCol, Enemy enemy, int mapSize)
        {

            //check if inBound 
            if ((nextRow < 0 || nextRow >= mapSize) || (nextCol < 0 || nextCol >= mapSize)) { return MoveResult.OutofBounds; }
            //Enemy range  check
            // Check Enemy Collision - ONLY if alive!
            // If the enemy is dead, this if-statement fails, 
            // and the code moves to the 'else' block (Success), allowing the player to walk.
            if (nextRow == enemy.Row && nextCol == enemy.Col && enemy.IsAlive) { return MoveResult.EnemyAhead; }
            else
                return MoveResult.Success;


        }

    }


    public class PlayerInput
    {
        //initializing game objects
        Player player = new Player(1, 1);
        Enemy slime = new Enemy(5, 5);
        GameLogic logic = new GameLogic();

        //taking map size, in future there will be only 3 map size of dungeoun of connected rooms
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

            //taking input for movment
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
                    GameLogic.MoveResult result = logic.TryMovePlayer(arr, player, slime, playerInput);
                    if (result == GameLogic.MoveResult.EnemyAhead)
                    {
                        BattleSystem battle = new BattleSystem();
                        battle.StartBattle(player, slime);
                    }

                    MapRenderer.DrawMap(arr, player, slime);
                }
                else
                {
                    Console.Clear();
                    MapRenderer.DrawMap(arr, player, slime);
                    //Console.WriteLine("\n Enter WSAD to move , q to exit");
                }
            }
        }

    }
}
