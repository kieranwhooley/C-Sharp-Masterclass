using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {

        static string username;
        static string password;
        static void Main(string[] args)
        {

            Register();
            ValidateLoginCredentials();

            Console.ReadKey();
        }

        public static void Register()
        {
            Console.WriteLine("Please enter username:");
            username = Console.ReadLine();

            Console.WriteLine("Please enter password:");
            password = Console.ReadLine();

            Console.WriteLine("Details saved");
            Console.WriteLine("****************");
        }

        public static void ValidateLoginCredentials()
        {
            Console.WriteLine("Please enter username for validation");
            string usernameConfirmation = Console.ReadLine();
            
            if (usernameConfirmation.Equals(username))
            {
                Console.WriteLine("Please enter password for validation");
                string passwordConfirmation = Console.ReadLine();
                if (passwordConfirmation.Equals(password))
                {
                    Console.WriteLine("Successfully logged in as {0}", usernameConfirmation);
                } else
                {
                    Console.WriteLine("Invalid password");
                }
            } else
            {
                Console.WriteLine("Invalid username");
            }
        }

    }
}
