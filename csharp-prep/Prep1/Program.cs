using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeAsInt = int.Parse(grade);
        string gradeLetter;

        if (gradeAsInt >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeAsInt >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeAsInt >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeAsInt >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        if (gradeAsInt >= 70)
        {
            Console.WriteLine($"You passed the class with a {gradeLetter}.");
        }
        else
        {
            Console.WriteLine($"You failed the class with a {gradeLetter}.");
        }
    }
}