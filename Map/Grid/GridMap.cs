using CS_Learning_Journey.Entities;


/* 
⚔️ Challenge: The Dungeon Map Renderer
*/

public class MapRenderer
{
    public static void DrawMap(char[,] map, Player player, Enemy enemy)
    {
        int MapSize = map.GetLength(0);




        //intitalizing map with no 0-Row*Col(map.GetLeangth(0)
        for (int i = 0; i < MapSize; i++)
        {
            for (int j = 0; j < MapSize; j++)
            {
                //setting up player position
                if (player.row == i && player.col == j)
                    map[i, j] = player.symbol;
                else if (enemy.Row == i && enemy.Col == j)
                    map[i, j] = enemy.Symbol;
                else
                    map[i, j] = '.';

            }
        }



        //Draw to Console
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                Console.Write(map[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}

