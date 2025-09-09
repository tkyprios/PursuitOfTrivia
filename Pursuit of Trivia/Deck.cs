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

        /// <summary>
        /// Constructor for Deck class that initializes a master dictionary to hold all questions categorized by their respective categories.
        /// </summary>
        /// <param name="questionCategories"> Uses IEnumerable to allow iteration through a list of questionCategories (declared in the enum class)</param>
        public Deck(IEnumerable<Category> questionCategories) 
        {
            QuestionDecks = new Dictionary<Category, List<Card>>();

            // Creates an empty list of cards for each category
            foreach (var category in questionCategories)
            {
                QuestionDecks[category] = new List<Card>();
            }
        }
    }
}
