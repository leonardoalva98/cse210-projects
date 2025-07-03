using System.ComponentModel;

public class SimpleGoal : Goal
{
    private Boolean _isCompleted;

    public SimpleGoal(string type, string name, string description, int points, bool isCompleted)
    : base(type, name, description, points)
    {
        _isCompleted = isCompleted;
        if (_isCompleted)
        {
            _goalStatus = "X";
        }
    }

    public void SetGoal(string name, string desc, int points)
    {
        _goalName = name;
        _goalDescription = desc;
        _points = points;


    }
    public void SetGoalStatus(bool isCompleted)
    {
        _isCompleted = isCompleted;
    }
    public bool getGoalStatus()
    {
        return _isCompleted;
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
        return $"{_goalType}:{_goalName},{_goalDescription},{_points},{_isCompleted}";
    }
    public override void RecordEvent(List<Goal> list)
    {
        _isCompleted = true;
        _goalStatus = "X";
        SumPoints(_points, list);
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        Console.WriteLine($"You now have {_ListTotalPoints} points.");
    }

    public override int GetPoints()
    {
        return _points;
    }

}