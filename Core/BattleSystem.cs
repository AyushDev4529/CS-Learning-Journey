
using CS_Learning_Journey.Entity;
namespace CS_Learning_Journey.Core
{
    public class BattleSystem
    {
        public void StartBattle(Player player, Enemy enemy)
        {

            Console.Clear();
            bool PlayerTurn = true;
            
            Console.WriteLine("⚔️ BATTLE STARTED! ⚔️");

            //starting battle loop
            while (player.IsAlive && enemy.IsAlive)
            {
                Console.Clear();
                Console.WriteLine($"{player.Name} HP : {Math.Floor(player.Health)} | {enemy.Name} HP : {Math.Floor(enemy.Health)} ");
                if (PlayerTurn) Console.WriteLine(" Press Space Bar to Attack. ");
                else Console.WriteLine("Press any Key to Defend.");

                char input = Console.ReadKey().KeyChar;

                if (PlayerTurn && input == ' ')
                {
                    Console.WriteLine($"{player.Name} : Attacking {enemy.Name}");
                    System.Threading.Thread.Sleep(500);

                    player.Attack(enemy);
                    PlayerTurn = false;
                }
                else if (!PlayerTurn)
                {
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
                Console.WriteLine("Player Won!");
            }
            else
            {
                Console.WriteLine($"{player.Name} got defeated by {enemy.Name}");
            }

            
        }
        
    }
}
