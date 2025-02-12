using System;

namespace Targetting;

public class Sniper : Character
{
    private bool airTargetting;

    public Sniper(bool _airTargetting, int _atk, int _minRange, int _maxRange) : base(_atk, _minRange, _maxRange)
    {
        airTargetting = _airTargetting;
    }
    public bool GetAirTargetting()
    {
        return airTargetting;
    }
}
