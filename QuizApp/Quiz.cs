using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {
            this._questions = questions; 
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz");
            int questionNumber = 1;

            foreach (Question question in _questions)
            {
                Console.WriteLine($"\nQuestion {questionNumber++} : ");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();

                if (question.isCorrectAnswer(userChoice)) {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer is {question.Answers[question.CorrectAnswerIndex]}");

                }

            }
        }

        private void DisplayQuestion(Question question)
        {   
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++) 
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("     ");
                Console.Write($"[ {i+1} ] ");
                Console.ResetColor();

                Console.WriteLine(question.Answers[i]);
            
            }
        }

        private int GetUserChoice()
        {
            Console.Write("Your Answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice > 4 || choice < 1 )
            {
                Console.WriteLine("Invalid Choice. Please enter a number between 1 and 4");
                Console.Write("You Answer (1-4) : ");
                input  = Console.ReadLine();
            }
            
            return choice-1;
        }

    }
}
