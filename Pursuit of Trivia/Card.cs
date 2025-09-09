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
        public Category QuestionCategory { get; private set; }
        public string QuestionText { get; private set; }
        public List<String> Choices { get; private set; }

        private string CorrectAnswer { get; set; }
        public Card(Category questionCategory, string questionText, List<String> choices, string correctAnswer)
        {
            QuestionCategory = questionCategory;
            QuestionText = questionText;
            Choices = choices;
            CorrectAnswer = correctAnswer;

        }
    }
}
