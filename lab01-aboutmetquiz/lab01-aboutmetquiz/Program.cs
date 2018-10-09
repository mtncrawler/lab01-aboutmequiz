using System;

namespace lab01_aboutmetquiz
{
    class Program
    {
        //main method to call methods for 5 questions about me
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my About Me Quiz!");
            Console.WriteLine(Question1());
            Question2();
            Console.WriteLine($"The answer is {Question3()}!");
            Question4();
            Question5();
        }

        //method to ask how many siblings I have then return a string
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

        //method to ask where in South America I want to visit then returns void type
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

        //method to ask bool question whether I have lived in 5 states then returns bool
        static bool Question3()
        {
            Console.WriteLine("True or false: I have lived in 5 states.");

            //while loop with try/catch to ensure the user enters a valid bool, if not it will continue loop until valid response is received
            while (true)
            {
                try
                {
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
                catch (Exception e)
                {
                    Console.WriteLine("Exception: {0}. Please enter true or false.", e.Message);
                    continue;
                }
            }
            

            
        }

        //method to ask what month I was born then return void type
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

        //method to ask what superpower I want then returns void type
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
