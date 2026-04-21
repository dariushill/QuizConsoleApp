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

            string userName = Console.ReadLine();

            return userName;
        }

        public string QuestionOne()
        {

            Console.WriteLine("What is 2 + 2?");

            string userAnswer = Console.ReadLine();

            return userAnswer;

        }

        public string QuestionTwo()
        {
            Console.WriteLine("What is the capital of France?");

            string userAnswer = Console.ReadLine();

            return userAnswer;
        }

        public string QuestionThree()
        {
            Console.WriteLine("What is 5 * 3?");

            string userAnswer = Console.ReadLine();

            return userAnswer;
        }

        public void Results(int correct, int wrong)
        {
            Console.WriteLine($"you have {correct} questions correct.");
            Console.WriteLine($"you have {wrong} questions wrong");
        }
    }
}
