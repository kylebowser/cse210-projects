using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description,
    string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted += 1;
        return int.Parse(_points);
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
            if (IsComplete())
            {
                return($"[X] {_shortName} ({_description}) -- {_amountCompleted}/{_target}");
            }
            else
            {
                return($"[ ] {_shortName} ({_description}) -- {_amountCompleted}/{_target}");
            }
    }

    public override string GetStringRepresentation()
    {
        return ($"X*3*{_shortName}*{_description}*{_points}*{_target}*{_bonus}*{_amountCompleted}");
    }
}