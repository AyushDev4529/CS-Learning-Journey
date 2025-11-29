using System;
using System.Collections.Generic;
using System.Text;

/* 
⚔️ Challenge: The Dungeon Map Renderer

Creates a 5x5 Integer Array (The Map).

Fills every slot with 0 (Floor).

Places a Player (represented by 1) at [0,0].

Places a Wall (represented by 2) at [2,2] and [2,4].

The Renderer: Uses a nested loop to print the map to the Console, but replaces the numbers with symbols:

0 → . (Floor)

1 → P (Player)

2 → # (Wall)
*/

public class MapRenderer
{
    private static int playerRow = 0;
    private static int playerCol = 0;
    public static int[][] DrawMap(char playerPosition = '\0' , int mapSize = 5)
    {
        //int mapSize = 10;
        //initalizing Jagged array for map 
        int[][] map = new int[mapSize][];
        for (int i = 0; i < mapSize; i++)
        {
            map[i] = new int[mapSize];
        }

        //setting walls
        int wallRow = 2;
        int wallCol = 2;
        int extraWallCol = wallCol + 2;
        map[wallRow][wallCol] = 2;
        map[wallRow][extraWallCol] = 2;

        //start with player current position
        int nextPlayerRow = playerRow;
        int nextPlayerCol = playerCol;

        //calculate next wall
        if (playerPosition == 'w' || playerPosition == 'W')
                nextPlayerRow--;
            if (playerPosition == 'a' || playerPosition == 'A')
                nextPlayerCol--;
            if (playerPosition == 's' || playerPosition == 'S')
                nextPlayerRow++;
            if (playerPosition == 'd' || playerPosition == 'D')
                nextPlayerCol++;


        //check if inBound
        bool inBound = (nextPlayerRow >= 0 && nextPlayerRow < mapSize) && (nextPlayerCol >= 0 && nextPlayerCol < mapSize);

        //wall collision check
        bool isWall = inBound && map[nextPlayerRow][nextPlayerCol] == 2;

        //calculating plpayer movement

        if (playerPosition != '\0' && !isWall  && inBound ) 
        { 
            playerRow = nextPlayerRow;
            playerCol = nextPlayerCol;
        }

        //setting player position
        if (playerRow >= 0 && playerCol >= 0 && playerRow < mapSize && playerCol < mapSize)
        { map[playerRow][playerCol] = 1; }


        //rendering map
        for (int i = 0; i < map.Length; i++)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    if (map[i][j] == 0)
                        Console.Write(". ");
                    if (map[i][j] == 1)
                        Console.Write("P ");
                    if (map[i][j] == 2)
                        Console.Write("# ");
        
                }
                Console.WriteLine();
            }


        return map;
    }
}