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

        /// <summary>
        /// Constructor for the Game class, initializes the game table with a master deck of questions covering all categories.
        /// </summary>
        public Game() 
        {
            GameTable = new Table(new Deck(GetAllQuestionCategories()));
        }

        /// <summary>
        /// Retrieves a list of all available question categories.
        /// </summary>
        /// <remarks>The method returns all values of the <see cref="Category"/> enumeration as a list. 
        /// <returns>A list of all categories defined in the <see cref="Category"/> enumeration.</returns>
        private List<Category> GetAllQuestionCategories() => 
            Enum.GetValues(typeof(Category)).Cast<Category>().ToList();

        /// <summary>
        /// Sets up the players for the game by prompting the user for their username and initializing the current
        /// player and a bot player.
        /// </summary>
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


    }
}
