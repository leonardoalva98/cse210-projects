using System;

class Program
{
    static void Main(string[] args)
    {
    
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);
        int guess;
        do
            {
            Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }
                } while (guess != magic);

                Console.WriteLine("You guessed it!");


    }
}