using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            bool keepLooping = true;

            Random rand = new Random();
            int secretNumber = rand.Next(1, 10);
            Console.WriteLine(secretNumber);
            while(keepLooping)
            {
                Console.WriteLine("Enter a number between 1 and 10:");
                int num = int.Parse(Console.ReadLine());
                if (num == secretNumber)
                {
                    Console.WriteLine("Correct!");
                    keepLooping = false;
                }
                
            }
            Console.ReadLine();
        }
    }
}
