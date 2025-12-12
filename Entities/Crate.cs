using CS_Learning_Journey.Interfaces;

namespace CS_Learning_Journey.Entities
{
    public class Crate : IDamageable
    {
        public float Durability = 100;
        public string Name = "Crate";
        
        public float TakeDamage(float amount)
        {
            Durability = Math.Clamp(Durability - amount, 0, Durability);
            Console.WriteLine($"{Name} took {amount} damage, remaining durability: {Durability}");
            return Durability;
        }

    }
}
