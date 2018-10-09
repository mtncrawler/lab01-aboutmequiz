using System;

namespace lab01_aboutmetquiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my About Me Quiz!");
            Console.WriteLine(Question1());
            Question2();
            Console.WriteLine($"The answer is {Question3()}!");
            Question4();
            Question5();
        }

        static string Question1()
        {
            Console.WriteLine("How many siblings do I have?");
            int answer1 = Int32.Parse(Console.ReadLine());
            if(answer1 == 2)
            {
                return "You are correct!";
            }
            else
            {
                return "Wrong! I have 2 siblings.";
            }

        }

        static void Question2()
        {
            Console.WriteLine("What area of South America do I want to visit?");
            string answer2 = Console.ReadLine();
            if (answer2 == "Patagonia" || answer2 == "patagonia")
            {
                Console.WriteLine("You are correct!");
            }
            else
            {
                Console.WriteLine("Wrong! I have 2 siblings.");
            }
        }

        static bool Question3()
        {
            Console.WriteLine("True or false: I have lived in 5 states.");
            string answer3 = Console.ReadLine();

            if (Boolean.Parse(answer3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Question4()
        {
            Console.WriteLine("What month was I born?");
            string answer4 = Console.ReadLine();
            if(answer4 == "October" || answer4 == "october")
            {
                Console.WriteLine("You are correct!");
            } else
            {
                Console.WriteLine("Wrong! I was born in October.");
            }
        }

        static void Question5()
        {
            Console.WriteLine("If I could have any superpower would it be:");
            Console.WriteLine("1. Fly like Superman");
            Console.WriteLine("2. Breath underwater like Aquaman");
            Console.WriteLine("3. Run fast like Flash");
            Console.WriteLine("Select an answer 1 - 3.");
            string answer5 = Console.ReadLine();
            if( answer5 == "1")
            {
                Console.WriteLine("Correct! Fly like an eagle!");
            } else
            {
                Console.WriteLine("Wrong! I want to fly like an eagle.");
            }
        }
    }
}
