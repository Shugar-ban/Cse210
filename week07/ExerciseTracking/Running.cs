using System;

public class Running : Activity
{
    public double Distance { get; set; }

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        Distance = distance;
    }

    public override double GetDistance() => Distance;
    public override double GetSpeed() => (Distance / Minutes) * 60;
    public override double GetPace() => Minutes / Distance;
}