using System;


namespace SelectionStatementsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine(); //Evaluate to a string

            switch (subject)
            {
                case "math":
                    Console.WriteLine("Math is a tough subject!");
                    break;

                case "english":
                    Console.WriteLine("English is no fun!");
                    break;

                case "history":
                    Console.WriteLine("History is Cool!");
                    break;

                case "science":
                    Console.WriteLine("Science is very interesting!");
                    break;

                case "Art":
                    Console.WriteLine("Art is very Fun!");
                    break;

                default:
                    Console.WriteLine($"Oh wow! I haven't taken that subject before. {subject} sounds cool!");
                    break;
            }

        }
    }
}