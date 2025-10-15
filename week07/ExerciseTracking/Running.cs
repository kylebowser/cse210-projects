using System;

class Running : Activity
{
    private string _name = "Running";
    public Running(string date, double distance, int min) : base(date, min)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
        _pace = _min / _distance;
        return _pace;
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