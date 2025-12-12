
using System.Xml.Linq;

namespace CS_Learning_Journey.Entities
{
    public class Enemy :Entity
    {
 
        public Enemy(int initialRow, int initialCol)
        {
            Row = initialRow; 
            Col = initialCol;
            Name = "Slime";
            MaxHealth = 90f;
            Health = MaxHealth;
            Damage = 10;
            
            Defense = 5f;
            Symbol = 'E';
            IsAlive = true;

        }

        //setting enemy color
        public override ConsoleColor GetTeamColor()
        {
            return ConsoleColor.Red;
        }



    }
}
