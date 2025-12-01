using CS_Learning_Journey;
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

        // calculate next player position based on input
        
        switch(char.ToLower(playerPosition))
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

    public static void Run()
    {
        //mapSize input for Dungeon Map

        int mapSize;
        while (true)
        {
            Console.WriteLine("Enter Map Sie between 5 to 15");
            string? inputSize = Console.ReadLine();
            if (int.TryParse(inputSize, out mapSize) && mapSize >= 5 && mapSize <= 15)
            {
                break;
            }

        }

        Console.Clear();
        MapRenderer.DrawMap('\0', mapSize);
        Console.WriteLine(" Enter WSAD to move , q to exit");


        while (true)
        {
            Console.WriteLine();
            //ReadKey(true) take input from key press & KeyChar gets char of the key
            char input = Console.ReadKey(true).KeyChar;
            Console.Clear();
            if (input == 'q' || input == 'Q')
            {
                Console.WriteLine("Ok existing");
                System.Threading.Thread.Sleep(1000);
                MainMenu.mainMenu();
                break;
            }
            else
            {
               

                //Run Dungeon Map
                MapRenderer.DrawMap(input, mapSize);
            }
            
        }

    }
}

