using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int number;

        do
        {
            Console.Write("Enter a number? ");
            number = int.Parse(Console.ReadLine());
            if (number != 0) {
                numbers.Add(number);}

        } while (number != 0);

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maxNumber = numbers.Max();
        Console.WriteLine("The maximum number is: " + maxNumber);

    }
}