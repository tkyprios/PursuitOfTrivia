using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pursuit_of_Trivia
{
    internal class Game
    {
        public Table GameTable { get; set; }

        public Player currentPlayer { get; set; }


        public Game() 
        {
            GameTable = new Table();
        }
        public void Setup()
        {
            Console.Clear();
            Console.WriteLine("What would you like your username to be?");
            string playerUsername = Console.ReadLine();

            currentPlayer = new Player(playerUsername);
            Console.WriteLine($"Welcome, {currentPlayer.Name}! Press any key to start the game...");
            Console.ReadKey(true);
            Console.ReadLine();
        }
    }
}
