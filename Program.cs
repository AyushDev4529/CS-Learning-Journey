namespace CS_Learning_Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                    Console.WriteLine(" Enter WSAD to move , q to exsit");
                    //ReadKey(true) take input from key press & KeyChar gets char of the key
                    char input = Console.ReadKey(true).KeyChar;
                    Console.Clear();
                    if (input != 'q' || input != 'Q')
                        MapRenderer.DrawMap(input, mapSize);
                    else
                    {
                    Console.WriteLine("Ok existing");
                            break;
                    }   
                }
            
        }   
    }
}
