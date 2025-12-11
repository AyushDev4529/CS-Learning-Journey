
using System.Xml.Linq;

namespace CS_Learning_Journey.Entity
{
    public class Enemy :Entity
    {
 
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

        //setting enemy color
        public override ConsoleColor GetTeamColor()
        {
            return ConsoleColor.Red;
        }



    }
}
