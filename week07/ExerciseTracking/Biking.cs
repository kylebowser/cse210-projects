using System;

class Biking : Activity
{
    private string _name = "Biking"; 
    public Biking(double speed, string date, int min) : base(date, min)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        _distance = (_speed * _min);
        return _distance;
    }
    public override double GetPace()
    {
        _pace = (60 / _speed);
        return _pace;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetName()
    {
        return _name;
    }
}