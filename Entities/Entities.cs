using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Learning_Journey.Entity
{
    public class Entity
    {
        public string? Name;//character Name
        public float Health;
        protected float MaxHealth;
        public int Row;
        public int Col;
        public float Damage;
        //public float crit;
        public float Defence;
        public char Symbol;// for console rendering
        public bool IsAlive;


        //setting  take Damage function
        public virtual float TakeDamage(float amount)
        {
            Health = Math.Clamp(Health - amount, 0, MaxHealth);
            if (Health <= 0) IsAlive = false;
            return Health;
        }

        //setting  attack function
        public virtual float Attack(Entity entity)
        {
            float attackPower = Damage - (entity.Defence / 100) * Damage;
            entity.TakeDamage(attackPower);
            return attackPower;
        }
    }
}