using CS_Learning_Journey.Entities;


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

}


