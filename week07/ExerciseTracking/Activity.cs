using System;

public abstract class Activity
{
    private DateTime _date;
    private int _length; // In minutes

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }

    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_length} min): " +
               $"Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace {GetPace():0.0} min/km";
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}
