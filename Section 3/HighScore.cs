using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        static int highScore = 100;
        static string topScorer = "Jim";
        public static void Main(string[] args)
        {
            EnterScoringDetails();
            Console.ReadKey();
            
        }

        public static void EnterScoringDetails()
        {
            Console.WriteLine("Please enter your score:");
            bool validScoreInput = int.TryParse(Console.ReadLine(), out int playerScore);

            Console.WriteLine("Please enter your name:");
            string playerName = Console.ReadLine();

            if (validScoreInput)
            {
                CheckHighScore(playerScore, playerName);
            }
            else
            {
                Console.WriteLine("Please enter a valid score");
            }
        }

        public static void CheckHighScore(int score, string playerName)
        {
            if (score > highScore)
            {
                highScore = score;
                topScorer = playerName;
                Console.WriteLine("New highscore is {0}\nNew highscore holder is {1}", score, playerName);
            } else
            {
                Console.WriteLine("The old highscore of {0} was not broken and is still held by {1}", highScore, topScorer);
            }
        }
    }
}
