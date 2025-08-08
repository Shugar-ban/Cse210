public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent() => _points;
    public override string GetStatus() => "[∞]";
    public override string GetDetails() => $"{_name} ({_description})";
    public override bool IsComplete() => false;
}