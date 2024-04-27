using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int count = 0;
        int guess;
        int number = randomGenerator.Next(1, 100);
        Console.WriteLine("Guess a number between 1 and 100");
        do
        {
            Console.Write("What is your guess?: ");
            guess = int.Parse(Console.ReadLine());
            if (guess > number)
            {
                Console.WriteLine("Too high!");
            }
            else if (guess < number)
            {
                Console.WriteLine("Too low!");
            }
            count ++;
        }while (guess != number);

        Console.WriteLine($"You guessed in {count} attempts!");
    }
}