using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Questions
    {
        public string QuestionText { get; set; }

        public string[] Answers { get; set; }

        public int CorrectAnswersIndex { get; set; }

        public Questions(string questionText, string[] answer, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Answers = answer;
            CorrectAnswersIndex = correctAnswerIndex;
        }

        public bool isCorrect(int choice) { 
            return CorrectAnswersIndex == choice;
        }
    }
}
