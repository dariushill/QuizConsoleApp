namespace QuizConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correct = 0;
            int wrong = 0;

            ConsoleMessage question = new ConsoleMessage();

            string answerOne = question.QuestionOne();
            string answerTwo = question.QuestionTwo();
            string answerThree = question.QuestionThree();

            if (answerOne == "4")
            {
                correct++;
            }
            else
            {
                wrong++;
            }

            if (answerTwo.ToLower() == "Paris")
            {
                correct++;
            }
            else
            {
                wrong++;
            }

            if (answerThree == "15")
            {
                correct ++;
            }
            else
            {
                wrong++;
            }

            question.Results(correct, wrong);
        }
    }
}
