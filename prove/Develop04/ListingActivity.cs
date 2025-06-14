class ListingActivity : Activity
{
    private List<string> prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Run()
    {
        Start();

        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        Console.WriteLine("You may begin in:");
        ShowCountdown(3);

        var items = new List<string>();
        var start = DateTime.Now;

        while ((DateTime.Now - start).TotalSeconds < _duration)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);
        }

        Console.WriteLine($"You listed {items.Count} items.");
        End();
    }
}
