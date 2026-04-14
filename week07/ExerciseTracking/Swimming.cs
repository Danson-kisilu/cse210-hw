using System;

namespace ExerciseTracking;

public class Swimming : Activity
{
    private int _numLaps;

    public Swimming(string date, int minutes, int numLaps) : base(date, minutes)
    {
        _numLaps = numLaps;
    }

    public override double GetDistance()
    {
        return _numLaps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}