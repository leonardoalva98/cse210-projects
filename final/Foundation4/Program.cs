using System;
public class Program

{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.8),
            new Cycling("04 Nov 2022", 45, 20.0),
            new Swimming("05 Nov 2022", 30, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
