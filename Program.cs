namespace CS_Learning_Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entity enemy = new Entity();
            enemy.OnDeath += enemy.HandleOnDeath;
            enemy.TakeDamage(1000);
            //MainMenu.mainMenu();
        }
    }
}

