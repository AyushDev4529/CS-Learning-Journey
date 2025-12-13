using CS_Learning_Journey.Core;
using CS_Learning_Journey.Entities;
using CS_Learning_Journey.Interfaces;
using System;
using System.Collections.Generic;

namespace CS_Learning_Journey.Tests
{
    public class ListTest
    {
        public void ListTestRun()
        {
            List<IDamageable> destructibles = new List<IDamageable>();
            destructibles.Add(new Crate());
            destructibles.Add(new Enemy(0, 0));

            foreach (IDamageable destructible in destructibles)
            {
                float remainingHealth = destructible.TakeDamage(10);
                Console.WriteLine($"Something took 10 Damage! Remaining HP {remainingHealth}");
            }

            Console.ReadKey();

        }
    }
}
