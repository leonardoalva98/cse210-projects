public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Run()
    {
        Start();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            elapsed += 4;
            if (elapsed >= _duration) break;

            Console.Write("Now breathe out... ");
            ShowCountdown(4);
            elapsed += 4;
        }

        End();
    }
}