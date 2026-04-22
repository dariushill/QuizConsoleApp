namespace QuizConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = false;

            int correct = 0;
            int wrong = 0;
            int games = 0;

            ConsoleMessage question = new ConsoleMessage();

            string userName = question.WelcomeMessage();
            Console.WriteLine($"Welcome, {userName} to game {games}");


            while (!playAgain)
            {


                if (question.AskQuestion("What is 2 + 2", "4"))
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }

                if (question.AskQuestion("What is the capital of France?", "paris"))
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }

                if (question.AskQuestion("What is 5*3", "15"))
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }

                question.Results(correct, wrong);
                Console.WriteLine("Do you want to play again yes/no");
                string? response = Console.ReadLine();

                if (response?.ToLower() == "yes")
                {
                    playAgain = false;
                    games++;
                }

                else
                {
                    playAgain = true;
                    Console.WriteLine($"You played {games} game(s)");
                }
            }
 
        }
    }
}
