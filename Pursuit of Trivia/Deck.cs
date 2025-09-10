using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pursuit_of_Trivia

///<summary>
/// Deck class represents a collection of trivia question cards organized by their categories.
///</summary>
/// <remarks> Think of this like a massive stack of question cards, each sorted into their respective categories (decks)</remarks>

{
    internal class Deck
    {
        private Dictionary<Category, List<Card>> QuestionDecks;

        private Dictionary<Category, List<string>> FallbackAnswers;

        /// <summary>
        /// Constructor for Deck class that initializes a master dictionary to hold all questions categorized by their respective categories.
        /// </summary>
        /// <param name="questionCategories"> Uses IEnumerable to allow iteration through a list of questionCategories (declared in the enum class)</param>
        public Deck(IEnumerable<Category> questionCategories) 
        {
            QuestionDecks = new Dictionary<Category, List<Card>>();

            // Creates an empty list of cards for each category, initializing the dictionary
            foreach (var category in questionCategories)
            {
                QuestionDecks[category] = new List<Card>();
            }

            InitializeFallbackAnswers();
        }


        //private Card CreateCard(Category questionCategory)
        //{

        //    // Logic for finding all answers from same category

        //    // Logic for getting the question and correct answer
        //    return new Card(questionCategory, questionText, choices, correctAnswer);
        //}

        /// <summary>
        /// A void method to provide a dictionary of choices/answers when needed.
        /// </summary>
        /// <remarks>
        ///           Consider the scenario: Given the Deck class uses answers from other questions of the same category 
        ///           to fill the 'choices' on a card, the first few cards will not have enough other cards to source choices from.
        ///           To fix this, we provide generic answers relevant to each category that can be used as 'fallback'.
        /// /remarks>
        private void InitializeFallbackAnswers()
        {
            FallbackAnswers = new Dictionary<Category, List<string>>
            {
                [Category.Characters] = new List<string>
                {
                    "Luke Skywalker", "Darth Vader", "Han Solo", "Princess Leia",
                    "Obi-Wan Kenobi", "Yoda", "Chewbacca", "R2-D2", "C-3PO", "Anakin Skywalker",
                    "Mace Windu", "Padme Amidala", "Jango Fett", "Kylo Ren", "Rey", "Finn"

                },

                [Category.PlanetsAndLocations] = new List<string>
                {
                    "Tatooine", "Hoth", "Endor", "Naboo", "Coruscant",
                    "Exegol", "Yavin 4", "Dagobah", "Bespin", "Kamino",
                    "Felucia", "Takodana", "Mustafar", "Kashyyyk", "Alderaan",
                    "Geonosis"
                },

                [Category.ShipsVehiclesAndTech] = new List<string>
                {
                    "TIE Advanced x1", "Slave I", "X-Wing", "Y-Wing",
                    "AT-AT", "AT-ST", "Anakin's Podracer", "The Supremacy",
                    "ARC-170 Starfighter", "Tantive IV", "Protocol Droid", "Astromech Droid",
                    "Millennium Falcon", "Death Star", "TIE Interceptor", "Starkiller Base"
                },

                [Category.EventsAndBattles] = new List<string>
                {
                    "Battle of Geonosis", "Battle of Endor", "Battle of Jakku", "Duel on Mustafar",
                    "Duel on Naboo", "Revenge of the Sith", "Attack of the Clones", "Siege of Mandalore",
                    "Purge of Mandalore", "Battle of Scarif", "Battle of Ryloth", "The Phantom Menace",
                    "Ahsoka Tano vs. Darth Maul", "Yoda vs. Sidius", "Obi-Wan vs. Grevious", "Rey vs. Kylo Ren"
                },

                [Category.QuotesAndLore] = new List<string>
                {
                    "\"There is no emotion, there is peace.\"", "\"Do. Or do not. There is no try.\"", "\"Aren't you a little short for a stormtrooper?\"", "\"I know.\"",
                    "Obi-Wan Kenobi", "Yoda", "Darth Vader", "Darth Sidius",
                    "Lightsaber", "Darth Bane", "Admiral Ackbar", "One master and one apprentice",
                }
            };

        }

        private void SeedInitialQuestions()
        {
            // @TODO add 5 hardcoded questions per category
        }
    }
}
