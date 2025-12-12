
using CS_Learning_Journey.Entities;
namespace CS_Learning_Journey.Core
{
    public class BattleSystem
    {
        public void StartBattle(Player player, Enemy enemy)
        {

            Console.Clear();
            bool PlayerTurn = true;
            
            Console.WriteLine("⚔️ BATTLE STARTED! ⚔️");
            var playerColor = player.GetTeamColor();
            var enemyColor = enemy.GetTeamColor();
            Console.ForegroundColor = ConsoleColor.White;
            //starting battle loop
            while (player.IsAlive && enemy.IsAlive)
            {

                Console.Clear();
                Console.ForegroundColor = playerColor;  
                Console.Write($"{player.Name} HP : {Math.Floor(player.Health)} ");
                Console.ForegroundColor = enemyColor;
                Console.Write($"| {enemy.Name} HP : {Math.Floor(enemy.Health)} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                if (PlayerTurn) Console.WriteLine(" Press Space Bar to Attack. ");
                else Console.WriteLine("Press any Key to Defend.");

                char input = Console.ReadKey().KeyChar;

                if (PlayerTurn && input == ' ')
                {
                    Console.ForegroundColor = playerColor;
                    Console.WriteLine($"{player.Name} : Attacking {enemy.Name}");
                    System.Threading.Thread.Sleep(500);

                    player.Attack(enemy);
                    PlayerTurn = false;
                }
                else if (!PlayerTurn)
                {
                    Console.ForegroundColor = enemyColor;
                    Console.WriteLine($"{player.Name} : Ouch!");
                    System.Threading.Thread.Sleep(500);
                    enemy.Attack(player);
                    PlayerTurn = true;

                }
                else continue;


            }

            Console.Clear();

            //Victory message
            if (player.Health > 0)
            {
                Console.ForegroundColor = playerColor;
                Console.WriteLine("Player Won!");
            }
            else
            {
                Console.ForegroundColor = enemyColor;
                Console.WriteLine($"{player.Name} got defeated by {enemy.Name}");
            }

            
        }
        
    }
}
