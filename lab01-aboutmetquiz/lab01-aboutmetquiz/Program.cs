using System;

namespace lab01_aboutmetquiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my About Me Quiz!");
            Question1();
            Question2();
        }

        static void Question1()
        {
            Console.WriteLine("How many siblings do I have?");
            int answer1 = Int32.Parse(Console.ReadLine());
            if(answer1 == 2)
            {
                Console.WriteLine("You are correct!");
            }
            else
            {
                Console.WriteLine("Wrong! I have 2 siblings.");
            }

        }

        static void Question2()
        {

        }

    }
}
