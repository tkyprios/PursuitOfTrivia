using System;
using System.Collections.Generic;
using System.Linq;

namespace Pursuit_of_Trivia
{
    /// <summary>
    /// Class representing the overall game state, including setting up players (and bots) and initializing the game table with the master question deck.
    /// </summary>
    internal class Game
    {
        public Table GameTable { get; set; }

        public Player currentPlayer { get; set; }


        public Game() 
        {
            GameTable = new Table(new Deck(GetAllQuestionCategories()));
        }
        public void SetupPlayers()
        {
            Console.Clear();

            Console.WriteLine("Let's get you set up!");

            Console.WriteLine("What would you like your username to be?");
            string playerUsername = Console.ReadLine();

            currentPlayer = new Player(playerUsername);
            Console.WriteLine($"Welcome, {currentPlayer.Name}! Press any key to start the game...");
            Console.ReadKey(true);
            
            GameTable.AddPlayerToGame(currentPlayer);
            GameTable.AddBotToGame();
        }

        private List<Category> GetAllQuestionCategories()
        {
            return Enum.GetValues(typeof(Category)).Cast<Category>().ToList();
        }
    }
}
