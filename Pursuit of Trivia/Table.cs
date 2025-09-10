using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pursuit_of_Trivia
{
    /// <summary>
    /// Class that represents the game table, managing players and the master question deck.
    /// </summary>
    internal class Table
    {
        public List<Player> Players { get; private set; }

        public Deck MasterQuestionDeck { get; private set; }


        public Table(Deck masterQuestionDeck)
        {
            Players = new List<Player>();
            MasterQuestionDeck = masterQuestionDeck;
        }

        public void AddPlayerToGame(Player player)
        {
            Players.Add(player);
            Console.WriteLine($"Player {player.Name} has been added to the game!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }

        public void AddBotToGame()
        {
            Player bot = new Player("Bot");
            Players.Add(bot);
            Console.WriteLine("A bot has been added to the game!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
