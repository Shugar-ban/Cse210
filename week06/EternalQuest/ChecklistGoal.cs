public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        if (_currentCount == _targetCount)
            return _points + _bonus;
        return _points;
    }

    public override string GetStatus() => _currentCount >= _targetCount ? "[X]" : $"[{_currentCount}/{_targetCount}]";
    public override string GetDetails() => $"{_name} ({_description})";
    public override bool IsComplete() => _currentCount >= _targetCount;
}