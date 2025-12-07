
namespace CS_Learning_Journey.Entities
{
    public class Enemy
    {
        public int Row{ get; protected set; }
        public int Col{ get; protected set; }
        public int Health { get; protected set; }
        protected int MaxHealth;
        public char Symbol { get; protected set; } 

        public Enemy(int initialRow, int initialCol)
        {
            Row = initialRow; Col = initialCol;
            MaxHealth = 100;
            Health = MaxHealth;
            Symbol = 'E';
        }
        

    }
}
