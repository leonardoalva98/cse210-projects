public class EternalGoal : Goal
{

    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {

    }
    public void SetGoal(string name, string desc, int points)
    {
        _goalName = name;
        _goalDescription = desc;
        _points = points;

    }
    public override void CreateNewGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
        SetGoal(name, description, goalPoints);
        Console.Clear();
    }
    public override string StringFormat()
    {
        return $"{_goalType}:{_goalName},{_goalDescription},{_points}";

    }
    public override void RecordEvent(List<Goal> list)
    {

        SumPoints(_points,list);
       


        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        Console.WriteLine($"You now have {_ListTotalPoints} points.");

    }

}