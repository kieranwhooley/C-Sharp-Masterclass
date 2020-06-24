using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            int temperature = 15;
            string stateOfMatter;

            stateOfMatter = temperature < 0 ? "solid" : temperature > 100 ? "gas" : "liquid";
            Console.WriteLine("Temperature is {0}, so water is {1}", temperature, stateOfMatter);
            temperature -= 30;
            stateOfMatter = temperature < 0 ? "solid" : temperature > 100 ? "gas" : "liquid";
            Console.WriteLine("Temperature is {0}, so water is {1}", temperature, stateOfMatter);
            temperature += 120;
            stateOfMatter = temperature < 0 ? "solid" : temperature > 100 ? "gas" : "liquid";
            Console.WriteLine("Temperature is {0}, so water is {1}", temperature, stateOfMatter);
            Console.Read();
        }
    }
}
