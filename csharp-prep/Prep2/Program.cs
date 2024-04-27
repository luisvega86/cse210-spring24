using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        string sign = "";

        Console.Write("Please enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 90)
        {
            letter = "A";
        }
        else if ( grade >= 80)
        {
            letter = "B";
        }
        else if ( grade >= 70)
        {
            letter = "C";
        }
        else if ( grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "F" && grade % 10 <= 3)
        {
            sign = " -";
        }
        else if (letter != "F" && grade % 10 >= 7)
        {
            sign = " +";
        }

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine($"You passed with '{letter}{sign}', congratulations!");
        }
        else
        {
            Console.WriteLine($"You failed with '{letter}{sign}', sorry, try again!");
        }

    }
}