using System;
using System.Collections.Generic;
using System.Text;

namespace QuizConsole
{
    public class QuizeGame
    {
        public string WelcomeMessage()
        {
            Console.WriteLine("Hello user welcome to my quiz game");
            Console.WriteLine("What is your name: ");

            string? userName = Console.ReadLine();

            return userName;
        }


        public bool AskQuestion(string question, string correctAnswer)
        {
            bool correct = false;
            Console.WriteLine(question);
            string? userAnswer = Console.ReadLine();

            if (userAnswer?.ToLower() == correctAnswer.ToLower())
            {
                Console.WriteLine("Correct!");
                return true;
            }
            else
            {
                Console.WriteLine($"Wrong! The correct answer is {correctAnswer}");
                return false;
            }

        }

        public void Results(int score, int questions)
        {
            Console.WriteLine($"Score: {score / questions}");
        }
    }
}
