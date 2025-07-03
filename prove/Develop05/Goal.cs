public abstract class Goal
{
    protected string _goalType;
    protected string _goalName;
    protected string _goalDescription;
    protected int _points;
    protected string _goalStatus;
    protected int _ListTotalPoints;

    public Goal(string type, string name, string description, int points)
    {
        _goalStatus = " ";
        _goalType = type;
        _goalName = name;
        _goalDescription = description;
        _points = points;
        _ListTotalPoints = 0;

    }
    public string getGoalName()
    {
        return _goalName;
    }


    public int SetListTotalPoints(int points)
    {
        _ListTotalPoints = points;
        return _ListTotalPoints;
    }
    public int GetListTotalPoint()
    {
        return _ListTotalPoints;
    }
    public void SumPoints(int points, List<Goal> list)
    {
        foreach (Goal entry in list)
        {
            entry._ListTotalPoints += points;

        }

    }
    public void SetStatus()
    {
        _goalStatus = "X";
    }
    public abstract void CreateNewGoal();
    public abstract string StringFormat();
    public virtual void ListGoals(Goal List)
    {
        Console.WriteLine($"[{List._goalStatus}] {List._goalName} ({List._goalDescription})");
    }
    public abstract void RecordEvent(List<Goal> list);

    public virtual int GetPoints()
    {
        return _points;
    }

}