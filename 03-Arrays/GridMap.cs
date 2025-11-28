using System;
using System.Collections.Generic;
using System.Text;

/* 
⚔️ Challenge: The Dungeon Map Renderer

Creates a 5x5 Integer Array (The Map).

Fills every slot with 0 (Floor).

Places a Player (represented by 1) at [0,0].

Places a Wall (represented by 2) at [2,2] and [2,3].

The Renderer: Uses a nested loop to print the map to the Console, but replaces the numbers with symbols:

0 → . (Floor)

1 → P (Player)

2 → # (Wall)
*/

int[][] map = new int[5][];
for (int i = 0; i < map.Length; i++)
{
    map[i] = new int[5];
}
map[0][0] = 1;
map[2][2] = 2;
map[2][3] = 2;

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
