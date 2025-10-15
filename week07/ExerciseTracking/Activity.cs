using System;

public abstract class Activity
{
    private string _date;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected int _min;

    public Activity(string date, int min)
    {
        _date = date;
        _min = min;
    }

    public abstract double GetPace();
    public abstract double GetSpeed();
    public abstract double GetDistance();
    public abstract string GetName();
    public virtual string GetSummary()
    {
        return ($"{_date} {GetName()} ({_min} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km");
    }
}