using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Quiz
    {
        private Questions[] _questions;

        private int _score;

        public Quiz(Questions[] questions)
        {
            this._questions = questions;
            _score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to Quiz App");
            int questionNumber = 1;

            foreach (var item in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}");
                DisplayQuestions(item);
                int userChoice = GetUserChoice();
                if (item.isCorrect(userChoice)) {
                    Console.WriteLine("Correct!");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Wrong answer! The correct answer was: {item.CorrectAnswersIndex+1}.{item.Answers[item.CorrectAnswersIndex]}");
                }

                Console.WriteLine();
            }

            DisplayResults();

        }

        private void DisplayResults() 
        { 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=======================================================");
            Console.WriteLine("||                      Results                      ||");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

            Console.WriteLine($"Quiz is finished. Your score is: {_score} out of {_questions.Length}");

            double percentage = (double)_score / _questions.Length;
            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent!");
            }
            else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good!");
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Review your History!");
            }   
            Console.ResetColor();
        }


        private void DisplayQuestions(Questions question)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=======================================================");
            Console.WriteLine("||                     Quiz App                      ||");
            Console.WriteLine("=======================================================");
            Console.WriteLine($">>>{question.QuestionText}");

            for (int i = 0; i < question.Answers.Length; i++) {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("    ");
                Console.Write(i + 1);
                Console.WriteLine($". {question.Answers[i]}");
            }
        }

        private int GetUserChoice()
        {
            Console.Write($"Your answer(number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4) {
                Console.WriteLine("Invalid choice, please do enter correct number from the choices.");
                input = Console.ReadLine();
            }

            return choice -1;
        }
    }
}
