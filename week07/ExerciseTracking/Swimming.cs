using System;
using System.ComponentModel;

class Swimming : Activity
{
    private double _laps;
    private string _name = "Swimming";
    public Swimming(double laps, string date, int min) : base(date, min)
    {
        _laps = laps;   
    }
    public override double GetDistance()
    {
        _distance = (_laps * 50 / 1000);
        return _distance;
    }
    public override double GetPace()
    {
        _pace = (_min / _distance);
        return (_min / GetDistance());
    }

    public override double GetSpeed()
    {
        _speed = (_distance / _min) * 60;
        return _speed;
    }

    public override string GetName()
    {
        return _name;
    }
}