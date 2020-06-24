using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {

            double counter = 1;
            bool enteringScores = true;
            double total = 0;

            while (enteringScores)
            {
                Console.WriteLine("Please enter score for student {0} (Enter -1 if you want to exit)", counter);
                bool validScore = double.TryParse(Console.ReadLine(), out double scoreEntered);

                if (validScore && (scoreEntered >= 0 && scoreEntered <= 20))
                {
                    total += scoreEntered;
                    counter++;
                } else if (validScore && scoreEntered == -1)
                {
                    //add 1 to the total to nullify the -1 added to the total
                    CalculateAverage(total + 1, counter);
                    break;
                } else
                {
                    Console.WriteLine("Please enter a valid score between 1 and 20");
                }
            }

            Console.ReadLine();
        }

        public static void CalculateAverage(double total, double counter)
        {
            //subtract 1 from each to ignore the -1 value entered
            double averageScore = (total - 1) / (counter - 1);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Total number of students: {0} \nAverage Score: {1}", (counter - 1), averageScore);
        }
    }
}
