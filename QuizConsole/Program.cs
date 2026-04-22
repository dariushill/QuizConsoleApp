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
            int totalQuestions = 0;

            QuizeGame question = new QuizeGame();

            string userName = question.WelcomeMessage();
            Console.WriteLine($"Welcome, {userName} to game {games}");


            while (!playAgain)
            {
                if (question.AskQuestion("What is 2 + 2?", "4")) correct++;
                if (question.AskQuestion("What is the capital of France?","Paris")) correct++;
                if (question.AskQuestion("What is 5 * 3?", "15")) correct++;

                totalQuestions = correct + wrong;

                question.Results(correct, totalQuestions);
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
