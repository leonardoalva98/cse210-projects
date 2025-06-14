public class Activity
{
    protected int _duration;
    protected string _activityName;
    protected string _description;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}!");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(2);
    }

    public void End()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"You completed the {_activityName} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            for (int j = 0; j < i.ToString().Length + 1; j++)
            {
                Console.Write("\b \b");
            }
        }
        Console.WriteLine();
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = {"|", "/", "-", "\\"};
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\r{spinner[i % 4]}");
            Thread.Sleep(250);
        }
        Console.Write("\r ");
    }

    public virtual void Run()
    {   
    }
}

