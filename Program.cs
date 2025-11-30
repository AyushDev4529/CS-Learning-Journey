namespace CS_Learning_Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initializing Board grid
            TicTacToe.InitializeBoard();

            //payer input for TicTacToe
            int playerMove;
            bool isTurn = true;
            int gridSize = 3;
            int moveCounter = 0;

            TicTacToe.BoardRender();

            while (true)
            {
               
                if(isTurn)
                    Console.WriteLine("X turn enter No between 1-9 & q or Q to exit");
                else
                    Console.WriteLine("O turn enter No between 1-9 & q or Q to exit");
                
                string? inputX = Console.ReadLine();

                if(inputX == null)continue;
                else if(inputX == "Q" || inputX == "q")
                {
                    Console.WriteLine("OK Existing !");
                    break;
                }
                else if (int.TryParse(inputX, out playerMove) && playerMove > 0 && playerMove < 10)
                {
                    //Run TikTacToe
                    Console.Clear();
                    TicTacToe.TicTacToeRender(isTurn, playerMove);

                    //check winning
                    moveCounter++;
                    if ((TicTacToe.checkWin() == 'X' || TicTacToe.checkWin() == 'O') && moveCounter >= 3)
                    {
                        Console.WriteLine("Player " + TicTacToe.checkWin() + " WON!");
                        break;
                    }
                    else if (TicTacToe.checkWin() == '\0' && moveCounter >= gridSize * gridSize)
                    {
                        Console.Clear();
                        Console.WriteLine(" DRAW !!");
                        break;
                    }



                    //change player turn
                    isTurn = !isTurn;
                }
                

            }


            //mapSize input for Dungeon Map
            /*
            int mapSize;
            while (true)
            {
                Console.WriteLine("Enter Map Sie between 5 to 15");
                string? inputSize = Console.ReadLine();
                if(int.TryParse(inputSize, out mapSize) && mapSize >= 5 && mapSize <= 15)
                {
                    break;
                } 
                
            }
            
                while (true)
                {
                    //Console.WriteLine(" Enter WSAD to move , q to exsit");
                    Console.WriteLine();
                    //ReadKey(true) take input from key press & KeyChar gets char of the key
                    char input = Console.ReadKey(true).KeyChar;
                    Console.Clear();
                    if (input != 'q' || input != 'Q')
                    {
                    Run Dungeon Map
                    MapRenderer.DrawMap(input, mapSize);
                    }
                    else
                    {
                    Console.WriteLine("Ok existing");
                            break;
                    }   
                }
            */
        }
    }
}
