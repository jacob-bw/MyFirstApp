using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter your name...");
            var userEntry = Console.ReadLine();

            Console.WriteLine(userEntry);

            Console.ReadLine();

            if (userEntry == "Jacob")
            {
                Console.WriteLine("You are doing fine");
            }
            else
            {
                Console.WriteLine("yeehaw cowboy");
            }

            var j = 0;
            while (j < 10)
            {
                Console.WriteLine($"Current value of j is {j++}...");
                
            }

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Current value of i is {i}...");
            }
            foreach (var currentCharacter in userEntry)
            {
                Console.WriteLine($"The current character is {currentCharacter}...");
            }

            switch (userEntry)
            {
                case "Nathan":
                    Console.WriteLine("It's Jacob");
                    break;
                default:
                    Console.WriteLine("it's anyone but Jacob");
                    break;
            }

            var isNathan = userEntry == "Nathan" ? true : false;
        }
    }
}
