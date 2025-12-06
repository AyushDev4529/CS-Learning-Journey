namespace CS_Learning_Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entity enemy = new Entity();
            Player player = new Player();
            int moveCounter = 0;
            enemy.OnDeath += enemy.HandleOnDeath;
            char input;
            
            bool isPlayerActive = true;
            while(isPlayerActive && enemy.IsAlive)
            {
                
                Console.WriteLine("Press Space Bar to Attack ");
                Console.WriteLine($"Turn No {moveCounter}");
                System.Threading.Thread.Sleep(500);
                
                
                input = Console.ReadKey(true).KeyChar;
                if (input == ' ')
                { 
                    player.Attack(enemy);
                    moveCounter++;
                    System.Threading.Thread.Sleep(500);
                }
                else if (char.ToLower(input) == 'q')
                { 
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Saving & Exsiting !");
                    isPlayerActive = false;
                }
                else
                {
                    Console.WriteLine("Wrong Key entred!");
                    System.Threading.Thread.Sleep(500);
                }

                //Console.Clear();



            }
            
            MainMenu.mainMenu();
        }
    }
}

