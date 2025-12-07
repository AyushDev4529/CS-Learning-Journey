
namespace CS_Learning_Journey.Entities
{
    public class Entity
    {
        public string? name;//character name
        protected int health;
        protected int maxHealth;
        public int row;
        public int col;
        public int damage;
        public char symbol;// for console rendering

        //overriding string in Entity to display useful info when printing entity
        public override string ToString()
        {
            return $"{name} {health}/{maxHealth} {row} {col}";
        }

        public event Action<Entity> OnDeath;//Declaring a event
        public void HandleOnDeath(Entity entity)
        {
            Console.WriteLine($"{entity} has Fallen!!");
            
        }
        public Entity()
        {
            name = "Enemy";
            health = 100;
            maxHealth = 100;
            row = 0; col = 0;
            damage = 10;
            symbol = 'A';
        }

        public bool Move(int dRow, int dCol)
        {
            int newRow = dRow + row;
            int newCol = dCol + col;
            row = newRow;
            col = newCol;
            return (dRow != 0 || dCol != 0);
            
                
        }


        public virtual void TakeDamage(int amount)
        {
            health -= amount;

            health = Math.Clamp(health, 0, maxHealth);// return min if value is smaller then min
            if(health == 0) OnDeath?.Invoke(this);
            Console.WriteLine($"{name} took damage!");
            
            //- If there are subscribers to the event → call them, passing the current entity (this) as the argument.
            //- If no subscribers → do nothing (avoids NullReferenceException).

        }

        public bool IsAlive => health > 0;
    }

    public class Player : Entity 
    {
        public void Attack(Entity target)
        {
            int dmg = (damage == 0) ? 0 : damage;
            
            target.TakeDamage(dmg);
            //Console.WriteLine($"{target} took {damage} damge !");

        }

        public Player(int initialRow,int initialCol)
        {
            name = "Player";
            health = 100;
            maxHealth = 1000;
            row = initialRow; col = initialCol;
            damage = 25;
            symbol = '@';
        }
      
 
    }
}


