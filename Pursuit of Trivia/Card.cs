using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pursuit_of_Trivia
{
    /// <summary>
    /// Card class represents a trivia question card with its question text and possible answers to choose from.
    /// </summary>
    internal class Card
    {
        public Category QuestionCategory { get; }
        public string QuestionText { get; }
        public IReadOnlyList<String> Choices { get; } // make Choices read-only to prevent modification after initialization

        private string CorrectAnswer { get; }
        public Card(Category questionCategory, string questionText, List<String> choices, string correctAnswer)
        {
            QuestionCategory = questionCategory;
            QuestionText = questionText;
            Choices = choices.ToList(); // Create a defensive copy of the provided list to ensure immutability (can't be changed)
            CorrectAnswer = correctAnswer;

        }

        /// <summary>
        /// Method to check if the provided answer is correct - uses lambda expression for simplicity of method
        /// </summary>
        /// <param name="answer">Provided answer to check against the correct answer. </param>
        /// <returns></returns>
        public bool CheckAnswer(string answer) =>
            string.Equals(answer, CorrectAnswer, StringComparison.OrdinalIgnoreCase);
    }
}
