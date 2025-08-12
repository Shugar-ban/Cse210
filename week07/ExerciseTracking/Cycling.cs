using System;

public class Cycling : Activity
{
    public double Speed { get; set; }

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        Speed = speed;
    }

    public override double GetDistance() => (Speed * Minutes) / 60;
    public override double GetSpeed() => Speed;
    public override double GetPace() => 60 / Speed;
}