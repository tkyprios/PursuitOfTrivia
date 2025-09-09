using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pursuit_of_Trivia
{
    internal class Table
    {
        public List<Player> Players { get; private set; }
        public Table()
        {
            Players = new List<Player>();
        // @TODO generate questions, add question cards (class) and answers, card deck per category?
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
