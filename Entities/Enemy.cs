
using System.Xml.Linq;

namespace CS_Learning_Journey.Entities
{
    public class Enemy
    {
        public int Row{ get; protected set; }
        public int Col{ get; protected set; }
        public float Health;
        protected float MaxHealth;
        
        public string Name {  get; protected set; }
        public float Damage { get; protected set; }
        public float Defence { get; protected set; }
        public char Symbol { get; protected set; } 

        public Enemy(int initialRow, int initialCol)
        {
            Row = initialRow; 
            Col = initialCol;
            Name = "Slime";
            MaxHealth = 100f;
            Health = MaxHealth;
            
            Defence = 5f;
            Symbol = 'E';
        }

        public void Attack(Player player)
        {
            float AttackPower = Damage - (player.Defence / 100) * Damage;
        }
        public float TakeDamage(float amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name} took {amount} damage!");
            return Health;
        }
              
    }
}
