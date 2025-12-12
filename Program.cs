
using CS_Learning_Journey.Interfaces;
using CS_Learning_Journey.UI;
using CS_Learning_Journey.Tests;


using CS_Learning_Journey.Entities;

namespace CS_Learning_Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListTest listTest = new ListTest();
            listTest.ListTestRun();

            MainMenu.mainMenu();

        }
    }
}

