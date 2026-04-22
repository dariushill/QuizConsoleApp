using System;
using System.Collections.Generic;
using System.Text;

namespace QuizConsole
{
    public class ConsoleMessage
    {
        public string WelcomeMessage()
        {
            Console.WriteLine("Hello user welcome to my quize game");
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
                correct = true;
            }
            else
            {
                Console.WriteLine($"Wrong! The correct answer is {correctAnswer}");
                correct = false;
            }

            return correct;
        }

        public void Results(int correct, int wrong)
        {
            Console.WriteLine($"you have {correct} questions correct.");
            Console.WriteLine($"you have {wrong} questions wrong");
        }
    }
}
