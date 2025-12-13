using CS_Learning_Journey.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Learning_Journey.Core
{

    public enum GameState
    {
        MainMenu,
        Playing,
        Paused,
        GameOver
    }

    public class GameManager
    {
        protected GameState currentState;

        public GameManager()
        {
            currentState = GameState.MainMenu;
        }

        public void Update()
        {
            switch (currentState)
            {
                case GameState.MainMenu:
                    // Handle main menu logic
                    Console.WriteLine($"Game State: {currentState}");
                    MainMenu.mainMenu();

                    break;
                case GameState.Playing:
                    Console.WriteLine($"Game State: {currentState}");
                    // Handle gameplay logic
                    break;
                case GameState.Paused:
                    Console.WriteLine($"Game State: {currentState}");
                    // Handle paused logic
                    break;
                case GameState.GameOver:
                    Console.WriteLine($"Game State: {currentState}");
                    // Handle game over logic
                    break;
            }
        }
    }
}
