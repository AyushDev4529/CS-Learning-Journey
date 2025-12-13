
using CS_Learning_Journey.Core;
using CS_Learning_Journey.Tests;
using CS_Learning_Journey.Entities;
using CS_Learning_Journey.Interfaces;
using CS_Learning_Journey.UI;


namespace CS_Learning_Journey
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Inventory System Test
            DictTest inventoryTestRunner = new DictTest();
            inventoryTestRunner.inventoryDictTest();


            GameManager gameManager = new GameManager();
            for (int i = 0; i < 10; i++)
            {
                gameManager.Update();


            }
        }
    }
}

