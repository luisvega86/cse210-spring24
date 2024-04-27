using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new();
        int number;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number!= 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        int sum = numbers.Sum();
        float average = (float)sum / numbers.Count();

        int largest = -1;
        for ( int i = 0; i < numbers.Count; i++ )
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }   

}