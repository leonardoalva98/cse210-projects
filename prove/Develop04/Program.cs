class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1": activity = new BreathingActivity(); break;
                case "2": activity = new ReflectionActivity(); break;
                case "3": activity = new ListingActivity(); break;
                case "4": return;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to continue.");
                    Console.ReadLine();
                    continue;
            }

            Console.Clear();
            activity.Run();
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}
