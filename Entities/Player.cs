
namespace CS_Learning_Journey.Entities
{
    public class Player : Entity
    {
        //random no gen
        static Random rand = new Random();

        //Constructor to assign Player values
        public Player(int initialRow, int initialCol)
        {
            Name = "Player";
            Health = 100;
            MaxHealth = 1000;
            Row = initialRow;
            Col = initialCol;
            Damage = 25;
            Defense = 10;
            Symbol = '@';
            IsAlive = true;
        }

        //setting player Color
        public override ConsoleColor GetTeamColor()
        {
            return ConsoleColor.Green;
        }

        public override float Attack(Entity entity)
        {
            float attackPower;
            int CritChance;
            CritChance = rand.Next(0, 100);
            //critical hit chance 20%
            if (CritChance < 20)
            {
                //Critical hit does double damage
                 attackPower = (Damage - (entity.Defense / 100) * Damage) * 2;
                Console.WriteLine("✨ CRITICAL HIT! ✨");
                System.Threading.Thread.Sleep(300);
            }
            else
            {
                 attackPower = Damage - (entity.Defense / 100) * Damage;
            }

            entity.TakeDamage(attackPower);

            return attackPower;
        }
    } 
   
}


