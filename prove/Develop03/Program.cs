using System;

class Program
{
    static void Main()
    {
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy.")
        };

        Random random = new Random();
        int randomIndex = random.Next(scriptureLibrary.Count);
        Scripture selectedScripture = scriptureLibrary[randomIndex];

        while (!selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            selectedScripture.DisplayScripture();

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            break;

            selectedScripture.HideWords();

            if (selectedScripture.IsCompletelyHidden())
            {
            Console.Clear();
            selectedScripture.DisplayScripture();
            break;
            }
        }

        Console.WriteLine("\nAll words are now hidden. Goodbye!");
    }
}