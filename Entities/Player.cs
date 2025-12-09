
namespace CS_Learning_Journey.Entities
{
    public class Player
    {
        public string? name;//character name
        public float health;
        protected float maxHealth;
        public int row;
        public int col;
        public float damage;
        //public float crit;
        public float maxCrit {  get; protected set; }
        public float Defence;
        public char symbol;// for console rendering
        public bool IsAlive;

        //Constructor to assign Player vanlues
        public Player(int initialRow, int initialCol)
        {
            name = "Player";
            health = 100;
            maxHealth = 1000;
            row = initialRow;
            col = initialCol;
            damage = 25;
            //crit = 0;
            Defence = 10;
            symbol = '@';
            IsAlive = true;
        }


        //player attack enemy
        public float Attack(Enemy target)
        {
            float attakPower = damage - (target.Defence / 100) * damage;
            target.TakeDamage(attakPower);
            
            return attakPower;
        }

        public float TakeDamage(float amount)
        {
            health = Math.Clamp(health-amount,0,maxHealth);
            
            if (health <= 0) { IsAlive = false; }
            return health;
        }
        
    }
    

    
}


