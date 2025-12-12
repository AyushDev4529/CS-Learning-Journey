using CS_Learning_Journey.Interfaces;

namespace CS_Learning_Journey.Entities
{
    public abstract class Entity : IDamageable
    {
        public string? Name;//character Name
        public float Health;
        protected float MaxHealth;
        public int Row;
        public int Col;
        public float Damage;
        public float Defense;
        public char Symbol;// for console rendering
        public bool IsAlive;


        //setting  take Damage function
        public virtual float TakeDamage(float amount)
        {
            Health = Math.Clamp(Health - amount, 0, MaxHealth);
            Console.WriteLine($"{Name} took {amount} damage, remaining durability: {Health}");

            if (Health <= 0) IsAlive = false;
            return Health;
        }

        //setting  attack function
        public virtual float Attack(Entity entity)
        {
            float attackPower = Damage - (entity.Defense / 100) * Damage;
            entity.TakeDamage(attackPower);
            return attackPower;
        }



        //setting team color
        public abstract ConsoleColor GetTeamColor();

    }
}