
using System.Xml.Linq;

namespace CS_Learning_Journey.Entities
{
    public class Enemy
    {
        public int Row;
        public int Col;
        public float Health;
        public float MaxHealth;
        
        public string? Name {  get; protected set; }
        public float Damage { get; protected set; }
        public float Defence { get; protected set; }
        public char Symbol { get; protected set; }
        public bool IsAlive;

        public Enemy(int initialRow, int initialCol)
        {
            Row = initialRow; 
            Col = initialCol;
            Name = "Slime";
            MaxHealth = 100f;
            Health = MaxHealth;
            Damage = 10;
            
            Defence = 5f;
            Symbol = 'E';
            IsAlive = true;

        }

        //setting player attack function
        public float Attack(Player player)
        {
            float attackPower = Damage - (player.Defence / 100) * Damage;
            
            player.TakeDamage(attackPower);
            return attackPower;
        }

        //setting player take damage function
        public float TakeDamage(float amount)
        {
            Health = Math.Clamp(Health - amount, 0, MaxHealth);
            
            if (Health <= 0) IsAlive = false;
            return Health;
        }
        
    }
}
