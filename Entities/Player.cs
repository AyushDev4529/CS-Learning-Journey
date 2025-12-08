
namespace CS_Learning_Journey.Entities
{
    public class Player
    {
        public string? name;//character name
        protected float health;
        protected float maxHealth;
        public int row;
        public int col;
        public float damage;
        //public float crit;
        public float maxCrit {  get; protected set; }
        public float Defence;
        public char symbol;// for console rendering

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
        }


        //player attack enemy
        public void Attack(Enemy target)
        {
            float attakPower = damage - (target.Defence / 100) * damage;
            target.TakeDamage(attakPower);
        }

        public float TakeDamage(float amount)
        {
            health -= amount;
            return health;
        }
        
    }
    

    
}


