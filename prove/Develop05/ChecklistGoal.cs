public class ChecklistGoal : Goal
{
    private int _numToAccomplish;
    private int _accomplishBonus;
    private int _currentlyAccomplished;


    public ChecklistGoal(string type, string name, string description, int points, int numToAccom, int currently, int accomplishBonus)
     : base(type, name, description, points)
    {
        _currentlyAccomplished = currently;
        _numToAccomplish = numToAccom;
        _accomplishBonus = accomplishBonus;

        if (_currentlyAccomplished >= _numToAccomplish)
        {
            _goalStatus = "X";
        }
        else
        {
            _goalStatus = " "; 
        }
    }


    public void SetGoal(string name, string desc, int points, int numToAccomplish, int accomplishBonus)
    {
        _goalName = name;
        _goalDescription = desc;
        _points = points;
        _numToAccomplish = numToAccomplish;
        _accomplishBonus = accomplishBonus;
        _currentlyAccomplished = 0;
        _goalStatus = " ";
    }

    public int getCurrentlyAccomplished()
    {
        return _currentlyAccomplished;
    }
    public int getNumToAccomplish()
    {
        return _numToAccomplish;
    }

    public override void CreateNewGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus?");
        int numToAccomplish = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times?");
        int accomplishBonus = int.Parse(Console.ReadLine());
        SetGoal(name, description, goalPoints, numToAccomplish, accomplishBonus);
        Console.Clear();
    }
    public override string StringFormat()
    {
        return $"{_goalType}:{_goalName},{_goalDescription},{_points},{_accomplishBonus},{_numToAccomplish},{_currentlyAccomplished}";

    }

    public override void ListGoals(Goal List)
    {
        Console.WriteLine($"[{_goalStatus}] {_goalName} ({_goalDescription}) -- Currently Completed: {_currentlyAccomplished}/{_numToAccomplish}");
    }
    public override void RecordEvent(List<Goal> list)
    {
        SumPoints(_points, list);

        _currentlyAccomplished += 1;

        if (_currentlyAccomplished >= _numToAccomplish)
        {
            _goalStatus = "X";
            Console.WriteLine($"Congratulations! You have earned {_points + _accomplishBonus} points!");
            _ListTotalPoints += _accomplishBonus;
            Console.WriteLine($"You now have {_ListTotalPoints} points.");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            Console.WriteLine($"You now have {_ListTotalPoints} points.");
        }
    }

    public override int GetPoints()
    {
        return _points;
    }

    public int GetBonus()
    {
        return _accomplishBonus;
    }



}